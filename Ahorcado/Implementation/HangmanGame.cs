using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    public class HangmanGame : IGame
    {
        private readonly IWordProvider _wordProvider;
        private readonly IPlayer _player;
        private string _word;
        private char[] _currentState;
        private HashSet<char> _guessedLetters;
        private int _lives = 5;

        public HangmanGame(IWordProvider wordProvider, IPlayer player)
        {
            _wordProvider = wordProvider;
            _player = player;
        }

        public void Start()
        {
            _word = _wordProvider.GetWord();
            _currentState = new string('_', _word.Length).ToCharArray();
            _guessedLetters = new HashSet<char>();

            while (_lives > 0 && _currentState.Contains('_'))
            {
                Console.WriteLine($"\nPalabra: {new string(_currentState)}");
                Console.WriteLine($"Intentos restantes: {_lives}");

                string guess = _player.GetGuess();
                if (string.IsNullOrWhiteSpace(guess) || guess.Length != 1 || !char.IsLetter(guess[0]))
                {
                    Console.WriteLine("Entrada inválida.");
                    continue;
                }

                char letter = guess[0];
                if (_guessedLetters.Contains(letter))
                {
                    Console.WriteLine("Ya ingresaste esa letra.");
                    continue;
                }

                _guessedLetters.Add(letter);
                if (_word.Contains(letter))
                {
                    for (int i = 0; i < _word.Length; i++)
                    {
                        if (_word[i] == letter)
                            _currentState[i] = letter;
                    }
                }
                else
                {
                    _lives--;
                    Console.WriteLine($"La letra '{letter}' no está en la palabra.");
                }
            }

            Console.WriteLine(_lives > 0
                ? $"\n¡Ganaste! La palabra era: {_word}"
                : $"\nPerdiste. La palabra era: {_word}");
        }
    }
}