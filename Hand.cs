using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Kata
{
    public class Hand
    {
        private List<Card> _cards;

        public Hand()
        {
            _cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            _cards.Add(card);
        }

        public int GetTotalValue()
        {
            int total = _cards.Sum(card => (int)card.Rank);
            int aceCount = _cards.Count(card => card.Rank == Rank.Ace);

            while (total > 21 && aceCount > 0)
            {
                total -= 10; // Consider Ace as 1 instead of 11
                aceCount--;
            }

            return total;
        }

        public bool IsBusted()
        {
            return GetTotalValue() > 21;
        }

        public bool HasBlackjack()
        {
            return GetTotalValue() == 21;
        }

        public override string ToString()
        {
            return string.Join(", ", _cards.Select(card => card.ToString()));
        }
    }
}
