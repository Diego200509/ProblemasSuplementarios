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
        private string _spaces;

        public Printer()
        {
            this._spaces = "";
        }
        public void Print(BigInteger divisor, BigInteger remainder)
        {
            this._spaces += " ";
            System.Console.WriteLine( this._spaces + remainder + " | ");
            System.Console.WriteLine(this._spaces + "-" + remainder + "| ");

        }
    }
}
