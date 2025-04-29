using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumberMultiplier
{
    public class RomanNumeralConverter
    {
        private static readonly Dictionary<char, int> RomanToDecimalMap = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        private static readonly List<(int Value, string Symbol)> DecimalToRomanMap = new List<(int, string)>
        {
            (1000, "M"),
            (900, "CM"),
            (500, "D"),
            (400, "CD"),
            (100, "C"),
            (90, "XC"),
            (50, "L"),
            (40, "XL"),
            (10, "X"),
            (9, "IX"),
            (5, "V"),
            (4, "IV"),
            (1, "I")
        };

        // Principio de Abierto/Cerrado (OCP) - La clase está abierta a extensión pero cerrada a modificación
        public static int RomanToDecimal(string roman)
        {
            int total = 0;
            int previousValue = 0;

            for (int i = roman.Length - 1; i >= 0; i--)
            {
                if (!RomanToDecimalMap.TryGetValue(roman[i], out int currentValue))
                {
                    throw new ArgumentException($"Carácter romano no válido: {roman[i]}");
                }

                if (currentValue < previousValue)
                {
                    total -= currentValue;
                }
                else
                {
                    total += currentValue;
                }

                previousValue = currentValue;
            }

            return total;
        }

        public static string DecimalToRoman(int number)
        {
            if (number < 1 || number > 3999)
            {
                throw new ArgumentOutOfRangeException(nameof(number), "El número debe estar entre 1 y 3999");
            }

            var roman = new System.Text.StringBuilder();

            foreach (var (value, symbol) in DecimalToRomanMap)
            {
                while (number >= value)
                {
                    roman.Append(symbol);
                    number -= value;
                }
            }

            return roman.ToString();
        }
    }
}
