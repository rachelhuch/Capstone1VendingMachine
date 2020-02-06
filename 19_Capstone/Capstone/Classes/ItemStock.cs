using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Capstone.Classes;


namespace Capstone.Classes
{
    public class ItemStock
    {
        public List<Item> items = new List<Item>();
        public ItemStock()
        {
            string filePath = @"C:\Users\Student\git\c-module-1-capstone-team-2\19_Capstone\Capstone\vendingmachine.csv";

             
            using (StreamReader sr = new StreamReader(filePath))
            {

                while (!sr.EndOfStream)
                {
                    string input = sr.ReadLine();
                    string[] fields = input.Split("|");
                    string idNumber = fields[0];
                    string itemName = fields[1];
                    decimal price = decimal.Parse(fields[2]);
                    string itemCategory = fields[3];

                    Item newItem = new Item(idNumber, itemName, price, itemCategory);
                    items.Add(newItem);
                }


            }
        }
    }
}
