using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Kata.Source
{
    public interface IPlayerActions
    {
        void Hit(Card card);
        void Stand();
        bool IsBusted();
        bool HasBlackjack();
        int GetTotalValue();
    }

}
