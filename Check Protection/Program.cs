using System.Globalization;

namespace Check_Protection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SOLID (DIP): Depende de una abstracción
ICheckFormatter formatter = new CheckFormatter();

Console.WriteLine("Sistema de Protección de Cheques");
Console.WriteLine("-----------------------------------------");
Console.WriteLine("Ejemplos válidos: 4124.50 → **4124.50 | 82.60 → ****82.60");

while (true)
{
    Console.Write("\nIngrese un monto (0 para salir): ");
    string input = Console.ReadLine();

    if (decimal.TryParse(input, NumberStyles.Any, CultureInfo.GetCultureInfo("es-ES"), out decimal amount))
    {
        if (amount == 0) break;

        try
        {
            string result = formatter.FormatAmount(amount);
            Console.WriteLine($"Monto formateado: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
    else
    {
        Console.WriteLine("Formato inválido. Use el formato europeo (por ejemplo, 1234.56)");
    }
}
        }
    }
}
