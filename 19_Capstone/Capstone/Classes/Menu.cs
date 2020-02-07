using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Classes;

namespace Capstone
{
    public class Menu
    {
        public Menu()
        {
            VendingMachine variable = new VendingMachine();
            Console.WriteLine("Purchase Menu");
            Console.WriteLine("1)Feed Money");
            Console.WriteLine("2) Select Product");
            Console.WriteLine("3) Finish Transaction");

            Console.Write("Enter your choice (1, 2, 3) here: ");
            string choice = Console.ReadLine();
            if (int.Parse(choice) > 3)
            {
                Console.WriteLine("Please choose again.");
            }
            else if(choice=="1")
            {
                Console.Write("How much are you depositing?\t");
                decimal moneyIn = decimal.Parse(Console.ReadLine());
                
                variable.FeedMoney(moneyIn);
            }
            else if(choice =="2")
            {
                //select product
                Slot something = new Slot();
                if (choice == "1")
                {
                    foreach (Item x in something.items)
                    {
                        Console.WriteLine($"{ x.IDNumber}\t{ x.ItemName}\t{ x.Price}");
                        //add quantity
                        //dictionary
                        //slot

                    }
                }

            }
            else
            {
                Console.WriteLine($"Your change is {variable.Balance}");
                variable.EndTransaction();
                
            }



        }
    }
}
