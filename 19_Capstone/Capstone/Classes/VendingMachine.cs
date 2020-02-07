using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capstone.Classes
{
    public class VendingMachine
    {
        public decimal Balance { get; private set; }
        public Dictionary<string, Slot> inventory = new Dictionary<string, Slot>();


        public decimal FeedMoney(decimal feedMoney)
        {
            return Balance += feedMoney;
        }

        string file = @"C:\Users\Student\git\c-module-1-capstone-team-2\19_Capstone\Capstone\vendingmachine.csv";

        private void Load(string filePath)
        {
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

                    Slot slot = new Slot(idNumber, itemName, price, itemCategory, 5);
                    inventory.Add(idNumber, slot);

                }
            }
        }

        public void EndTransaction()
        {
            Balance = 0;
        }
        public VendingMachine()
        {
            Load(file);
        }
    }
}

