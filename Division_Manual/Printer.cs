using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Division_Manual
{

    /// <summary>
    /// DIP: Higher level classes are not dependant on low level classes, but
    /// both are dependant on abstractions
    /// OCP: A class is open for extension but closed for modification
    /// </summary>
    public class Printer : IPrinter
    {
        public void PrintStep(int pos, BigInt current, BigInt subtract, int depth)
        {
            string currentStr = current.ToString();
            string subtractStr = subtract.ToString();
            Console.WriteLine($"{new string(' ', pos - subtractStr.Length)}{subtractStr}");
            Console.WriteLine($"{new string(' ', pos - subtractStr.Length)}{new string('-', subtractStr.Length)}");
        }
        public void PrintRemainder(BigInt remainder, int position)
        {
            Console.WriteLine($"{new string(' ', position)}{remainder}");
        }

        public void PrintHeader(BigInt dividend, BigInt divisor)
        {
            Console.WriteLine($"{dividend} | {divisor}");
        }
    }
}
