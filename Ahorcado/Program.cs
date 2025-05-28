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
            HumanPlayer player1 = new HumanPlayer();
            IGame juego = new ComputerGame(player1);
            IPlayer ganador = juego.PlayGame();
            System.Console.WriteLine($"El ganador es {ganador.GetType().ToString()}");
        }
    }
}