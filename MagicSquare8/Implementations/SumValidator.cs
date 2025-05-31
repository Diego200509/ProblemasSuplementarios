using MagicSquare8.Interfaces;

namespace MagicSquare8.Implementations
{
    public class SumValidator : IMagicSquareValidator
    {
        public bool IsMagic(int?[,] sq)
        {
            int n = sq.GetLength(0);
            int target = 0;
            // suma primera fila
            for (int j = 0; j < n; j++) target += sq[0, j].Value;

            // filas y columnas
            for (int i = 0; i < n; i++)
            {
                if (Enumerable.Range(0, n).Sum(j => sq[i, j].Value) != target) return false;
                if (Enumerable.Range(0, n).Sum(j => sq[j, i].Value) != target) return false;
            }

            // diagonales
            if (Enumerable.Range(0, n).Sum(i => sq[i, i].Value) != target) return false;
            if (Enumerable.Range(0, n).Sum(i => sq[i, n - 1 - i].Value) != target) return false;

            return true;
        }
    }
}