using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    public class ComputerPlayer : IPlayer
    {
        private int _lives;

        public ComputerPlayer()
        {
            this._lives = 5;
        }
        public string ChooseWord()
        {
            string letters = "abcdefghijklmnopqrstuvwxyz";
            string result = letters[new Random().Next(letters.Length)].ToString();
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
