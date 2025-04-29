using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematical_Expressions
{
    public class ExpressionCalculator : IExpressionCalculator
    {
        private readonly IExpressionEvaluator _evaluator;
        public string LastResult { get; private set; }

        public ExpressionCalculator(IExpressionEvaluator evaluator)
        {
            _evaluator = evaluator ?? throw new ArgumentNullException(nameof(evaluator));
        }

        public double Calculate(string expression)
        {
            var result = _evaluator.Evaluate(expression);
            LastResult = $"{expression} = {result}";
            return result;
        }
    }
}
