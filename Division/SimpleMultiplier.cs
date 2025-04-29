using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumberMultiplier
{
    public class SimpleMultiplier : IMultiplier
    {
        public int Multiply(params int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("Debe proporcionar al menos un número");
            }

            int result = 1;
            foreach (var number in numbers)
            {
                result *= number;
            }

            return result;
        }
    }
}
