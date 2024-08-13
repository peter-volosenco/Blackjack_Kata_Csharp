using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Kata.Source
{
    public class Dealer : Player
    {
        private const int StandThreshold = 17;

        public void Play(Deck deck)
        {
            while (GetTotalValue() < StandThreshold)
            {
                Hit(deck.Deal());
            }
        }
    }
}
