using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    public class RandomWordProvider : IWordProvider
    {
        private readonly int _length;
        private readonly string[] _words;
        public RandomWordProvider(int length)
        {
            _length = length;
        }

        public string GetWord()
        {
            var rnd = new Random();
            return new string(Enumerable.Range(0, _length)
                .Select(_ => (char)rnd.Next('a', 'z' + 1)).ToArray());
        }
    }
}