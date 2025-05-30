namespace SumaFracciones;

public class Program
{
    static void Main(string[] args)
    {

        System.Console.WriteLine("Ingrese el número de fracciones que quiere ingresar");
        int n = Convert.ToInt32(System.Console.ReadLine());
        IConverter<string, Fraction> converter = new StringFractionConverter();
        IValidator validator = new FractionValidator();
        Fraction[] fractions = new Fraction[n];
        Fraction result = converter.Convert("0");
        string? input;
        for (int i = 0; i < n; i++)
        {
            System.Console.WriteLine("Ingrese una fracción");
            input = System.Console.ReadLine();
            while (!validator.IsValid(input))
            {
                System.Console.WriteLine($"{input} no es una fracción válida. Ingrese una fracción válida");
                input = System.Console.ReadLine();
            }
            fractions[i] = converter.Convert(input);
            result = result.Add(fractions[i]);
        }
        System.Console.WriteLine("-------Total------------");
        System.Console.WriteLine(result);
    }
}