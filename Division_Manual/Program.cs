using System.Numerics;
using Division_Manual;

namespace Division {
    internal class Program {
        static void Main(string[] args) {
            System.Console.WriteLine("Ingres el divisor");
            int dividend = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingrese el dividendo");
            int divisor = int.Parse(Console.ReadLine());
            IIntDivision div = new LongDivision();
            div.Divison(dividend, divisor);
        }
    }
}
