using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    public abstract class CardDeckB<T> : List<T> where T : ICard 
    {
        public Guid DeckId { get; set; }
        public CardDeckB()
        {
            DeckId = Guid.NewGuid();
        }
        
        public void Shuffle()
        {
            var rndm = new Random();
            for(var i= Count -1; i > 0; i--)
            {
                var nxt = rndm.Next(i + 1);
                var temp = this[i];
                this[i] = this[nxt];
                this[nxt] = temp;
            }
        }
    }
}
