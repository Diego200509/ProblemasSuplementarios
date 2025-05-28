using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    public class Printer : IPrinter
    {
        private List<string> _letters;
        private string _letter;
        public Printer(string letter)
        {
            this._letters = new List<string>();
            this._letter = letter;
        }

        public void AddWord(string palabra)
        {
            this._letters.Add(palabra);
        }

        public void Print()
        {
            foreach (var character in this._letter)
            {
                string letra = character.ToString();
                if (this._letters.Contains(letra))
                {
                    System.Console.Write(letra);
                }
                else
                {
                    System.Console.Write("_");
                }
            }
            System.Console.WriteLine();
        }
    }
}
