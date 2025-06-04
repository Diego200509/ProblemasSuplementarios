using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado2
{
    public class RandomWordProvider : IWordProvider
    {
        private readonly string[] _words;
        public RandomWordProvider()
        {
            this._words = new string[] {
                "argentino",
                "narco",
                "aeropuerto"
            };
        }

        public string GetWord()
        {
            var rnd = new Random();
            return this._words[rnd.Next(this._words.Length)];
        }
    }
}