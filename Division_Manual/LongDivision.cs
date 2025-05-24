using System.Text;
using Division_Manual;

public class LongDivision : IIntDivision
{
    public IPrinter Printer { get; set; }

    public LongDivision(IPrinter printer)
    {
        this.Printer = printer;
    }
    public void Divison(BigInt dividend, BigInt divisor)
    {
        if (divisor.ToString() == "0")
            throw new DivideByZeroException("El divisor no puede ser cero.");

        this.Printer.PrintHeader(dividend, divisor);

        string dividendStr = dividend.ToString();
        StringBuilder quotient = new();
        BigInt remainder = new("0");

        int stepOffset = 0;
        for (int i = 0; i < dividendStr.Length; i++)
        {
            remainder = new BigInt(remainder.ToString() + dividendStr[i]);

            if (remainder.CompareTo(divisor) < 0 && quotient.Length > 0)
            {
                quotient.Append("0");
                stepOffset++;
                continue;
            }

            int q = 0;
            BigInt subtrahend = new("0");
            while (remainder.CompareTo(divisor) >= 0)
            {
                remainder = remainder.Subtract(divisor);
                q++;
            }

            subtrahend = divisor.Multiply(q);
            quotient.Append(q);

            int subtractPos = i + 1;
            this.Printer.PrintStep(subtractPos, new BigInt(remainder.ToString() + dividendStr[i]), subtrahend, 0);
        }

        this.Printer.PrintRemainder(remainder, dividendStr.Length + 1);
        Console.WriteLine($"\nResultado final: cociente = {quotient}, residuo = {remainder}");
    }

}
