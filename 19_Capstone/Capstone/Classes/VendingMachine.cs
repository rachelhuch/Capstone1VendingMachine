using System;
using System.Collections.Generic;
using System.Text;


namespace Capstone.Classes
{
    public class VendingMachine
    {
       

        public VendingMachine()
        {

            //  public Dictionary<string, List<Item>> ItemStock{get; set;}
            //
                Console.WriteLine("Vending Machine Main Menu");
                Console.WriteLine("1)Display Vending Machine Items");
                Console.WriteLine("2)Purchase");
                Console.WriteLine("3)Exit");
                Console.Write("Enter your choice (1, 2, 3) here:");
                string choice = Console.ReadLine();

            if (!(choice=="1") || !(choice=="2") || !(choice=="3") )
            {
                Console.WriteLine("Please choose again.");
            }

            ItemStock something = new ItemStock();
            if (choice =="1")
            {
                foreach(Item x in something.items)
                {
                    Console.WriteLine(${ Price.Item}, 
                    
                }
            }

            //Make menu- give choices between 1)Feed Money 2)Select Product 3) Finish Transaction 
        }
    }
}
