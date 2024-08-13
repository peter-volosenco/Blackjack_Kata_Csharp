using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Kata.Source
{
    public class Suit
    {
        public string Name { get; private set; }
        public string Color { get; private set; } // Optional: Add a color property if needed

        private Suit(string name, string color)
        {
            Name = name;
            Color = color;
        }

        // Predefined suits as static properties
        public static readonly Suit Hearts = new Suit("Hearts", "Red");
        public static readonly Suit Diamonds = new Suit("Diamonds", "Red");
        public static readonly Suit Clubs = new Suit("Clubs", "Black");
        public static readonly Suit Spades = new Suit("Spades", "Black");

        // Optional: Override ToString to display the suit's name
        public override string ToString()
        {
            return Name;
        }
    }


    public class Rank
    {
        public string Name { get; private set; }
        public int Value { get; private set; }

        private Rank(string name, int value)
        {
            Name = name;
            Value = value;
        }

        // Predefined ranks as static properties
        public static readonly Rank Two = new Rank("Two", 2);
        public static readonly Rank Three = new Rank("Three", 3);
        public static readonly Rank Four = new Rank("Four", 4);
        public static readonly Rank Five = new Rank("Five", 5);
        public static readonly Rank Six = new Rank("Six", 6);
        public static readonly Rank Seven = new Rank("Seven", 7);
        public static readonly Rank Eight = new Rank("Eight", 8);
        public static readonly Rank Nine = new Rank("Nine", 9);
        public static readonly Rank Ten = new Rank("Ten", 10);
        public static readonly Rank Jack = new Rank("Jack", 10);
        public static readonly Rank Queen = new Rank("Queen", 10);
        public static readonly Rank King = new Rank("King", 10);
        public static readonly Rank Ace = new Rank("Ace", 11);

        // Optional: Override ToString to display the rank's name
        public override string ToString()
        {
            return Name;
        }
    }

    public static class CardDefinitions
    {
        public static readonly List<Suit> Suits = new List<Suit>
    {
        Suit.Hearts,
        Suit.Diamonds,
        Suit.Clubs,
        Suit.Spades
    };

        public static readonly List<Rank> Ranks = new List<Rank>
    {
        Rank.Two, Rank.Three, Rank.Four, Rank.Five, Rank.Six,
        Rank.Seven, Rank.Eight, Rank.Nine, Rank.Ten, Rank.Jack,
        Rank.Queen, Rank.King, Rank.Ace
    };
    }

}
