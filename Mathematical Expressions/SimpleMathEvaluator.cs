using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematical_Expressions
{

    public class SimpleMathEvaluator : IExpressionEvaluator
    {
        private readonly IExpressionValidator _validator;

        // Principio de Inversión de Dependencias (DIP) - Dependemos de abstracciones
        public SimpleMathEvaluator(IExpressionValidator validator)
        {
            _validator = validator ?? throw new ArgumentNullException(nameof(validator));
        }

        public double Evaluate(string expression)
        {
            if (!_validator.IsValid(expression))
                throw new ArgumentException("Expresión no válida");

            // Eliminar espacios en blanco
            expression = expression.Replace(" ", "");

            // Usar DataTable para evaluar la expresión (solución simple)
            // En una implementación real usaríamos un parser más robusto
            try
            {
                return Convert.ToDouble(new System.Data.DataTable().Compute(expression, null));
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al evaluar la expresión", ex);
            }
        }
    }
}
