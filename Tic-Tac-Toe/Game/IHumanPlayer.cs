namespace Tic_Tac_Toe.Game
{
    public interface IHumanPlayer : IPlayer
    {
        void MakeMove(Board board, int position);
    }
}