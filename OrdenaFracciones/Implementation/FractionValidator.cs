using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OrdenaFracciones
{
    public class FractionValidator:  IValidator
    {
        private Regex _regex = new Regex(@"^[0-9\/\+\-]+$");
        public bool IsValid(string? expression)
        {
            if (string.IsNullOrWhiteSpace(expression)) return false;
            return this._regex.IsMatch(expression);
        }
    }
}
