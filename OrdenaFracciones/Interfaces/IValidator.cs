using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenaFracciones
{
    public interface IValidator
    {
        bool IsValid(string? expression);
    }
}
