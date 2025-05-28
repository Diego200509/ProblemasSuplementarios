using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    public class WordMatcher : IWordMatcher
    {
        private string _word;

        public WordMatcher(string word)
        {
            this._word = word;
        }

        public int MatchCount(string word)
        {
            if (string.IsNullOrWhiteSpace(word) || word.Length != 1)
                return 0;

            char target = char.ToLower(word[0]);
            int count = 0;

            foreach (char c in _word)
            {
                if (c == target)
                    count++;
            }

            return count;
        }

        public bool Matches(string word)
        {
            return this._word.Contains(word.ToLower());
        }
    }
}
