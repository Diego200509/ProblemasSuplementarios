using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    public class HumanPlayer : IPlayer
    {
        private int _lives;

        public HumanPlayer()
        {
            this._lives = 5;
        }
        public string ChooseWord()
        {
            string result = Console.ReadKey().Key.ToString().ToLower();
            System.Console.WriteLine();
            return result;
        }
        public int GetTries()
        {
            return this._lives;
        }
        public void SetTries(int lives)
        {
            this._lives = lives;
        }
    }
}
