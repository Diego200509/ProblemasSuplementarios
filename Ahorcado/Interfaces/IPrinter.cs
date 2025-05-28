using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado {
    public interface IPrinter
    {
        public void Print();
        public void AddWord(string palabra);
    }
}
