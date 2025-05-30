using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenaFracciones
{
    public interface IConverter<From, To>
    {
        public To Convert(From from);
    }
}