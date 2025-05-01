using System.Numerics;
using Division_Manual;

namespace Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el dividendo (hasta 150 cifras):");
            string dividend = Console.ReadLine();
            Console.WriteLine("Ingrese el divisor (hasta 150 cifras):");
            string divisor = Console.ReadLine();
            IPrinter printer = new Printer();
            IIntDivision div = new LongDivision(printer);
            div.Divison(new(dividend), new(divisor));
        }
    }
}
