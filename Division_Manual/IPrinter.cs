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
    public interface IPrinter
    {
        public void PrintHeader(BigInteger dividend, BigInteger divisor);
        public void PrintStep(int position, BigInteger current, BigInteger subtract, int offset);
        public void PrintRemainder(BigInteger remainder, int position);
    }
}
