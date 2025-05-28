using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ahorcado {
    public class WordValidator : IWordValidator
    {
        private Regex _regex;

        public WordValidator()
        {
            this._regex = new Regex("^[a-z]$");
        }
        public bool Validate(string word)
        {
            return this._regex.IsMatch(word);
        }
    }
}
