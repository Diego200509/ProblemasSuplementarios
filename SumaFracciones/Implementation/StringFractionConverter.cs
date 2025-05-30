using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaFracciones
{
    public class StringFractionConverter : IConverter<string, Fraction>
    {
        public Fraction Convert(string from)
        {
            from = from.Contains('/') ? from : from+"/1";
            string[] parts = from!.Split('/');
            int num = int.Parse(parts[0]);
            int den = int.Parse(parts[1]);
            return new Fraction(num, den);
        }
    }
}