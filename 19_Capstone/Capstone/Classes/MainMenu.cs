using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


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

                if (!(choice == "4" || choice == "3" || choice == "2" || choice == "1"))
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
                                        if (vm.inventory[keyNumber].Quantity > 0)
                                        {
                                            if (vm.Balance < vm.inventory[keyNumber].Price)
                                            {
                                                Console.WriteLine("Please add more money.");
                                            }

                                            else
                                            {
                                                vm.WriteToLog($"{vm.inventory[keyNumber].ItemName} {vm.Balance} { vm.Balance - vm.inventory[keyNumber].Price}");
                                                //decriment balance by item.value.price
                                                vm.Balance -= vm.inventory[keyNumber].Price;

                                                //decriment item.value.quanity by 1
                                                vm.inventory[keyNumber].Quantity -= 1;

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
                                        else
                                        {
                                            Console.WriteLine("Sold Out!");
                                        }
                                    }
                                }
                                else if (selection == "3")
                                {
                                    Console.WriteLine($"Your change is {vm.Balance}");
                                    vm.EndTransaction();
                                    menu2 = 2;
                                }
                                else
                                {
                                    Console.WriteLine($"Please select again");
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
                    else if (choice == "4")
                    {
                        decimal sales = 0;
                        foreach (KeyValuePair<string, Slot> item in vm.inventory)
                        {
                            int quant = 5 - (vm.inventory[item.Key].Quantity);
                            Console.WriteLine($"{vm.inventory[item.Key].ItemName}, {quant}");
                            sales = sales + (quant * (vm.inventory[item.Key].Price));


                        }
                        Console.WriteLine(sales);




                        //string path = @"C:\Users\Student\git\c-module-1-capstone-team-2\19_Capstone\Capstone\bin\Debug\netcoreapp2.1\Log.txt";
                        //using (StreamReader sr = new StreamReader(path))
                        //{
                        //    while(!sr.EndOfStream)
                        //    {
                        //        string x = sr.ReadLine();
                        //        string[] stream = x.Split(" ");


                        //        Dictionary<string, int> salesReport = new Dictionary<string, int>();
                        //        int value = 1;
                        //        foreach (string item in stream)
                        //        {
                        //            if (salesReport.ContainsKey(item))
                        //            {
                        //                salesReport[item] += 1;
                        //            }
                        //            else
                        //            {
                        //                salesReport.Add(item,value);
                        //            }
                        //        }
                        //        foreach (var item in c)
                        //        {

                        //        }
                        //    }
                        //}
                    }
                }
            }


        }
    }
}