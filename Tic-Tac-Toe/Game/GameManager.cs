using System;

namespace Tic_Tac_Toe.Game
{
    public class GameManager
    {
        private readonly Board _board;
        private readonly IPlayer _playerX;
        private readonly IPlayer _playerO;
        private IPlayer _currentPlayer;
        private readonly GameTimer _gameTimer;

        public event Action<int> TimeUpdated;
        public event Action<IPlayer> PlayerChanged;
        public event Action<IPlayer> GameWon;
        public event Action GameTied;

        public GameManager(IPlayer playerX, IPlayer playerO)
        {
            _playerX = playerX ?? throw new ArgumentNullException(nameof(playerX));
            _playerO = playerO ?? throw new ArgumentNullException(nameof(playerO));
            _currentPlayer = _playerX;
            _board = new Board();
            _gameTimer = new GameTimer();
            _gameTimer.TimeUpdated += OnTimeUpdated;
        }

        public void StartNewGame()
        {
            _board.Clear();
            _currentPlayer = _playerX; // Siempre empieza X
            _gameTimer.Start();
            PlayerChanged?.Invoke(_currentPlayer);
        }

        public void EndGame()
        {
            _gameTimer.Stop();
        }

        private void OnTimeUpdated(int seconds)
        {
            TimeUpdated?.Invoke(seconds);
        }

        public void SwitchPlayer()
        {
            _currentPlayer = _currentPlayer == _playerX ? _playerO : _playerX;
            PlayerChanged?.Invoke(_currentPlayer);
        }

        public void MakeMove(int position)
        {
            if (_currentPlayer is IHumanPlayer humanPlayer)
            {
                humanPlayer.MakeMove(_board, position);
            }
            else if (_currentPlayer is IComputerPlayer computerPlayer)
            {
                computerPlayer.MakeAutomaticMove(_board);
            }

            CheckGameState();
        }

        private void CheckGameState()
        {
            if (_board.CheckWinner())
            {
                GameWon?.Invoke(_currentPlayer);
                EndGame();
            }
            else if (_board.IsFull())
            {
                GameTied?.Invoke();
                EndGame();
            }
            else
            {
                SwitchPlayer();
            }
        }

        public void MakeComputerMove()
        {
            if (_currentPlayer is IComputerPlayer computerPlayer)
            {
                computerPlayer.MakeAutomaticMove(_board);
                CheckGameState();
            }
        }

        public string GetSymbolAt(int index) => _board.GetSymbolAt(index);

        public bool IsCellEmpty(int position) => _board.IsCellEmpty(position);

        public bool IsGameOver() => _board.CheckWinner() || _board.IsFull();
    }

}