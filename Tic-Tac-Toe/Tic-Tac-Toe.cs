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

            // Crear nuevo juego
            _gameManager = new GameManager(new HumanPlayer("Jugador", "X"));

            // Limpiar suscripciones previas
            if (_gameManager != null)
            {
                _gameManager.TimeUpdated -= UpdateTimeDisplay;
                _gameManager.PlayerChanged -= UpdatePlayerDisplay;
                _gameManager.GameWon -= OnGameWon;
                _gameManager.GameTied -= OnGameTied;
            }

            // Suscribir a los eventos
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
                    var brush = symbol == "X" ? Brushes.Blue : Brushes.Red;
                    g.DrawString(symbol,
                                new Font("Arial", 24, FontStyle.Bold),
                                brush,
                                col * 100 + 30,
                                row * 100 + 30);
                }
            }
        }

        private void tblTicTacToe_MouseClick(object sender, MouseEventArgs e)
        {
            if (!_gameStarted || _gameManager == null) return;

            int row = e.Y / 100;
            int col = e.X / 100;
            int position = row * 3 + col;

            // Verificar si la celda está vacía
            if (!_gameManager.IsCellEmpty(position)) return;

            _gameManager.MakeMove(position);
            tblTicTacToe.Invalidate();

            // Si es contra computadora y el juego no ha terminado
            if (_playAgainstComputer && !_gameManager.IsGameOver())
            {
                // Pequeña pausa para que el jugador vea su movimiento
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