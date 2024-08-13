using Blackjack_Kata.Source;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Kata.Tests
{
    [TestClass]
    public class HandTests
    {
        [TestMethod]
        public void AddCard_ShouldIncreaseCardCount()
        {
            var hand = new Hand();
            hand.AddCard(new Card(Suit.Hearts, Rank.King));
            Assert.AreEqual(1, hand.GetCardsCount());
        }

        [TestMethod]
        public void CalculatePoints_ShouldReturnCorrectSum()
        {
            var hand = new Hand();
            hand.AddCard(new Card(Suit.Hearts, Rank.Ten));
            hand.AddCard(new Card(Suit.Spades, Rank.Queen));
            Assert.AreEqual(20, hand.CalculatePoints());
        }
    }
}
