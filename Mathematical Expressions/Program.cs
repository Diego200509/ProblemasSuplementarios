namespace Mathematical_Expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {// Configuración de dependencias
            var validator = new BasicExpressionValidator();
            var evaluator = new SimpleMathEvaluator(validator);
            var calculator = new ExpressionCalculator(evaluator);

            Console.WriteLine("Calculadora de Expresiones Matemáticas");
            Console.WriteLine("Ingrese una expresión (ej: 12-10/3+20-(50-20)*3) o 'salir' para terminar");

            while (true)
            {
                Console.Write("> ");
                var input = Console.ReadLine();

                if (input?.ToLower() == "salir")
                    break;

                try
                {
                    var result = calculator.Calculate(input);
                    Console.WriteLine(calculator.LastResult);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}