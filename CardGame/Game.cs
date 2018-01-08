using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
   public class Game
   {
        // cards game have always 52 cards
       private readonly string[] _cardsVale = new string[]
       {
           "Spades_A", "Spades_2", "Spades_3", "Spades_4", "Spades_5", "Spades_6", "Spades_7", "Spades_8", "Spades_9","Spades_K", "Spades_Q", "Spades_J",
           "Hearts_A", "Hearts_2", "Hearts_3", "Hearts_4", "Hearts_5", "Hearts_6", "Hearts_7", "Hearts_8", "Hearts_9","Hearts_K", "Hearts_Q", "Hearts_J",
           "Diamonds_A", "Diamonds_2", "Diamonds_3", "Diamonds_4", "Diamonds_5", "Diamonds_6", "Diamonds_7", "Diamonds_8", "Diamonds_9","Diamonds_K", "Diamonds_Q", "Diamonds_J",
           "Ace_A","Ace_2", "Ace_3", "Ace_4", "Ace_5", "Ace_6", "Ace_7", "Ace_8", "Ace_9", "Ace_K","Ace_Q", "Ace_J"
       };

       public Queue<string> Cards;
        public Game()
        {
            Cards = new Queue<string>(_cardsVale);
        }

        public string Play()
        {
           return Cards.Dequeue();
        }   

        public void Shuffle()
        {
            var tempArray = Cards.ToArray();
            new Random().Shuffle(tempArray);
            Cards = new Queue<string>(tempArray);
        }

        public void Restart()
        {
            Cards = new Queue<string>(_cardsVale);
        }
    }


    public enum GameOptions
    {
        Play = 1,
        Shuffle = 2,
        Restart = 3,
        Quit = 4
    }


}
