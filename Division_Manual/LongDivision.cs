using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Division_Manual {
    public class LongDivision : IIntDivision {
        /// <summary>
        /// SRP: Class has only one responsability
        /// OCP: Class is open for extension but closed for modification
        /// LSP: Class implements all methods from parent class
        /// DIP: Class is dependant on an abstraction
        /// </summary>
        /// <param name="dividend"></param>
        /// <param name="divisor"></param>
        /// <exception cref="DivideByZeroException"></exception>
        public void Divison(int dividend, int divisor) {
            if (divisor == 0) {
                throw new DivideByZeroException("El divisor no puede ser cero.");
            }

            string dividendStr = dividend.ToString();
            int remainder = 0;

            foreach (char digitChar in dividendStr) {
                int digit = int.Parse(digitChar.ToString());
                int currentDividend = remainder * 10 + digit;
                int partialQuotient = currentDividend / divisor;
                remainder = currentDividend % divisor;

                Console.WriteLine(currentDividend + " " +partialQuotient + " " +remainder);
            }

            Console.WriteLine($"Resultado final: cociente = {dividend / divisor}, residuo = {dividend % divisor}");
        }
    }
}
