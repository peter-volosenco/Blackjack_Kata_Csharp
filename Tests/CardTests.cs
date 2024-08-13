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
    public class CardTests
    {
        [TestMethod]
        public void Card_ShouldReturnCorrectValue_ForFaceCard()
        {
            var card = new Card(Suit.Hearts, Rank.King);
            Assert.AreEqual(10, Convert.ToInt32(card.Rank.Value));
        }

        [TestMethod]
        public void Card_ShouldReturnCorrectValue_ForNumberCard()
        {
            var card = new Card(Suit.Clubs, Rank.Five);
            Assert.AreEqual(5, Convert.ToInt32(card.Rank.Value));
        }

        [TestMethod]
        public void Card_ShouldReturnCorrectValue_ForAce()
        {
            var card = new Card(Suit.Spades, Rank.Ace);
            Assert.AreEqual(11, Convert.ToInt32(card.Rank.Value)); // Assuming Ace is initially valued at 11
        }
    }
}
