using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    public class ComputerGame : IGame
    {
        private IPlayer _computerPlayer;
        private IPlayer _humanPlayer;
        private string _word;
        private int _charactersLeft;

        public ComputerGame(HumanPlayer humanPlayer)
        {
            this._humanPlayer = humanPlayer;
            this._computerPlayer = new ComputerPlayer();
        }

        public void AddPlayer(IPlayer player)
        {
            this._humanPlayer = player;
        }

        public IPlayer PlayGame()
        {
            IWordPicker wordPicker = new FileWordPicker("palabras.txt");
            this._word = wordPicker.PickRandomWord().ToLower();
            this._charactersLeft = this._word.Distinct().Count(); // número de letras distintas a adivinar
            IPrinter printer = new Printer(this._word);
            IWordValidator wordValidator = new WordValidator();
            IWordMatcher wordMatcher = new WordMatcher(this._word);

            IPlayer currentPlayer = _humanPlayer;

            while (_humanPlayer.GetTries() > 0)
            {
                printer.Print();
                Console.WriteLine($"{(currentPlayer == _humanPlayer ? "Jugador" : "Computadora")}, ingrese una letra:");

                string input = currentPlayer.ChooseWord();

                if (!wordValidator.Validate(input))
                {
                    Console.WriteLine($"La letra '{input}' es inválida. Intente de nuevo.");
                    continue;
                }
                int matches = wordMatcher.MatchCount(input);
                if (matches == 0)
                {
                    int lives = currentPlayer.GetTries() - 1;
                    currentPlayer.SetTries(lives);
                    if (lives > 0)
                    {
                        Console.WriteLine($"La letra '{input}' no está en la palabra. Te quedan {lives} {(lives == 1 ? "intento" : "intentos")}.");
                    }
                }
                else
                {
                    _charactersLeft -= matches;
                    printer.AddWord(input);
                    Console.WriteLine($"¡Correcto! La letra '{input}' aparece {matches} vez{(matches > 1 ? "es" : "")}.");
                }

                if (_charactersLeft == 0)
                {
                    Console.WriteLine("¡Has adivinado la palabra!");
                    return currentPlayer;
                }

                // Alternar jugador solo si hay más de uno
                currentPlayer = currentPlayer == _humanPlayer ? _computerPlayer : _humanPlayer;
            }

            Console.WriteLine($"¡Perdiste! La palabra era: {_word}");
            return _computerPlayer;
        }
    }
}
