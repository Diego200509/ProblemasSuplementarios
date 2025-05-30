using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaFracciones
{
    public class Fraction : IComparable<Fraction>
    {
        private int _numerator;
        private int _denominator;

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Denominator cannot be zero");

            int gcd = Utils.GCD(Math.Abs(numerator), Math.Abs(denominator));
            _numerator = numerator / gcd;
            _denominator = denominator / gcd;

            if (_denominator < 0)
            {
                _numerator *= -1;
                _denominator *= -1;
            }
        }
        public double ToDouble()
        {
            return (double)(this._numerator / this._denominator);
        }

        public int CompareTo(Fraction? other)
        {
            if (other == null) return 1;
            return other.ToDouble().CompareTo(this.ToDouble());
        }

        public Fraction Add(Fraction other)
        {
            int commonDen = _denominator * other._denominator;
            int newNum = _numerator * other._denominator + other._numerator * _denominator;
            return new Fraction(newNum, commonDen);
        }

        public override string ToString()
        {
            return $"{this._numerator}/{this._denominator}";
        }
    }
}