using MagicSquare8.Interfaces;

namespace MagicSquare8.Implementations
{
    public class BacktrackingMagicSquareBuilder : IMagicSquareBuilder
    {
        private readonly IMagicSquareValidator _validator;
        private int _n = 4;
        private int _targetSum;
        private int?[,] _square;
        private bool _found;

        public BacktrackingMagicSquareBuilder(IMagicSquareValidator validator)
        {
            _validator = validator;
        }

        public int?[,] Build(IList<int> elements)
        {
            _square = new int?[_n, _n];
            _targetSum = elements.Sum() / _n;
            _found = false;

            Backtrack(elements.ToList(), 0);
            return _found ? _square : null;
        }

        private void Backtrack(List<int> remaining, int idx)
        {
            if (_found) return;

            if (idx == _n * _n)
            {
                if (_validator.IsMagic(_square))
                    _found = true;
                return;
            }

            int row = idx / _n, col = idx % _n;
            for (int i = 0; i < remaining.Count; i++)
            {
                int val = remaining[i];
                _square[row, col] = val;

                // poda temprana: filas completas
                if (col == _n - 1 && Enumerable.Range(0, _n).Sum(c => _square[row, c].Value) != _targetSum)
                {
                    _square[row, col] = null;
                    continue;
                }
                // poda temprana: columnas completas
                if (row == _n - 1 && Enumerable.Range(0, _n).Sum(r => _square[r, col].Value) != _targetSum)
                {
                    _square[row, col] = null;
                    continue;
                }

                var nextRem = new List<int>(remaining);
                nextRem.RemoveAt(i);
                Backtrack(nextRem, idx + 1);

                if (_found) return;
                _square[row, col] = null;
            }
        }
    }
}