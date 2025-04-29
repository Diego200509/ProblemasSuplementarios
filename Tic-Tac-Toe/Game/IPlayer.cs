namespace Tic_Tac_Toe.Game
{
    public interface IPlayer
    {
        string Name { get; set; }
        string Symbol { get; set; }

        void MakeMove(Board board);
    }
}