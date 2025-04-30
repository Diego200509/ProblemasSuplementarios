using System;
using System.Collections.Generic;

namespace Tic_Tac_Toe.Game
{
    public class Board
    {
        private readonly string[] _cells = new string[9];

        public void UpdateCell(int index, string symbol)
        {
            if (index < 0 || index >= _cells.Length)
                throw new ArgumentOutOfRangeException(nameof(index));

            _cells[index] = symbol; // Puede ser null para "borrar"
        }

        public bool CheckWinner()
        {
            // Combinaciones ganadoras (filas, columnas, diagonales)
            int[,] winningCombinations = new int[8, 3]
            {
                {0, 1, 2}, {3, 4, 5}, {6, 7, 8}, // filas
                {0, 3, 6}, {1, 4, 7}, {2, 5, 8}, // columnas
                {0, 4, 8}, {2, 4, 6}             // diagonales
            };

            for (int i = 0; i < 8; i++)
            {
                int a = winningCombinations[i, 0];
                int b = winningCombinations[i, 1];
                int c = winningCombinations[i, 2];

                if (!string.IsNullOrEmpty(_cells[a]) &&
                    _cells[a] == _cells[b] &&
                    _cells[b] == _cells[c])
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsFull()
        {
            foreach (var cell in _cells)
            {
                if (string.IsNullOrEmpty(cell))
                    return false;
            }
            return true;
        }

        public void Clear()
        {
            for (int i = 0; i < _cells.Length; i++)
            {
                _cells[i] = null;
            }
        }

        public string GetSymbolAt(int index)
        {
            if (index < 0 || index >= _cells.Length)
                throw new ArgumentOutOfRangeException(nameof(index));

            return _cells[index];
        }
        public bool IsCellEmpty(int index)
        {
            if (index < 0 || index >= _cells.Length)
                throw new ArgumentOutOfRangeException(nameof(index));

            return string.IsNullOrEmpty(_cells[index]);
        }

        public List<int> GetAvailableMoves()
        {
            List<int> availableMoves = new List<int>();
            for (int i = 0; i < _cells.Length; i++)
            {
                if (string.IsNullOrEmpty(_cells[i]))
                    availableMoves.Add(i);
            }
            return availableMoves;
        }

        public string GetWinner()
        {
            int[,] winningCombinations = new int[8, 3]
            {
        {0, 1, 2}, {3, 4, 5}, {6, 7, 8}, // filas
        {0, 3, 6}, {1, 4, 7}, {2, 5, 8}, // columnas
        {0, 4, 8}, {2, 4, 6}             // diagonales
            };

            for (int i = 0; i < 8; i++)
            {
                int a = winningCombinations[i, 0];
                int b = winningCombinations[i, 1];
                int c = winningCombinations[i, 2];

                if (!string.IsNullOrEmpty(_cells[a]) &&
                    _cells[a] == _cells[b] &&
                    _cells[b] == _cells[c])
                {
                    return _cells[a];
                }
            }

            return null;
        }




    }
}