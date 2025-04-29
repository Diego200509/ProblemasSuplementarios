using System;

namespace Tic_Tac_Toe.Game
{
    public class GameManager
    {
        private Board _board;
        private IPlayer _currentPlayer;
        private GameTimer _gameTimer;  // Instancia de GameTimer

        public GameManager(IPlayer initialPlayer)
        {
            _board = new Board();
            _currentPlayer = initialPlayer;
            _gameTimer = new GameTimer();

            // Suscribir el evento para actualizar el tiempo
            _gameTimer.TimeUpdated += OnTimeUpdated;
        }

        public void StartGame()
        {
            _gameTimer.Start();  // Iniciar el temporizador
        }

        public void EndGame()
        {
            _gameTimer.Stop();  // Detener el temporizador
        }

        // Evento para manejar la actualización del tiempo
        private void OnTimeUpdated(int secondsElapsed)
        {
            // Aquí puedes actualizar la UI con el tiempo transcurrido
            Console.WriteLine($"Tiempo transcurrido: {secondsElapsed}s");
        }

        public void SwitchPlayer()
        {
            if (_currentPlayer is HumanPlayer)
                _currentPlayer = new ComputerPlayer("Computer", "O");
            else
                _currentPlayer = new HumanPlayer("Player 1", "X");
        }

        public void MakeMove(string position)
        {
            _board.UpdateBoard(position, _currentPlayer.Symbol);
        }
    }
}