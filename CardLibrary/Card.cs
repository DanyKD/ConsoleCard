using System;

namespace CardLibrary
{
    public enum Suit
    {
        Clup,
        Diamond,
        Heart,
        Spade
    }

    public enum Rank
    {
        Ace = 1,
        Deuce,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    public class Card
    {
        public readonly Suit suit;
        public readonly Rank rank;
        public override string ToString()
        {
            //return base.ToString();
            return "The " + rank + " of " + suit + "s";
        }
        private Card()
        {
        }
        public Card(Suit newSuit, Rank newRank)
        {
            suit = newSuit;
            rank = newRank;
        }
    }
   
}
