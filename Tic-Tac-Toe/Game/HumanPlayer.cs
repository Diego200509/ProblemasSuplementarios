using System;

namespace Tic_Tac_Toe.Game
{
    public class HumanPlayer : IHumanPlayer
    {
        public string Name { get; }
        public string Symbol { get; }

        public HumanPlayer(string name, string symbol)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Symbol = symbol ?? throw new ArgumentNullException(nameof(symbol));
        }

        public void MakeMove(Board board, int position)
        {
            if (board == null) throw new ArgumentNullException(nameof(board));
            if (position < 0 || position >= 9) throw new ArgumentOutOfRangeException(nameof(position));

            board.UpdateCell(position, Symbol);
        }
    }
}