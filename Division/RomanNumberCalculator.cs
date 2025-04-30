using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumberMultiplier
{
    // Clase principal que coordina las operaciones
    public class RomanNumberCalculator
    {
        private readonly IMultiplier _multiplier;

        // Principio de Inversión de Dependencias (DIP) - Dependemos de una abstracción (IMultiplier)
        public RomanNumberCalculator(IMultiplier multiplier)
        {
            _multiplier = multiplier ?? throw new ArgumentNullException(nameof(multiplier));
        }

        public (string RomanResult, int DecimalResult) MultiplyRomanNumbers(params string[] romanNumbers)
        {
            if (romanNumbers == null || romanNumbers.Length == 0)
            {
                throw new ArgumentException("Debe proporcionar al menos un número romano");
            }

            // Convertir números romanos a decimales
            int[] decimalNumbers = new int[romanNumbers.Length];
            for (int i = 0; i < romanNumbers.Length; i++)
            {
                decimalNumbers[i] = RomanNumeralConverter.RomanToDecimal(romanNumbers[i]);
            }

            // Multiplicar los números
            int product = _multiplier.Multiply(decimalNumbers);

            // Convertir el resultado de vuelta a romano
            string romanProduct = RomanNumeralConverter.DecimalToRoman(product);

            return (romanProduct, product);
        }
    }
}
