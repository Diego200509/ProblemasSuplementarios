using System;
using System.Drawing;
using System.Windows.Forms;
using Tic_Tac_Toe.Game;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        private GameManager _gameManager;  
        private bool _playAgainstComputer = false;
        private bool _gameStarted = false;
        private PictureBox[] _pictureBoxes;

        public Form1()
        {
            InitializeComponent();
            InitializeGameComponents();
        }

        private void InitializeGameComponents()
        {
            // Inicialización básica, pero el juego no comienza hasta "Nuevo Juego"
            lblTiempoTrans.Text = "Tiempo: 0s";
            lblCurrentPlayer.Text = "Selecciona un modode juego para comenzar";

            _pictureBoxes = new PictureBox[9]
           {
                pictureBox1, pictureBox2, pictureBox3,
                pictureBox4, pictureBox5, pictureBox6,
                pictureBox7, pictureBox8, pictureBox9
           };

            for (int i = 0; i < 9; i++)
            {
                _pictureBoxes[i].SizeMode = PictureBoxSizeMode.StretchImage;
                _pictureBoxes[i].BorderStyle = BorderStyle.FixedSingle;
                _pictureBoxes[i].Tag = i; // Guardamos la posición
                _pictureBoxes[i].Click += PictureBox_Click;
            }

        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (!_gameStarted || _gameManager == null) return;

            var picBox = sender as PictureBox;
            int position = (int)picBox.Tag;

            if (!_gameManager.IsCellEmpty(position)) return;

            _gameManager.MakeMove(position);
            UpdateBoard();

            if (_playAgainstComputer && !_gameManager.IsGameOver())
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(500);
                _gameManager.MakeComputerMove();
                UpdateBoard();
            }

        }

        private void StartNewGame(bool againstComputer)
        {
            _playAgainstComputer = againstComputer;
            _gameStarted = true;

            if (_gameManager != null)
            {
                _gameManager.TimeUpdated -= UpdateTimeDisplay;
                _gameManager.PlayerChanged -= UpdatePlayerDisplay;
                _gameManager.GameWon -= OnGameWon;
                _gameManager.GameTied -= OnGameTied;
            }

            _gameManager = new GameManager(new HumanPlayer("Jugador", "X"));

            _gameManager.TimeUpdated += UpdateTimeDisplay;
            _gameManager.PlayerChanged += UpdatePlayerDisplay;
            _gameManager.GameWon += OnGameWon;
            _gameManager.GameTied += OnGameTied;

            _gameManager.StartNewGame();
            UpdateBoard();

        }

        private void UpdateBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                string symbol = _gameManager.GetSymbolAt(i);

                if (symbol == "X")
                {
                    _pictureBoxes[i].Image = Properties.Resources.SymbolX;
                }
                else if (symbol == "O")
                {
                    _pictureBoxes[i].Image = Properties.Resources.SymbolO;
                }
                else
                {
                    _pictureBoxes[i].Image = null;
                }
            }

        }

        private void UpdateTimeDisplay(int seconds)
        {
            if (lblTiempoTrans.InvokeRequired)
            {
                lblTiempoTrans.Invoke(new Action<int>(UpdateTimeDisplay), seconds);
            }
            else
            {
                lblTiempoTrans.Text = $"Tiempo: {seconds}s";
            }
        }

        private void UpdatePlayerDisplay(IPlayer player)
        {
            if (lblCurrentPlayer.InvokeRequired)
            {
                lblCurrentPlayer.Invoke(new Action<IPlayer>(UpdatePlayerDisplay), player);
            }
            else
            {
                lblCurrentPlayer.Text = $"Turno: {player.Name} ({player.Symbol})";
            }
        }

        private void OnGameWon(IPlayer winner)
        {
            MessageBox.Show($"¡{winner.Name} ha ganado!", "Fin del juego",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            _gameStarted = false;
        }

        private void OnGameTied()
        {
            _gameStarted = false;
            MessageBox.Show("¡Empate!", "Fin del juego",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void btnNuevoJuego_Click(object sender, EventArgs e)
        {
            StartNewGame(_playAgainstComputer);
        }

        private void tblTicTacToe_Paint(object sender, PaintEventArgs e)
        {
        }

        private void tblTicTacToe_MouseClick(object sender, MouseEventArgs e)
        {
 
        }

        private void gboxTicTac_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnJugarComputadora_Click(object sender, EventArgs e)
        {
            _playAgainstComputer = true;
            btnNuevoJuego_Click(sender, e);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}