using System;

namespace Tic_Tac_Toe.Game
{
    public class ComputerPlayer : IComputerPlayer
    {
        public string Name { get; }
        public string Symbol { get; }
        private string OpponentSymbol => Symbol == "X" ? "O" : "X";

        public ComputerPlayer(string name, string symbol)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Symbol = symbol ?? throw new ArgumentNullException(nameof(symbol));
        }

        public void MakeAutomaticMove(Board board)
        {
            if (board == null) throw new ArgumentNullException(nameof(board));

            int bestScore = int.MinValue;
            int bestMove = -1;

            foreach (int move in board.GetAvailableMoves())
            {
                board.UpdateCell(move, Symbol);
                int score = Minimax(board, 0, false);
                board.UpdateCell(move, null); // Deshacer movimiento

                if (score > bestScore)
                {
                    bestScore = score;
                    bestMove = move;
                }
            }

            board.UpdateCell(bestMove, Symbol);
        }

        private int Minimax(Board board, int depth, bool isMaximizing)
        {
            string winner = board.GetWinner();
            if (winner == Symbol) return 10 - depth;
            if (winner == OpponentSymbol) return depth - 10;
            if (board.IsFull()) return 0;

            if (isMaximizing)
            {
                int bestScore = int.MinValue;
                foreach (int move in board.GetAvailableMoves())
                {
                    board.UpdateCell(move, Symbol);
                    int score = Minimax(board, depth + 1, false);
                    board.UpdateCell(move, null);
                    bestScore = Math.Max(score, bestScore);
                }
                return bestScore;
            }
            else
            {
                int bestScore = int.MaxValue;
                foreach (int move in board.GetAvailableMoves())
                {
                    board.UpdateCell(move, OpponentSymbol);
                    int score = Minimax(board, depth + 1, true);
                    board.UpdateCell(move, null);
                    bestScore = Math.Min(score, bestScore);
                }
                return bestScore;
            }
        }
    }
}