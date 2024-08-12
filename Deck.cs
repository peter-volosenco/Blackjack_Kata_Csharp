using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Kata
{
    public class Deck
    {
        private List<Card> _cards;

        public Deck()
        {
            _cards = new List<Card>();
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    _cards.Add(new Card(suit, rank));
                }
            }
            Shuffle();
        }

        public void Shuffle()
        {
            Random rng = new Random();
            _cards = _cards.OrderBy(a => rng.Next()).ToList();
        }

        public Card Deal()
        {
            if (_cards.Count == 0)
            {
                throw new InvalidOperationException("No cards left in the deck.");
            }

            Card dealtCard = _cards.First();
            _cards.RemoveAt(0);
            return dealtCard;
        }
    }

}
