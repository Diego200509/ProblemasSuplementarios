namespace Tic_Tac_Toe.Game
{
    public class ComputerPlayer : IPlayer
    {
        public string Name { get; set; }
        public string Symbol { get; set; }

        public ComputerPlayer(string name, string symbol)
        {
            Name = name;
            Symbol = symbol;
        }

        public void MakeMove(Board board)
        {
            // Lógica para que la computadora haga un movimiento (puede ser aleatorio o basado en reglas)
        }
    }
}