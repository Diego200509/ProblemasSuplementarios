using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado2
{
    public interface IPlayer
    {
        public string Name { get; }
        public string GetGuess();
        public void NotifyResult(string letter, bool correct);
    }
}