namespace Tic_Tac_Toe.Game
{
    public class GameManager
    {
        private Board _board;
        public IPlayer CurrentPlayer { get; set; }

        public GameManager()
        {
            _board = new Board();
            // Aquí puedes agregar cualquier tipo de jugador sin modificar la clase GameManager
            CurrentPlayer = new HumanPlayer("Player 1", "X");
        }

        public void SwitchPlayer()
        {
            if (CurrentPlayer is HumanPlayer)
                CurrentPlayer = new ComputerPlayer("Computer", "O");  // Cambiar a un jugador de computadora
            else
                CurrentPlayer = new HumanPlayer("Player 1", "X");  // Cambiar a un jugador humano
        }

        public void MakeMove(string position)
        {
            _board.UpdateBoard(position, CurrentPlayer.Symbol);
        }
    }
}