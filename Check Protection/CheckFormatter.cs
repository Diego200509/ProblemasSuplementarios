using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Protection
{
    // SOLID (SRP, OCP): Class with single responsibility, extensible
    public class CheckFormatter : ICheckFormatter
    {
        private const int AvailableSpaces = 8;
        private readonly CultureInfo culture = new CultureInfo("es-ES");
        // SOLID (LSP): Complies with interface contract
        public string FormatAmount(decimal amount)
        {
            ValidateAmount(amount);

            string amountStr = amount.ToString("0.00", culture);

            amountStr = amountStr.Replace(".", "");

            if (amountStr.Length > AvailableSpaces)
            {
                throw new InvalidOperationException("Amount exceeds available spaces.");
            }

            return amountStr.PadLeft(AvailableSpaces, '*');
        }

        private void ValidateAmount(decimal amount)
        {
            if (amount < 0)
                throw new ArgumentException("Amount cannot be negative.");

            if (amount >= 1000000)
                throw new ArgumentException("Amount is too large.");
        }
    }
}

