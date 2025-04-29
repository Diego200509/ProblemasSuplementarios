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
        public Form1()
        {
            InitializeComponent();
            InitializeGameComponents();
        }

        private void InitializeGameComponents()
        {
            // Inicialización básica, pero el juego no comienza hasta "Nuevo Juego"
            lblTiempoTrans.Text = "Tiempo: 0s";
            lblCurrentPlayer.Text = "Selecciona 'Nuevo Juego' para comenzar";
        }

        private void StartNewGame(bool againstComputer)
        {
            _playAgainstComputer = againstComputer;
            _gameStarted = true;

            // Si existe un viejo GameManager, quitar sus eventos
            if (_gameManager != null)
            {
                _gameManager.TimeUpdated -= UpdateTimeDisplay;
                _gameManager.PlayerChanged -= UpdatePlayerDisplay;
                _gameManager.GameWon -= OnGameWon;
                _gameManager.GameTied -= OnGameTied;
            }

            // AHORA crear uno nuevo
            _gameManager = new GameManager(new HumanPlayer("Jugador", "X"));

            // Suscribir eventos
            _gameManager.TimeUpdated += UpdateTimeDisplay;
            _gameManager.PlayerChanged += UpdatePlayerDisplay;
            _gameManager.GameWon += OnGameWon;
            _gameManager.GameTied += OnGameTied;

            _gameManager.StartNewGame();
            tblTicTacToe.Invalidate();

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
            tblTicTacToe.Invalidate();
        }

        private void OnGameTied()
        {
            _gameStarted = false;
            MessageBox.Show("¡Empate!", "Fin del juego",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
            tblTicTacToe.Invalidate();
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
            DrawBoard(e.Graphics);

            if (_gameManager != null && _gameStarted)
            {
                DrawSymbols(e.Graphics);
            }
        }

        private void DrawBoard(Graphics g)
        {
            using (var pen = new Pen(Color.Black, 2))
            {
                for (int i = 1; i <= 2; i++)
                {
                    g.DrawLine(pen, 0, i * 100, 300, i * 100);
                    g.DrawLine(pen, i * 100, 0, i * 100, 300);
                }
            }
        }

        private void DrawSymbols(Graphics g)
        {
            for (int i = 0; i < 9; i++)
            {
                int row = i / 3;
                int col = i % 3;
                string symbol = _gameManager.GetSymbolAt(i);

                if (!string.IsNullOrEmpty(symbol))
                {
                    Image symbolImage = null;

                    if (symbol == "X")
                    {
                        symbolImage = Properties.Resources.SymbolX;  // Usando la imagen de X
                    }
                    else if (symbol == "O")
                    {
                        symbolImage = Properties.Resources.SymbolO;  // Usando la imagen de O
                    }

                    if (symbolImage != null)
                    {
                        // Ajuste para asegurar que la imagen se dibuje bien en la celda
                        g.DrawImage(symbolImage,
                                    col * 100 + 10,
                                    row * 100 + 10,
                                    80, 80); // Ajustar el tamaño si es necesario
                    }
                }
            }
        }

        private void tblTicTacToe_MouseClick(object sender, MouseEventArgs e)
        {
            if (!_gameStarted || _gameManager == null) return;

            int row = e.Y / 100;
            int col = e.X / 100;
            int position = row * 3 + col;

            if (!_gameManager.IsCellEmpty(position)) return;

            _gameManager.MakeMove(position);
            tblTicTacToe.Invalidate();

            if (_playAgainstComputer && !_gameManager.IsGameOver())
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(500);

                _gameManager.MakeComputerMove();
                tblTicTacToe.Invalidate();
            }
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