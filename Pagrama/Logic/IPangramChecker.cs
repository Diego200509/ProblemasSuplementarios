using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagrama.Logic
{
    public interface IPangramChecker
    {
        bool IsPangram(string sentence);
        int CountValidCharacters(string sentence);
    }
}
