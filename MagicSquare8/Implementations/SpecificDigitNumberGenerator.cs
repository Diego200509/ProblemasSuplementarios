using MagicSquare8.Interfaces;

namespace MagicSquare8.Implementations
{
    public class SpecificDigitNumberGenerator : INumberGenerator
    {
        private readonly int[] _allowedDigits;
        private readonly int _length;

        // Inyección de configuración
        public SpecificDigitNumberGenerator(int[] allowedDigits, int length)
        {
            _allowedDigits = allowedDigits;
            _length = length;
        }

        public IEnumerable<int> Generate()
        {
            return GenerateRecursive(0, 0);
        }

        private IEnumerable<int> GenerateRecursive(int pos, int current)
        {
            if (pos == _length)
            {
                yield return current;
            }
            else
            {
                foreach (var d in _allowedDigits)
                {
                    int next = current * 10 + d;
                    foreach (var tail in GenerateRecursive(pos + 1, next))
                        yield return tail;
                }
            }
        }
    }
}