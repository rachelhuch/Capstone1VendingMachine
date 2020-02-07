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

                VendingMachine thisOne = new VendingMachine();
                
                
                if (choice == "1")
                {
                    foreach (KeyValuePair<string, Slot> item in thisOne.inventory)
              
                    {
                        Console.WriteLine($"{item.Key}\t{ item.Value.ItemName}\t{item.Value.Price}");
                    }
                }

                else if (choice == "2")
                {
                    
                    Console.WriteLine("Purchase Menu");
                    Console.WriteLine("1)Feed Money");
                    Console.WriteLine("2) Select Product");
                    Console.WriteLine("3) Finish Transaction");
                    Console.Write("Enter your choice (1, 2, 3) here: ");

                    string selection = Console.ReadLine();

                    if (int.Parse(selection) > 3)
                    {
                        Console.WriteLine("Please choose again.");
                    }
                    else if (selection == "1")
                    {
                        Console.Write("How much are you depositing?\t");

                        decimal moneyIn = decimal.Parse(Console.ReadLine());

                        thisOne.FeedMoney(moneyIn);
                    }
                    else if (selection == "2")
                    {
                        //select product
                        //Slot something = new Slot();
                        //if (choice == "1")
                        //{
                        //    foreach (Item x in something.items)
                        //    {
                        //        Console.WriteLine($"{ x.IDNumber}\t{ x.ItemName}\t{ x.Price}");
                        //        //add quantity
                        //        //dictionary
                        //        //slot

                        //    }
                        //}

                    }
                    else
                    {
                        Console.WriteLine($"Your change is {thisOne.Balance}");
                        thisOne.EndTransaction();

                    }
                }
                //Make menu- give choices between 1)Feed Money 2)Select Product 3) Finish Transaction 
                else if (choice == "3")
                {
                    Console.WriteLine("Thank you for using the best vending machine on the planet!");
                    variable = 2;
                }
            }
            }


    }
}
