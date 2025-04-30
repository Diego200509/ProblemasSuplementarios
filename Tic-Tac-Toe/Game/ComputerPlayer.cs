using System;

namespace Tic_Tac_Toe.Game
{
    public class ComputerPlayer : IComputerPlayer
    {
        private readonly Random _random = new Random();

        public string Name { get; }
        public string Symbol { get; }

        private readonly string OpponentSymbol;

        public ComputerPlayer(string name, string symbol, string opponent)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Symbol = symbol ?? throw new ArgumentNullException(nameof(symbol));
            OpponentSymbol = symbol ?? throw new ArgumentNullException(nameof(opponent));
        }

        public void MakeAutomaticMove(Board board) {
            if (board == null) throw new ArgumentNullException(nameof(board));

            int bestScore = int.MinValue;
            int bestMove = -1;

            for (int i = 0; i < 9; i++) {
                if (!board.IsCellEmpty(i)) continue;

                board.UpdateCell(i, Symbol);
                int score = Minimax(board, false);
                board.UndoMove(i);

                if (score > bestScore) {
                    bestScore = score;
                    bestMove = i;
                }
            }

            board.UpdateCell(bestMove, Symbol);
        }


        private int Minimax(Board board, bool isMaximizing) {
            var winner = board.CheckWinner();
            if (winner == Symbol) return +20;
            if (winner == OpponentSymbol) return -20;
            if (board.IsFull()) return 0;

            if (isMaximizing) {
                int bestScore = int.MinValue;
                for (int i = 0; i < 9; i++) {
                    if (board.IsCellEmpty(i)) {
                        board.UpdateCell(i, Symbol);
                        int score = Minimax(board, false);
                        board.UndoMove(i);
                        bestScore = Math.Max(score, bestScore);
                    }
                }
                return bestScore;
            } else {
                int bestScore = int.MaxValue;
                for (int i = 0; i < 9; i++) {
                    if (board.IsCellEmpty(i)) {
                        board.UpdateCell(i, OpponentSymbol);
                        int score = Minimax(board, true);
                        board.UndoMove(i);
                        bestScore = Math.Min(score, bestScore);
                    }
                }
                return bestScore;
            }
        }
    }
}