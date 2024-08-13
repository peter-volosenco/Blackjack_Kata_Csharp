using Blackjack_Kata.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Blackjack_Kata.Tests
{
    [TestClass]
    public class DeckTests
    {
        [TestMethod]
        public  void Deck_ShouldContain52UniqueCards_AfterInitialization()
        {
            // Arrange
            var deck = new Deck();

            // Act
            var cards = new HashSet<Card>();
            while (deck.Count() > 0)
            {
                cards.Add(deck.Deal());
            }

            // Assert
            Assert.AreEqual(52, cards.Count);
        }

        [TestMethod]
        public  void Deck_ShouldShuffleCards_Correctly()
        {
            // Arrange
            var deck1 = new Deck();
            var deck2 = new Deck();

            // Act
            deck1.Shuffle();
            deck2.Shuffle();

            // Assert
            CollectionAssert.AreNotEqual(deck1.GetCards(), deck2.GetCards()); // Ensure decks are shuffled differently
        }
    }
}
