using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsGame.CardDeck
{
    public class CardSuit: IComparable<CardSuit>
    {
        public char Code { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }

        public CardSuit(char code,string name, int order)
        {
            Code = code;
            Name = name;
            Order = order;
        }

        public int CompareTo(CardSuit other)
        {
            if (Order > other.Order) return 1;
            if (Order == other.Order) return 0;
            return -1;
        }
    }
}
