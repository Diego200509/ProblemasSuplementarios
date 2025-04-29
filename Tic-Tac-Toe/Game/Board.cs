namespace Tic_Tac_Toe.Game
{
    public class Board
    {
        private string[] _board = new string[9]; 

        public void UpdateBoard(string buttonName, string symbol)
        {
            int index = int.Parse(buttonName.Substring(buttonName.Length - 1)) - 1;
            _board[index] = symbol;
        }

        public bool CheckWinner()
        {
          
            return false;
        }
    }
}