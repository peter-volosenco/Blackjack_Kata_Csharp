using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Kata.Source
{
    public class Game
    {
        private Deck _deck;
        private Player _player;
        private Dealer _dealer;

        public Game()
        {
            _deck = new Deck();
            _player = new Player();
            _dealer = new Dealer();
        }

        public Player GetPlayer()
        {
            return _player;
        }

        public Dealer GetDealer()
        {
            return _dealer;
        }

        public void Start()
        {
            while (_player.Money > 0)
            {
                Console.WriteLine("Starting a new round...");
                if (_player.PlaceBet())
                {
                    PlayRound();
                    Console.WriteLine(_player);
                }
                else
                {
                    break;
                }

                Console.WriteLine("Press any key to start the next round or 'Q' to quit.");
                if (Console.ReadKey().Key == ConsoleKey.Q)
                {
                    break;
                }
                ResetGame();
            }

            Console.WriteLine("Game over! You've run out of money.");
        }

        private void PlayRound()
        {
            _player.Hit(_deck.Deal());
            _player.Hit(_deck.Deal());

            _dealer.Hit(_deck.Deal());
            _dealer.Hit(_deck.Deal());

            Console.WriteLine("Round start");
            //Console.WriteLine("Your hand: " + _player.Hand);
            Console.WriteLine("Dealer's face-up card: " + _dealer.Hand.ToString().Split(',')[0] + " total value of " + _dealer.Hand.GetTotalValue());

            PlayerTurn();

            if (!_player.IsBusted())
            {
                _dealer.Play(_deck);
                DisplayHands();
            }

            DetermineWinner();
        }

        private void PlayerTurn()
        {
            while (true)
            {
                DisplayHands();

                Console.WriteLine("Choose an action: (H)it or (S)tand");
                string action = Console.ReadLine();

                if (action != null)
                    action = action.ToUpper();

                if (action == "H")
                {
                    _player.Hit(_deck.Deal());
                    if (_player.IsBusted())
                    {
                        DisplayHands();
                        Console.WriteLine("You busted!");
                        break;
                    }
                    else if (_player.HasBlackjack())
                    {
                        DisplayHands();
                        Console.WriteLine("You got a Blackjack!");
                        break;
                    }
                }
                else if (action == "S")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid action, please choose (H)it or (S)tand.");
                }

                Console.WriteLine("Round end you have " + _player.Money);
                Console.WriteLine("Dealer has " + _dealer.Money);
                Console.WriteLine("");
            }
        }

        public void DetermineWinner()
        {
            if (_player.IsBusted())
            {
                Console.WriteLine("Dealer wins.");
            }
            else if (_dealer.IsBusted())
            {
                Console.WriteLine("You win!");
                _player.WinBet();
            }
            else if (_player.GetTotalValue() > _dealer.GetTotalValue())
            {
                Console.WriteLine("You win!");
                _player.WinBet();
            }
            else if (_player.GetTotalValue() < _dealer.GetTotalValue())
            {
                Console.WriteLine("Dealer wins.");
            }
            else
            {
                Console.WriteLine("It's a tie.");
                _player.PushBet();
            }
        }

        public void ResetGame()
        {
            _deck = new Deck();
            _player.Hand = new Hand();
            _dealer.Hand = new Hand();
        }

        private void DisplayHands()
        {
            Console.Clear();

            // Display Player Information
            Console.WriteLine($"Player ({_player.GetTotalValue()} points) (${_player.Money})");
            foreach (var card in _player.Hand.ToString().Split(','))
            {
                Console.WriteLine(card.Trim());
            }

            Console.WriteLine();

            // Display Dealer Information
            Console.WriteLine($"Dealer ({_dealer.GetTotalValue()} points) (${_dealer.Money})");
            foreach (var card in _dealer.Hand.ToString().Split(','))
            {
                Console.WriteLine(card.Trim());
            }

            Console.WriteLine();
        }
    }

}
