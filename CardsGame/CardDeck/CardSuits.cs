using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsGame.CardDeck
{
    public class CardSuits : List<CardSuit>
    {
        private static readonly CardSuits _defaultCards = new CardSuits
        {
            new CardSuit('C',"Clubs", 1),
            new CardSuit('D',"Diamonds", 2),
            new CardSuit('H',"Hearts", 3),
            new CardSuit('S',"Spades", 4)
        };

        public static CardSuits DefaultCards()
        {
            return _defaultCards;
        }
                                                
    }
}
