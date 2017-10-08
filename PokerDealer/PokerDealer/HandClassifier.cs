using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerDealer
{
    public class HandClassifier
    {
        private readonly List<Card> _hand;
        private readonly Dictionary<CardType, int> _cardTypeCounts;

        public HandClassifier(List<Card> hand)
        {
            _hand = hand;
            _cardTypeCounts = GetCardTypeCounts(hand);
        }

        public string GetClassification()
        {
            return ClassifyStraightFlush()
                   ?? ClassifyOfAKind(4, "four of a kind")
                   ?? ClassifyFullHouse()
                   ?? ClassifyFlush()
                   ?? ClassifyStraight()
                   ?? ClassifyOfAKind(3, "three of a kind")
                   ?? ClassifyTwoPair()
                   ?? ClassifyOfAKind(2, "one pair")
                   ?? ClassifyHighCard();
        }

        private string ClassifyStraightFlush()
        {
            var high = _hand.Max(card => card.CardType);

            var current = high.GetLower();
            for (var i = 0; i < _hand.Count - 1; i++)
            {
                if (!_cardTypeCounts.ContainsKey(current) || _cardTypeCounts[current] != 1)
                    return null;
                if (current == CardType.Two)
                    return null;
                current = current.GetLower();
            }

            var suit = _hand[0].Suit;
            for (var i = 1; i < _hand.Count; i++)
            {
                if (_hand[i].Suit != suit)
                    return null;
            }

            return String.Format("{0}-high straight flush", high.ToPrintable(false));
        }

        private string ClassifyFullHouse()
        {
            CardType? threeCountCardType = null;
            CardType? twoCountCardType = null;
            foreach (var count in _cardTypeCounts)
            {
                if (count.Value == 3)
                    threeCountCardType = count.Key;
                if (count.Value == 2)
                    twoCountCardType = count.Key;
            }

            if (threeCountCardType == null || twoCountCardType == null)
                return null;

            return String.Format(
                "full house, {0} over {1}",
                threeCountCardType.Value.ToPrintable(true),
                twoCountCardType.Value.ToPrintable(true));
        }

        private string ClassifyFlush()
        {
            var suit = _hand[0].Suit;
            for (var i = 1; i < _hand.Count; i++)
            {
                if (_hand[i].Suit != suit)
                    return null;
            }

            var high = _hand.Max(card => card.CardType);
            return String.Format("{0}-high flush", high.ToPrintable(false));
        }

        private string ClassifyStraight()
        {
            var high = _hand.Max(card => card.CardType);

            var current = high.GetLower();
            for (var i = 0; i < _hand.Count - 1; i++)
            {
                if (!_cardTypeCounts.ContainsKey(current) || _cardTypeCounts[current] != 1)
                    return null;
                if (current == CardType.Two)
                    return null;
                current = current.GetLower();
            }

            return String.Format("{0}-high straight", high.ToPrintable(false));
        }

        private string ClassifyTwoPair()
        {
            CardType? pair1CardType = null;
            CardType? pair2CardType = null;

            foreach (var count in _cardTypeCounts)
            {
                if (count.Value != 2)
                    continue;

                if (pair1CardType == null)
                    pair1CardType = count.Key;
                else
                    pair2CardType = count.Key;
            }

            if (pair1CardType == null || pair2CardType == null)
                return null;

            return String.Format(
                "two pair, {0} and {1}",
                pair1CardType.Value.ToPrintable(true),
                pair2CardType.Value.ToPrintable(true));
        }

        private string ClassifyOfAKind(int n, string description)
        {
            foreach (var count in _cardTypeCounts)
            {
                if (count.Value == n)
                    return String.Format("{0}, {1}", description, count.Key.ToPrintable(true));
            }

            return null;
        }

        private string ClassifyHighCard()
        {
            var max = _hand.Max(card => card.CardType);
            return "high card, " + max.ToPrintable(false);
        }

        private static Dictionary<CardType, int> GetCardTypeCounts(List<Card> hand)
        {
            var cardTypeCounts = new Dictionary<CardType, int>();
            foreach (var card in hand)
            {
                if (!cardTypeCounts.ContainsKey(card.CardType))
                    cardTypeCounts[card.CardType] = 1;
                else
                    cardTypeCounts[card.CardType] += 1;
            }
            return cardTypeCounts;
        }
    }
}
