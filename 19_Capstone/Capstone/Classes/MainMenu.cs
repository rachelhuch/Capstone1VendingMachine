using System;
using System.Collections.Generic;
using System.Text;


namespace Capstone.Classes
{
    public class MainMenu
    {
        private VendingMachine vm;

        public MainMenu(VendingMachine theVm)
        {
            this.vm = theVm;
            int variable = 1;
            while (variable == 1)
            {
                //  public Dictionary<string, List<Item>> ItemStock{get; set;}
                //
                Console.WriteLine("   Vending Machine Main Menu   ");
                Console.WriteLine("*******************************");
                Console.WriteLine("1)Display Vending Machine Items");
                Console.WriteLine("2)Purchase");
                Console.WriteLine("3)Exit");
                Console.Write("Enter your choice (1, 2, 3) here: ");
                string choice = Console.ReadLine();

                if (!(choice == "3" || choice == "2" || choice == "1"))
                {
                    Console.WriteLine("Please choose again.");
                }

                else
                {




                    if (choice == "1")
                    {
                        foreach (KeyValuePair<string, Slot> item in vm.inventory)

                        {
                            Console.WriteLine($"{item.Key}\t{ item.Value.ItemName}\t{item.Value.Price}");
                        }
                    }

                    else if (choice == "2")
                    {
                        int menu2 = 1;
                        while (menu2 == 1)
                        {
                            Console.WriteLine("Purchase Menu");
                            Console.WriteLine("1)Feed Money");
                            Console.WriteLine("2) Select Product");
                            Console.WriteLine("3) Finish Transaction");
                            Console.Write("Enter your choice (1, 2, 3) here: ");

                            string selection = Console.ReadLine();

                            if (!(choice == "3" || choice == "2" || choice == "1"))
                            {
                                Console.WriteLine("Please choose again.");
                            }

                            else
                            {
                                if (selection == "1")
                                {
                                    Console.Write("How much are you depositing?\t");

                                    decimal moneyIn = decimal.Parse(Console.ReadLine());

                                    if (!(moneyIn % 1 == 0))
                                    {
                                        Console.WriteLine("Not valid. Please enter whole dollar amounts");
                                    }
                                    else
                                    {
                                        vm.FeedMoney(moneyIn);
                                    }




                                    Console.WriteLine($"Your balance is {vm.Balance:C}");
                                }
                                else if (selection == "2")
                                {
                                    // select product (item.key)
                                    Console.Write("What is your product?\t ex (A1)\t");
                                    string keyNumber = Console.ReadLine();
                                    keyNumber = keyNumber.ToUpper();
                                    if (!(vm.inventory.ContainsKey(keyNumber)))
                                    {
                                        Console.WriteLine("Invalid entry. Please enter your product. ex. A1");
                                    }
                                    else
                                    {
                                        if (vm.Balance < vm.inventory[keyNumber].Price)
                                        {
                                            Console.WriteLine("Please add more money.");
                                        }

                                        else
                                        {
                                            //decroment balance by item.value.price
                                            vm.Balance -= vm.inventory[keyNumber].Price;

                                            //decroment item.value.quanity by 1
                                            vm.inventory[keyNumber].Price -= 1;

                                            //some fancy CW 
                                            Console.WriteLine($"Enjoy your {vm.inventory[keyNumber].ItemName}");

                                            //chomp chop stuff
                                            if (vm.inventory[keyNumber].ItemCategory == "Chip")
                                            {
                                                Console.WriteLine("\t Crunch Crunch, Yum!");
                                            }
                                            if (vm.inventory[keyNumber].ItemCategory == "Candy")
                                            {
                                                Console.WriteLine("\t Munch Munch, Yum!");
                                            }
                                            if (vm.inventory[keyNumber].ItemCategory == "Drink")
                                            {
                                                Console.WriteLine("\t Glug Glug, Yum!");
                                            }
                                            if (vm.inventory[keyNumber].ItemCategory == "Gum")
                                            {
                                                Console.WriteLine("\t Chew Chew, Yum!");
                                            }
                                            Console.WriteLine($"Your balance is {vm.Balance:C}");
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine($"Your change is {vm.Balance}");
                                    vm.EndTransaction();
                                    menu2 = 2;
                                }
                            }
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
}