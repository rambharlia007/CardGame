using System;
using System.Linq;

namespace CardGame
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Options available");
            Console.WriteLine("enter 1 to play game");
            Console.WriteLine("enter 2 to shufflr card");
            Console.WriteLine("enter 3 to play again");

            var game = new Game();
            game.Shuffle();
            var isQuiteGame = false;
            do
            {
                var inputString = Console.ReadLine();
                var isInputValid = ValidateInput(inputString);
                
                if (isInputValid)
                {
                    var numericInput = Int32.Parse(inputString);
                    isQuiteGame = numericInput == (int) GameOptions.Quit;
                    bool isGameOver = IsGameOver(numericInput, game);

                    if (isGameOver)
                    {
                        Console.WriteLine("Game over, do you want to restart");
                    }
                    else
                        StartGame(numericInput, game);
                }
                else
                {
                    Console.WriteLine("Input is not valid");
                }
            } while (!isQuiteGame);
        }

        private static bool IsGameOver(int numericInput, Game game)
        {
            return game.Cards.Count == 0 &&
                   (numericInput == (int) GameOptions.Play || numericInput == (int) GameOptions.Shuffle);
        }

        private static void StartGame(int numericInput, Game game)
        {
            switch (numericInput)
            {
                case (int)GameOptions.Play:
                {
                    Console.WriteLine(game.Play());
                    break;
                }
                case (int) GameOptions.Shuffle:
                {
                    game.Shuffle();
                    Console.WriteLine("Shuffle Done");
                    break;
                }
                case (int) GameOptions.Restart:
                {
                    game.Restart();
                    Console.WriteLine("Game restarted");
                    break;
                }
            }
        }


        private static bool ValidateInput(string inputString)
        {
            var validInput = new[] {"1", "2", "3", "4"};
            return validInput.Contains(inputString);
        }
    }
}
