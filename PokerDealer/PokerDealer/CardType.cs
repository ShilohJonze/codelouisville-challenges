using System;
using System.Collections.Generic;

namespace PokerDealer
{
    public enum CardType
    {
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
        Ace = 14
    }

    public static class CardTypes
    {
        public static List<CardType> GetAll()
        {
            return new List<CardType>
            {
                CardType.Two,
                CardType.Three,
                CardType.Four,
                CardType.Five,
                CardType.Six,
                CardType.Seven,
                CardType.Eight,
                CardType.Nine,
                CardType.Ten,
                CardType.Jack,
                CardType.Queen,
                CardType.King,
                CardType.Ace
            };
        }
    }

    public static class CardTypeExtensions
    {
        public static string ToPrintable(this CardType cardType, bool plural)
        {
            string name;
            switch (cardType)
            {
                case CardType.Two:
                    name = "two";
                    break;
                case CardType.Three:
                    name = "three";
                    break;
                case CardType.Four:
                    name = "four";
                    break;
                case CardType.Five:
                    name = "five";
                    break;
                case CardType.Six:
                    return plural ? "sixes" : "six";
                case CardType.Seven:
                    name = "seven";
                    break;
                case CardType.Eight:
                    name = "eight";
                    break;
                case CardType.Nine:
                    name = "nine";
                    break;
                case CardType.Ten:
                    name = "ten";
                    break;
                case CardType.Jack:
                    name = "jack";
                    break;
                case CardType.Queen:
                    name = "queen";
                    break;
                case CardType.King:
                    name = "king";
                    break;
                case CardType.Ace:
                    name = "ace";
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(cardType), cardType, null);
            }

            if (plural)
                return name + "s";
            return name;
        }

        public static CardType GetLower(this CardType cardType)
        {
            switch (cardType)
            {
                case CardType.Two:
                    throw new InvalidOperationException("Two is the lowest card.");
                case CardType.Three:
                    return CardType.Two;
                case CardType.Four:
                    return CardType.Three;
                case CardType.Five:
                    return CardType.Four;
                case CardType.Six:
                    return CardType.Five;
                case CardType.Seven:
                    return CardType.Six;
                case CardType.Eight:
                    return CardType.Seven;
                case CardType.Nine:
                    return CardType.Eight;
                case CardType.Ten:
                    return CardType.Nine;
                case CardType.Jack:
                    return CardType.Ten;
                case CardType.Queen:
                    return CardType.Jack;
                case CardType.King:
                    return CardType.Queen;
                case CardType.Ace:
                    return CardType.King;
                default:
                    throw new ArgumentOutOfRangeException(nameof(cardType), cardType, null);
            }
        }
    }
}
