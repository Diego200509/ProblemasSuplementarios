using System.Numerics;
using RomanNumberMultiplier;

namespace Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplicador de Números Romanos");
            Console.WriteLine("Ingrese tres números romanos (ej. VII, IX, III):");

            try
            {
                // Leer tres números romanos del usuario
                string[] romanNumbers = new string[3];
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"Número {i + 1}: ");
                    romanNumbers[i] = Console.ReadLine().Trim().ToUpper();
                }

               
                var calculator = new RomanNumberCalculator(new SimpleMultiplier());

                
                var result = calculator.MultiplyRomanNumbers(romanNumbers);

               
                Console.WriteLine("\nResultado:");
                Console.WriteLine($"En números romanos: {result.RomanResult}");
                Console.WriteLine($"En decimal: {result.DecimalResult}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}