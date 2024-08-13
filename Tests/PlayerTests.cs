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
    public class PlayerTests
    {
        [TestMethod]
        public void Player_ShouldBusted_WhenTotalValueExceeds21()
        {
            // Arrange
            var player = new Player();
            player.Hit(new Card(Suit.Hearts, Rank.King));  // 10 points
            player.Hit(new Card(Suit.Diamonds, Rank.Queen));  // 10 points
            player.Hit(new Card(Suit.Clubs, Rank.Two));  // 2 points

            // Act
            player.Hit(new Card(Suit.Spades, Rank.Jack));  // 10 points

            // Assert
            Assert.IsTrue(player.IsBusted());
        }

        [TestMethod]
        public void Player_ShouldWinBet_WhenDealerIsBusted()
        {
            // Arrange
            var player = new Player();
            var initialMoney = player.Money;

            // Act
            player.WinBet();

            // Assert
            Assert.AreEqual(initialMoney + 2 * 2, player.Money); // Betting amount + winnings
        }

        [TestMethod]
        public void Player_ShouldLoseBet_WhenBusted()
        {
            // Arrange
            var player = new Player();
            var initialMoney = player.Money;

            // Act
            player.PlaceBet();
            player.Hit(new Card(Suit.Hearts, Rank.King));  // 10 points
            player.Hit(new Card(Suit.Diamonds, Rank.Queen));  // 10 points
            player.Hit(new Card(Suit.Clubs, Rank.Two));  // 2 points
            player.Hit(new Card(Suit.Spades, Rank.Jack));  // 10 points

            // Assert
            Assert.AreEqual(initialMoney - 2, player.Money); // Should lose the bet amount
        }
    }
}
