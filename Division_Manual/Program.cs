using System.Numerics;
using Division_Manual;

namespace Division {
    internal class Program {
        static void Main(string[] args) {
            int dividend = 448;
            int divisor = 4;
            IIntDivision div = new LongDivision();
            div.Divison(dividend, divisor);
        }
    }
}
