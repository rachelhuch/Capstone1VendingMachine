using System;
using System.Collections.Generic;
using System.Text;


namespace Capstone.Classes
{
    public class MainMenu
    {

        
        public MainMenu()
        {
            int variable = 1;
            while (variable ==1)
            { 
            //  public Dictionary<string, List<Item>> ItemStock{get; set;}
            //
                Console.WriteLine("   Vending Machine Main Menu   ");
                Console.WriteLine("*******************************");
                Console.WriteLine("1)Display Vending Machine Items");
                Console.WriteLine("2)Purchase");
                Console.WriteLine("3)Exit");
                Console.Write( "Enter your choice (1, 2, 3) here: ");
                string choice = Console.ReadLine();

            if (int.Parse(choice) >3)
            {
                Console.WriteLine("Please choose again.");
            }

            ItemStock something = new ItemStock();
                if (choice == "1")
                {
                    foreach (Item x in something.items)
                    {
                        Console.WriteLine($"{ x.IDNumber}\t{ x.ItemName}\t{ x.Price}");

                    }
                }

                else if (choice == "2")
                {
                    //go to new menu
                }
                //Make menu- give choices between 1)Feed Money 2)Select Product 3) Finish Transaction 
                else if (choice == "3")
                {
                 
                    variable = 2;
                }
            }
            }


        //Vending Machine
       //get private set balance:decimal
       // inventory-dictionary, <string, slot>        product-string name, decimal price, ,  ---Consume Method(returns string"YUM") (Candy, Chips, etc extend product)
       //     method
       //     feedMoney(int)
       //     MainMenu(list)
       //     MainMenu(string-slotId)-returns Product
       //     endTransaction-return change as string

       //     slot
       //     quantity:int
       //     product:product
       //     private load method- read the file and load up 5 of everything


    }
}
