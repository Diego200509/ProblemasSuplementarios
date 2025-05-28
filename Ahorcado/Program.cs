using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new TurnBasedHangmanGame(
                new FileWordProvider("palabras.txt"),
                new HumanPlayer("Jugador 1"),
                new ComputerPlayer()
            );
            game.Start();
        }
    }
}