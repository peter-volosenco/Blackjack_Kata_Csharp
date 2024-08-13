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
    public class UserInterfaceTests
    {
        [TestMethod]
        public void DisplayHand_ShouldShowCorrectCardDetails()
        {
            var hand = new Hand();
            hand.AddCard(new Card(Suit.Hearts, Rank.King));

            // Assuming you have a method that formats hand for display
            var display = hand.Display();
            Assert.AreEqual("King of Hearts", display);
        }
    }
}
