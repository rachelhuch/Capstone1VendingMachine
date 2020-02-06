using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
   public class Money
    {
        public Money(decimal bal)
        {
            bal = Balance;
        }
        public decimal Balance { get; set; }

        // decimal costOfItem = 0;

        public void Deposit(decimal moneyGiven)
        {
            if (moneyGiven % 1 == 0)
            {


                Balance += moneyGiven;
            }
            //throw an error
            else
            {
                Balance = Balance;
            }

        }

        public void Withdraw(decimal costOfItem)
        {
            Balance -= costOfItem;

        }

    }
    }

