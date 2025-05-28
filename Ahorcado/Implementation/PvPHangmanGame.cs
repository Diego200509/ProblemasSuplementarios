using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    public class TurnBasedHangmanGame : IGame
    {
        private readonly IWordProvider _wordProvider;
        private readonly IPlayer[] _players;
        private int _currentPlayerIndex = 0;
        private string _word;
        private char[] _display;
        private HashSet<char> _guessedLetters = new();
        private int _maxAttempts = 10;

        public TurnBasedHangmanGame(IWordProvider provider, IPlayer player1, IPlayer player2)
        {
            _wordProvider = provider;
            _players = new[] { player1, player2 };
        }

        public void Start()
        {
            _word = _wordProvider.GetWord();
            _display = Enumerable.Repeat('_', _word.Length).ToArray();
            int remainingAttempts = _maxAttempts;

            Console.WriteLine($"¡Empieza el juego! Palabra de {_word.Length} letras.");

            while (remainingAttempts > 0 && _display.Contains('_'))
            {
                Console.WriteLine($"\nPalabra: {string.Join(" ", _display)}");
                Console.WriteLine($"Intentos restantes: {remainingAttempts}");

                IPlayer current = _players[_currentPlayerIndex];
                string guess = current.GetGuess();

                if (string.IsNullOrWhiteSpace(guess) || guess.Length != 1 || !char.IsLetter(guess[0]))
                {
                    Console.WriteLine("Letra inválida.");
                    continue;
                }

                char letter = guess[0];
                if (_guessedLetters.Contains(letter))
                {
                    Console.WriteLine("Letra ya usada.");
                    continue;
                }

                _guessedLetters.Add(letter);

                if (_word.Contains(letter))
                {
                    for (int i = 0; i < _word.Length; i++)
                        if (_word[i] == letter)
                            _display[i] = letter;

                    current.NotifyResult(guess, true);
                }
                else
                {
                    remainingAttempts--;
                    current.NotifyResult(guess, false);
                }

                // Cambio de turno
                _currentPlayerIndex = (_currentPlayerIndex + 1) % _players.Length;
            }

            Console.WriteLine($"\nPalabra final: {_word}");
            if (!_display.Contains('_'))
                Console.WriteLine($"¡{_players[(_currentPlayerIndex + 1) % 2].Name} gana!");
            else
                Console.WriteLine("¡Se acabaron los intentos! Nadie gana.");
        }
    }
}