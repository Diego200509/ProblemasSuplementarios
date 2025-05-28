using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado {
    public interface IPlayer
    {
        public string ChooseWord();
        public int GetTries();
        public void SetTries(int lives);
    }
}
