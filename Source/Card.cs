using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Kata.Source
{
    public class Card
    {
        public Suit Suit { get; }
        public Rank Rank { get; }

        public Card(Suit suit, Rank rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public override string ToString()
        {
            return $"{Rank.Name} of {Suit.Name} ({Rank.Value} points)";
        }

        public string Display()
        {
            return $"{Rank.Name} of {Suit.Name}";
        }
    }

}
