namespace Ahorcado2
{
    public class ComputerPlayer : IPlayer
    {
        private readonly HashSet<char> _tried = new();
        private readonly Random _random = new();
        public string Name => "Computadora";
        private Action<string> _onGuessMade;
        private Action<string> _showOutput;

        public ComputerPlayer(Action<string> showOutput, Action<string> onGuessMade = null)
        {
            _onGuessMade = onGuessMade;
            _showOutput = showOutput;
        }

        public string GetGuess()
        {
            char letter;
            do
            {
                letter = (char)_random.Next('a', 'z' + 1);
            } while (_tried.Contains(letter));

            _tried.Add(letter);

            _onGuessMade?.Invoke($"{Name} intenta con: {letter}");

            return letter.ToString();
        }
        public void NotifyResult(string letter, bool correct)
        {
            if (correct)
            {
                _showOutput($"{Name}: Correcto!");
            }
            else
            {
                _showOutput($"{Name}: La letra {letter} no está");
            }
        }
    }
}