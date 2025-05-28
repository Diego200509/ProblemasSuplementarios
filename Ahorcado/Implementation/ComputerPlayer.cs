using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    public class ComputerPlayer : IPlayer
    {
        private readonly HashSet<char> _tried = new();
        private readonly Random _random = new();
        public string Name => "Computadora";

        public string GetGuess()
        {
            char letter;
            do
            {
                letter = (char)_random.Next('a', 'z' + 1);
            } while (_tried.Contains(letter));
            _tried.Add(letter);
            Console.WriteLine($"{Name} intenta con: {letter}");
            return letter.ToString();
        }

        public void NotifyResult(string letter, bool correct)
        {
            Console.WriteLine(correct
                ? $"{Name}: Acertó."
                : $"{Name}: Falló.");
        }
    }
}