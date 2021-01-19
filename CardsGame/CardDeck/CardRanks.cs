using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsGame.CardDeck
{
    public class CardRanks : List<CardRank>
    {
        private static readonly CardRanks _defaultRanks = new CardRanks
        {
                                                                new CardRank('A', "Ace", 1),
                                                                new CardRank('2', "Two", 2),
                                                                new CardRank('3', "Three", 3),
                                                                new CardRank('4', "Four", 4),
                                                                new CardRank('5', "Five", 5),
                                                                new CardRank('6', "Six", 6),
                                                                new CardRank('7', "Seven", 7),
                                                                new CardRank('8', "Seven", 8),
                                                                new CardRank('9', "Seven", 9),
                                                                new CardRank('T', "Seven", 10),
                                                                new CardRank('J', "Seven", 11),
                                                                new CardRank('Q', "Seven", 12),
                                                                new CardRank('K', "Seven", 13)
        };

        public static CardRanks DefaultRanks()
        {
            return _defaultRanks;
        }
    }
}
