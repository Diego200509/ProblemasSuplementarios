using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematical_Expressions
{
    public interface IExpressionValidator
    {
        bool IsValid(string expression);
    }
}
