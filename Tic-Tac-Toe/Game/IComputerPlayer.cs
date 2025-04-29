namespace Tic_Tac_Toe.Game
{
    public interface IComputerPlayer : IPlayer
    {
        void MakeAutomaticMove(Board board);
    }
}