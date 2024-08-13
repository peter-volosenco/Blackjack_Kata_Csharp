using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Kata.Source
{
    public class Deck
    {
        private List<Card> _cards;

        public Deck()
        {
            _cards = new List<Card>();

            foreach (var suit in CardDefinitions.Suits)
            {
                foreach (var rank in CardDefinitions.Ranks)
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

        public int Count()
        {
            return _cards.Count; 
        }

        public List<Card> GetCards()
        {
            return _cards;
        }

        public Card GetCard(int index)
        {
            return _cards[index];
        }

    }

}
