using System.Globalization;

namespace Check_Protection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SOLID (DIP): Depends on abstraction
            ICheckFormatter formatter = new CheckFormatter();

            Console.WriteLine("Check Protection System (European Format)");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Valid examples: 4124.50 → **4124.50 | 82.60 → ****82.60");

            while (true)
            {
                Console.Write("\nEnter amount (0 to exit): ");
                string input = Console.ReadLine();

                if (decimal.TryParse(input, NumberStyles.Any, CultureInfo.GetCultureInfo("es-ES"), out decimal amount))
                {
                    if (amount == 0) break;

                    try
                    {
                        string result = formatter.FormatAmount(amount);
                        Console.WriteLine($"Formatted amount: {result}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid format. Use European format (e.g., 1234.56)");
                }
            }
        }
    }
}