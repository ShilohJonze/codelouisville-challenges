using System;
using System.Collections.Generic;

namespace PokerDealer
{
    public class Deck
    {
        private readonly List<Card> _cards = new List<Card>();

        public Deck()
        {
            foreach (var suit in Suits.GetAll())
            {
                foreach (var cardType in CardTypes.GetAll())
                {
                    _cards.Add(new Card(suit, cardType));
                }
            }

            // TODO: Bonus: Support multiple combined decks.  Maybe add an argument to pass this in?
        }

        public Card DrawCard()
        {
            if (_cards.Count == 0)
                return null;

            var drawn = _cards[0];
            _cards.RemoveAt(0);
            return drawn;
        }

        public void Display()
        {
            var i = 0;
            foreach (var card in _cards)
            {
                Console.Write(" ");
                card.Display();

                i += 1;
                if (i % 13 == 0)
                    Console.WriteLine();
            }

            if (i % 13 != 0)
                Console.WriteLine();
        }

        public void Shuffle()
        {
            // Fisher-Yates shuffle (thanks, Wikipedia!)
            var random = new Random();
            for (var i = _cards.Count - 1; i >= 1; i--)
            {
                var j = random.Next(i + 1);

                var temp = _cards[i];
                _cards[i] = _cards[j];
                _cards[j] = temp;
            }
        }
    }
}
