using System;

namespace Tic_Tac_Toe.Game
{
    public class GameManager
    {
        private readonly Board _board;
        private IPlayer _currentPlayer;
        private readonly GameTimer _gameTimer;

        public event Action<int> TimeUpdated;

        public event Action<IPlayer> PlayerChanged;

        public event Action<IPlayer> GameWon;

        public event Action GameTied;

        public GameManager(IPlayer firstPlayer)
        {
            _board = new Board();
            _currentPlayer = firstPlayer ?? throw new ArgumentNullException(nameof(firstPlayer));
            _gameTimer = new GameTimer();

            _gameTimer.TimeUpdated += OnTimeUpdated;
        }

        public void StartNewGame()
        {
            _board.Clear();
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
            if (_currentPlayer is HumanPlayer)
            {
                _currentPlayer = new ComputerPlayer("Computer", "O");
            }
            else
            {
                _currentPlayer = new HumanPlayer("Player 1", "X");
            }

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

        public string GetSymbolAt(int index)
        {
            return _board.GetSymbolAt(index);
        }

        public bool IsCellEmpty(int position)
        {
            return _board.IsCellEmpty(position);
        }

        public bool IsGameOver()
        {
            return _board.CheckWinner() || _board.IsFull();
        }
    }
}