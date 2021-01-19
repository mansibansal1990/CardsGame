using CardsGame.CardDeck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayingCardDeck deck = NewDeck();
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = SelectOption(deck);
            }
            
        }

        /// <summary>
        /// Player has 3 options as displayed
        /// </summary>
        /// <param name="deck">Card deck to be played</param>
        /// <returns>bool value if menu needs to be displayed again or not</returns>
        private static bool SelectOption(PlayingCardDeck deck)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Play a Card");
            Console.WriteLine("2) Shuffle");
            Console.WriteLine("3) Restart");
            Console.WriteLine("4) Exit");
            Console.Write("\r\nSelect an option: ");
            
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine(deck[0].Description);
                    deck.RemoveAt(0);
                    Console.ReadLine();
                    return true;
                case "2":
                    deck.Shuffle();
                    return true;
                case "3":
                    deck = NewDeck();
                    return false;
                case "4":
                    return false;
                default:
                    return true;
            }            
        }

        /// <summary>
        /// Create the new deck to be played by the player
        /// </summary>
        /// <returns></returns>
        private static PlayingCardDeck NewDeck()
        {
            var deck = new PlayingCardDeck();
            deck.Shuffle();
            return deck;
        }
    }
}
