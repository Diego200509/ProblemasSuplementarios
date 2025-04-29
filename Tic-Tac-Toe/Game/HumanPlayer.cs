namespace Tic_Tac_Toe.Game
{
    public class HumanPlayer : IPlayer
    {
        public string Name { get; set; }
        public string Symbol { get; set; }

        public HumanPlayer(string name, string symbol)
        {
            Name = name;
            Symbol = symbol;
        }

        public void MakeMove(Board board)
        {
            // Lógica para hacer un movimiento como jugador humano
            // Ejemplo: el humano selecciona una casilla en el tablero
        }
    }
}