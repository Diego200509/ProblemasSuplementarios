using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Protection
{
    // Principio de Inversión de Dependencias (DIP) - Dependemos de abstracciones
    // Dependency Inversion Principle (DIP) - We depend on abstractions
    public class Check
    {
        private readonly ICheckFormatter _formatter;

        public Check(ICheckFormatter formatter)
        {
            _formatter = formatter ?? throw new ArgumentNullException(nameof(formatter));
        }

        public string GenerateFormattedAmount(decimal amount)
        {
            try
            {
                return _formatter.FormatAmount(amount);
            }
            catch (Exception ex)
            {
                // Best practices: Proper exception handling
                Console.WriteLine($"Error formatting amount: {ex.Message}");
                throw;
            }
        }
    }
}
