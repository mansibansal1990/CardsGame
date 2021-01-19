using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsGame.CardDeck
{
    public class PlayingCard : ICard
    {
        public CardSuit Suit { get; set; }
        public CardRank Rank { get; set; }

        public PlayingCard(CardSuit cardSuit, CardRank cardRank)
        {
            Suit = cardSuit;
            Rank = cardRank;
        }

        public string Description
        {
            get
            {
                return string.Concat(Rank.Name, " of ", Suit.Name);
            }
        }

        public int StackOrder { get; set; }

        public string Code
        {
            get
            {
                return string.Concat(Rank.Code, Suit.Code);
            }
        }

        public override string ToString()
        {
            var result = string.Concat(Code, " - ", Rank.Name, " - ", Description);
            return result;
        }
    }
}
