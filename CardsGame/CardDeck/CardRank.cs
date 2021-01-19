using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsGame.CardDeck
{
    public class CardRank
    {
        public char Code { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }

        public CardRank(char code, string name, int order)
        {
            Code = code;
            Name = name;
            Order = order;
        }
    }
}
