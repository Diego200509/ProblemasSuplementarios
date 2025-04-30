using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Division_Manual
{
    public class LongDivision : IIntDivision
    {

        public IPrinter Printer { get; set; }

        public LongDivision(IPrinter printer)
        {
            this.Printer = printer;
        }
        /// <summary>
        /// SRP: Class has only one responsability
        /// OCP: Class is open for extension but closed for modification
        /// LSP: Class implements all methods from parent class
        /// DIP: Class is dependant on an abstraction
        /// </summary>
        /// <param name="dividend"></param>
        /// <param name="divisor"></param>
        /// <exception cref="DivideByZeroException"></exception>
        public void Divison(BigInteger dividend, BigInteger divisor)
        {
            if (divisor == 0)
                throw new DivideByZeroException("El divisor no puede ser cero.");

            string dividendStr = dividend.ToString();
            this.Printer.PrintHeader(dividend, divisor);
            StringBuilder quotient = new StringBuilder();
            BigInteger remainder = 0;
            for (int i = 0; i < dividendStr.Length; i++)
            {
                int digit = int.Parse(dividendStr[i].ToString());
                BigInteger current = remainder * 10 + digit;

                if (current < divisor && quotient.Length > 0)
                {
                    quotient.Append("0");
                    continue;
                }

                if (current >= divisor)
                {
                    BigInteger q = current / divisor;
                    BigInteger subtract = q * divisor;
                    quotient.Append(q);
                    int position = i + 3;
                    this.Printer.PrintStep(position - subtract.ToString().Length, current, subtract, 0);
                    remainder = current % divisor;
                }
                else
                {
                    remainder = current;
                }
            }

            this.Printer.PrintRemainder(remainder, dividendStr.Length + 2);

            Console.WriteLine($"\nResultado final: cociente = {dividend / divisor}, residuo = {dividend % divisor}");
        }
    }
}
