using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Item
    {
        //public int Quantity {get; set;} can do it somewhere else


            //properties
        public decimal Price { get; set; }

        public string IDNumber { get; private set; }

        public  string ItemName { get; set; }

        public string ItemCategory { get; set; }

        
        //constructors

        public Item (string idNumber, string itemName, decimal price, string itemCategory)
        {
            this.IDNumber = idNumber;
            this.Price = price;
            this.ItemName = itemName;
            this.ItemCategory = itemCategory;
        }

        public string ConsumedOutput()
        {
            if (this.ItemName == "Chips")
            {
                return "Crunch, Crunch, Yum!";
            }
            else if (this.ItemName =="Candy")
            {
                return "Munch, Munch, Yum!";
            }
            else if (this.ItemName == "Drink")
            {
                return ("Glug, Glug, Yum!");
            }
            else
            {
                return ("Chew, Chew, Yum!");
            }
        }
        


    }
}
