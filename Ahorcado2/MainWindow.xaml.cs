using System.Windows;

namespace Ahorcado2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IGame
    {
        private string _word;
        private char[] _display;
        private HashSet<char> _guessedLetters = new();
        private int _remainingAttempts = 10;
        private int _currentPlayerIndex = 0;
        private IPlayer[] _players;
        private IWordProvider _wordProvider = new FileWordProvider("palabras.txt");
        private string[] hangmanStages = new string[]
        {
            "",
            " O ",
            " O \n | ",
            " O \n/| ",
            " O \n/|\\",
            " O \n/|\\\n | ",
            " O \n/|\\\n | \n/  ",
            " O \n/|\\\n | \n/ \\",
            " O \n/|\\\n/|\\\n/ \\",
            " O \n/|\\\n/|\\\n/ \\\nGAME OVER"
        };
        public MainWindow()
        {
            InitializeComponent();

            // Se pasa un delegado que retorna el contenido del TextBox
            var human = new HumanPlayer(
                "Juan",
                () => TxtWord.Text,
                result => Dispatcher.Invoke(() => LblExito.Text = result));
            var computer = new ComputerPlayer(
                (msg) => Dispatcher.Invoke(() => LblMessage.Text = msg),
                result => Dispatcher.Invoke(() => LblExito.Text = result));

            _players = [human, computer];

            BtnWord.Click += BtnWord_Click;
            Start();
        }

        public void Start()
        {
            _word = _wordProvider.GetWord();
            _display = Enumerable.Repeat('_', _word.Length).ToArray();
            _guessedLetters.Clear();
            _remainingAttempts = 10;
            _currentPlayerIndex = 0;

            LblMessage.Text = $"¡Empieza el juego! Palabra de {_word.Length} letras.";
            LblPalabra.Text = string.Join(" ", _display);
            LblIntentosRestantes.Text = $"Intentos restantes: {_remainingAttempts}";
            LblPlayer.Text = $"Turno de: {_players[_currentPlayerIndex].Name}";
        }

        private async void BtnWord_Click(object sender, RoutedEventArgs e)
        {
            if (_remainingAttempts <= 0 || !_display.Contains('_')) return;

            IPlayer current = _players[_currentPlayerIndex];
            if (current is ComputerPlayer)
            {
                await Task.Delay(5000); // Espera 5 segundos para que el jugador humano vea la jugada anterior
            }
            string guess = current.GetGuess();

            if (string.IsNullOrWhiteSpace(guess) || guess.Length != 1 || !char.IsLetter(guess[0]))
            {
                LblMessage.Text = "Letra inválida.";
                return;
            }

            char letter = guess[0];
            if (_guessedLetters.Contains(letter))
            {
                LblMessage.Text = "Letra ya usada.";
                return;
            }

            _guessedLetters.Add(letter);

            if (_word.Contains(letter))
            {
                for (int i = 0; i < _word.Length; i++)
                    if (_word[i] == letter)
                        _display[i] = letter;

                current.NotifyResult(guess, true);
            }
            else
            {
                _remainingAttempts--;
                current.NotifyResult(guess, false);
            }
            this.LblHangman.Text = this.hangmanStages[this.hangmanStages.Length - _remainingAttempts];

            LblPalabra.Text = string.Join(" ", _display);
            LblIntentosRestantes.Text = $"Intentos restantes: {_remainingAttempts}";

            if (!_display.Contains('_'))
            {
                LblMessage.Text = $"¡{current.Name} gana!";
                BtnWord.IsEnabled = false;
            }
            else if (_remainingAttempts == 0)
            {
                LblMessage.Text = $"¡Se acabaron los intentos! La palabra era {_word}.";
                BtnWord.IsEnabled = false;
            }
            else
            {
                _currentPlayerIndex = (_currentPlayerIndex + 1) % _players.Length;
                LblPlayer.Text = $"Turno: {_players[_currentPlayerIndex].Name}";
                TxtWord.Text = "";
            }
        }
    }
}