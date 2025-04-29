using System;

namespace Tic_Tac_Toe.Game
{
    public class ComputerPlayer : IComputerPlayer
    {
        private readonly Random _random = new Random();

        public string Name { get; }
        public string Symbol { get; }

        public ComputerPlayer(string name, string symbol)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Symbol = symbol ?? throw new ArgumentNullException(nameof(symbol));
        }

        public void MakeAutomaticMove(Board board)
        {
            if (board == null) throw new ArgumentNullException(nameof(board));

            int position;
            do
            {
                position = _random.Next(0, 9);
            } while (!board.IsCellEmpty(position));

            board.UpdateCell(position, Symbol);
        }
    }
}