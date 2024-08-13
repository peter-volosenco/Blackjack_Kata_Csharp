using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Kata.Source
{

    public class Player : IPlayerActions
    {
        public Hand Hand { get; set; }
        public decimal Money { get; private set; } = 100; // Start with $100
        private const decimal BetAmount = 2; // Bet amount $2

        public Player()
        {
            Hand = new Hand();
        }

        public void Hit(Card card)
        {
            Hand.AddCard(card);
        }

        public void Stand()
        {
            // Implement stand logic if necessary
        }

        public bool IsBusted()
        {
            return Hand.IsBusted();
        }

        public bool HasBlackjack()
        {
            return Hand.HasBlackjack();
        }

        public int GetTotalValue()
        {
            return Hand.GetTotalValue();
        }

        public bool PlaceBet()
        {
            if (Money >= BetAmount)
            {
                Money -= BetAmount;
                return true;
            }
            else
            {
                Console.WriteLine("Not enough money to place a bet.");
                return false;
            }
        }

        public void WinBet()
        {
            Money += BetAmount * 2; // Win doubles the bet
        }

        public void PushBet()
        {
            Money += BetAmount; // In case of a tie, return the bet amount
        }

        public override string ToString()
        {
            return $"Money: ${Money}";
        }
    }

}
