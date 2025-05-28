using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado {
    public interface IGame
    {
        public IPlayer PlayGame();
        public void AddPlayer(IPlayer player);
    }
}
