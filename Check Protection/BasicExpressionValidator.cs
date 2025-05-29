using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mathematical_Expressions
{
    public class BasicExpressionValidator : IExpressionValidator
    {
        private readonly Regex _validCharacters = new Regex(@"^[0-9+\-*\/().\s]+$");

        public bool IsValid(string expression)
        {
            if (string.IsNullOrWhiteSpace(expression))
                return false;

            return _validCharacters.IsMatch(expression);
        }
    }
}
