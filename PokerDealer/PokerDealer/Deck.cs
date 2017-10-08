using System;
using System.Collections.Generic;

namespace PokerDealer
{
    public class Deck
    {
        private readonly List<Card> _cards = new List<Card>();

        public Deck()
        {
            // TODO: Populate _cards with one of each card.

            // TODO: Bonus: Support multiple combined decks.  Maybe add an argument to pass this in?
        }

        public Card DrawCard()
        {
            // TODO: Remove a card from _cards and return it.  What if there aren't any cards left?
            throw new NotImplementedException("This is part of the challenge!");
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
