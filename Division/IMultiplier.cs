using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumberMultiplier
{
    public interface IMultiplier
    {
        int Multiply(params int[] numbers);
    }
}
