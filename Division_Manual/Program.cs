using System.Numerics;
using Division_Manual;

namespace Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el dividendo (hasta 150 cifras):");
            if (!BigInteger.TryParse(Console.ReadLine(), out BigInteger dividend))
            {
                Console.WriteLine("Error: El dividendo no es un número válido.");
                return;
            }

            Console.WriteLine("Ingrese el divisor (hasta 150 cifras):");
            if (!BigInteger.TryParse(Console.ReadLine(), out BigInteger divisor))
            {
                Console.WriteLine("Error: El divisor no es un número válido.");
                return;
            }

            if (divisor.IsZero)
            {
                Console.WriteLine("Error: No se puede dividir por cero.");
                return;
            }

            IIntDivision div = new LongDivision();
            div.Divison(dividend, divisor);
        }
    }
}
