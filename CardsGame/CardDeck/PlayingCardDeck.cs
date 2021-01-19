using System.Collections.ObjectModel;

namespace CardsGame.CardDeck
{
    public class PlayingCardDeck : CardDeckB<PlayingCard>
    {
        private CardRanks _cardRanks;
        private CardSuits _cardSuits;

        public PlayingCardDeck()
        {
            Initialize(CardSuits.DefaultCards(), CardRanks.DefaultRanks());
        }

        public ReadOnlyCollection<CardSuit> Suits
        {
            get { return new ReadOnlyCollection<CardSuit>(_cardSuits); }
        }

        public ReadOnlyCollection<CardRank> Ranks
        {
            get { return new ReadOnlyCollection<CardRank>(_cardRanks); }
        }

        private void Initialize(CardSuits suits, CardRanks ranks)
        {
            _cardSuits = suits;
            _cardRanks = ranks;

            foreach (var cardSuit in suits)
            {
                foreach (var cardRank in ranks)
                {
                    Add(new PlayingCard(cardSuit, cardRank));
                }
            }
        }


    }
}
