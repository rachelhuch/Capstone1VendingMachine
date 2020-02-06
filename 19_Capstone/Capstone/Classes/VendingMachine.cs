using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class VendingMachine
    {
        public decimal Balance { get; private set; }
        //public Dictionary <string, Slot> {get;}

        public void FeedMoney(decimal feedMoney)
        {
            Balance += feedMoney;
        }



        //        //public List<>GetInventory()
        //        {
        //        obtains inventory

        //    }

        //    public string Product(string item)
        //    {

        //    }

        public void EndTransaction()
        {
            Balance = 0;
        }
    }
}

