using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    public class HumanPlayer : IPlayer
    {
        public string Name { get; }

        public HumanPlayer(string name)
        {
            Name = name;
        }

        public string GetGuess()
        {
            Console.Write($"{Name}, ingrese una letra: ");
            return Console.ReadLine().ToLower();
        }

        public void NotifyResult(string letter, bool correct)
        {
            Console.WriteLine(correct
                        ? $"{Name}: ¡Correcto!"
                        : $"{Name}: La letra '{letter}' no está.");
        }
    }
}