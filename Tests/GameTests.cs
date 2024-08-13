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
    public class GameTests
    {
        [TestMethod]
        public void Game_ShouldResetHands_BetweenRounds()
        {
            // Arrange
            var game = new Game();

            // Manually start and simulate the game state
            game.GetPlayer().Hit(new Card(Suit.Hearts, Rank.King));
            game.GetPlayer().Hit(new Card(Suit.Diamonds, Rank.Queen));
            game.GetDealer().Hit(new Card(Suit.Spades, Rank.Seven));
            game.GetDealer().Hit(new Card(Suit.Clubs, Rank.Six));

            // Act
            game.ResetGame(); // Assuming ResetGame is a public method

            // Assert
            Assert.AreEqual(0, game.GetPlayer().Hand.GetCardsCount());
            Assert.AreEqual(0, game.GetDealer().Hand.GetCardsCount());
            Assert.AreEqual(0, game.GetDealer().Hand.GetCardsCount());
        }

        [TestMethod]
        public void Game_ShouldDetermineWinner_Correctly()
        {
            // Arrange
            var game = new Game();
            game.GetPlayer().Hit(new Card(Suit.Hearts, Rank.King)); // 10 points
            game.GetPlayer().Hit(new Card(Suit.Diamonds, Rank.Eight)); // 8 points
            game.GetDealer().Hit(new Card(Suit.Spades, Rank.Seven)); // 7 points
            game.GetDealer().Hit(new Card(Suit.Clubs, Rank.Six)); // 6 points

            // Act
            game.DetermineWinner();

            // Assert
            // The player should win because 18 > 13
            Assert.AreEqual(game.GetPlayer().Money, 100 + 4); // Bet + winnings
        }
    }
}
