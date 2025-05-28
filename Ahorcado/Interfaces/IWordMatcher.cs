using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado {
    public interface IWordMatcher
    {
        public bool Matches(string word);
        public int MatchCount(string word);
    }
}
