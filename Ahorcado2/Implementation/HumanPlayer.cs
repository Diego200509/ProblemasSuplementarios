namespace Ahorcado2
{
    public class HumanPlayer : IPlayer
    {
        public string Name { get; }
        private Func<string> _getInput;
        private Action<string> _showOutput;

        public HumanPlayer(string name, Func<string> inputProvider, Action<string> showOutput)
        {
            Name = name;
            _getInput = inputProvider;
            _showOutput = showOutput;
        }

        public string GetGuess()
        {
            return _getInput().ToLower();
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