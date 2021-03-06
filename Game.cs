﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
      class Game
    {
       //member variables
             int numberOfDays;
             Customer customer;
             List<Day> Days;
             List<Customer> Customers;
             List<CupOfLemonade> cupsOfLemonade;
             double priceOfLemonade;
             Player newPlayer;
             string choiceToPurchase;
             Store store;
             CupOfLemonade cupOfLemonade;




        //constructor
        public Game()
        {
            customer = new Customer();
            Customers = new List<Customer>();
            Days = new List<Day>();
            cupsOfLemonade = new List<CupOfLemonade>();
            store = new Store();
            cupOfLemonade = new CupOfLemonade();
        }

       //member methods

            //main function for game
            public void RunGame()
            {
                //displaying intial game rules and deciding days and creating the players
                DisplayRules();
                Console.ReadLine();
                CreatePlayer();
                DecideNumberOfDays();
                cupOfLemonade.MakeRecipe();
                Console.WriteLine("Press enter to start Day One!");
                Console.ReadLine();
                //loop for completing days
                for (int i = 1; i <= Days.Count; i++)
                {
                    CreateCustomers();
                    Weather weather = new Weather();
                    Console.WriteLine($"Day {i} of {numberOfDays}");
                    Console.WriteLine($"\nDegrees:{weather.weatherDegree}\nForecast:{weather.forecast}\n");
                    newPlayer.wallet.DisplayAmountOfMoney();
                    newPlayer.inventory.DisplayInventory();
                    ChoiceToPurchase();
                    DecideWhatToBuy();
                    DecidePriceOfLemonade();
                    EachCustomerPurchase(weather, newPlayer.inventory);
                    newPlayer.addProfit(cupsOfLemonade, priceOfLemonade);
                    Console.WriteLine($"Your new balance is:{newPlayer.wallet.money}");
                    choiceToPurchase = null;
                    newPlayer.inventory.iceCubes.Clear();

                    Console.WriteLine("\nPress enter to start the next day.");
                    Console.ReadLine();
                }
            //after days are complete
            Console.WriteLine($"After {numberOfDays} days you made a total of ${newPlayer.wallet.money}!");
            Console.ReadLine();

            
            }







        
            public void EachCustomerPurchase(Weather weather, Inventory inventory)
            {
                for (int i = 0; i < Customers.Count; i++)
                {
                    bool purchase = false;
                    Customers[i].CustomersPurchases(weather, priceOfLemonade, cupsOfLemonade, newPlayer.inventory, cupOfLemonade, customer, purchase);
                }
            }



            public void DecidePriceOfLemonade()//used single responsibility principle - i used this method so i can keep my functions simple and only for one purpose. that way if i needed to use it again elsewhere i could.
            {
                Console.WriteLine("What would you like to sell your cups of lemonade for today?");
                priceOfLemonade = Convert.ToDouble(Console.ReadLine());
            }
            public void DisplayRules()//used single responsibility principle
            {
                Console.WriteLine("INSTRUCTIONS: \nYour goal is to make as much money as you can in 7, 14, or 30 days by selling lemonade at your lemonade stand. \nBuy cups, lemons, sugar, and ice cubes, then set your recipe based on the weather and conditions.\nStart with the basic recipe, but try to vary the recipe and see if you can do better.\nLastly, set your price and sell your lemonade at the stand. \nTry changing up the price based on the weather conditions as well. \nAt the end of the game, you'll see how much money you made. \nWrite it down and play again to try and beat your score!\n\nPress enter to play!");
            }

        
            public void CreatePlayer()//used single responsibility principle
            {
                Console.WriteLine("Player, enter your name:");
                newPlayer = new Player(Console.ReadLine());
            }

        
            public void DecideNumberOfDays()//used single responsibility principle
            {
                while (numberOfDays != 7 && numberOfDays != 14 && numberOfDays != 30)
                {
                    Console.WriteLine($"{newPlayer.name}, How many days would you like to run your stand for?\nType 7 for 7 days.\nType 14 for 14 days.\nType 30 for 30 days.");
                    string userInput = Console.ReadLine();
                    if(userInput == "7" || userInput == "14" || userInput == "30")
                    {
                        numberOfDays = Convert.ToInt32(userInput);
                        for (int i = 0; i < numberOfDays; i++)
                        {
                            Day day = new Day();
                            Days.Add(day);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not a valid option.");
                    }
                
                }
            
            }


            public void ChoiceToPurchase()//used single responsibility principle
            {
                while (choiceToPurchase != "1" && choiceToPurchase != "2")
                {
                
                    Console.WriteLine("Would you like to purchase any items?\n1)Yes\n2)No");
                    choiceToPurchase = Console.ReadLine();
                    if(choiceToPurchase != "1" && choiceToPurchase != "2")
                    {
                        Console.WriteLine("Not a valid option.");
                    }
                
                }

            }
            

            public void DecideWhatToBuy()
            {
                while(choiceToPurchase == "1")
                {

                newPlayer.wallet.DisplayAmountOfMoney();
                newPlayer.inventory.DisplayInventory();
                Console.WriteLine($"Type 1 to purchase more Lemons(price per lemon:${store.pricePerLemon})\nType 2 to purchase more Cups(price per cup:${store.pricePerCup})\nType 3 to purchase more sugar cubes(price per sugar cube:${store.pricePerSugarCube})\nType 4 to purchase more Ice Cubes(price per 10 ice cups:${store.pricePerIceCube})\nType 5 to End Purchases");
                    string userInput = Console.ReadLine();
                
                        if (userInput == "1" || userInput == "2" || userInput == "3" || userInput == "4" || userInput == "5")
                        {
                        

                            if (userInput == "5")
                            {
                                break;
                            }
                            else if (userInput == "1")
                            {
                                store.SellLemons(newPlayer);
                            }
                            else if (userInput == "2")
                            {
                                store.SellCups(newPlayer);
                            }
                            else if (userInput == "3")
                            {
                                store.SellSugarCubes(newPlayer);
                            }
                            else if (userInput == "4")
                            {
                                store.SellIceCubes(newPlayer);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Not a valid option.");
                        }
                }
            }

            public void CreateCustomers()
            {
                for (int i = 0; i < 200; i++)
                {
                    Customer customer = new Customer();
                    Customers.Add(customer);
                }
            }

                
            
        
      }
}
