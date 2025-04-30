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
        public void PrintStep(int position, BigInteger current, BigInteger subtract, int offset)
        {
            Console.WriteLine($"{new string(' ', position+1)} {current}");
            Console.WriteLine($"{new string(' ', position)}- {subtract}");
            Console.WriteLine($"{new string(' ', position)}  {new string('-', subtract.ToString().Length)}");
        }

        public void PrintRemainder(BigInteger remainder, int position)
        {
            Console.WriteLine($"{new string(' ', position)}{remainder}");
        }

        public void PrintHeader(BigInteger dividend, BigInteger divisor)
        {
            Console.WriteLine($"{dividend} | {divisor}");
        }
    }
}
