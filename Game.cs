using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
     class Game
    {
        //member variables
        public int numberOfDays;
        public Lemon lemon = new Lemon();
        public Cup cup = new Cup();
        public CupOfSugar sugarCup = new CupOfSugar();
        public IceCube iceCube = new IceCube();
        public Player newPlayer;
        public List<Lemon> Lemons = new List<Lemon>();
        public List<Cup> Cups = new List<Cup>();
        public List<IceCube> IceCubes = new List<IceCube>();
        public List<CupOfSugar> SugarCups = new List<CupOfSugar>();
        public Weather daysWeather = new Weather();
        public List<string> lemonPackages = new List<string> { "1)   10 Lemons: $0.88", "2)   30 Lemons:$2.17", "3)   75 Lemons: $4.02" };
        public List<string> cupPackages = new List<string> { "1)   25 Cups: $0.78", "2)   50 Cups: $1.72", "3)   100 Cups: $3.17" };
        public List<string> sugarCupPackages = new List<string> { "1)   8 Cups: $0.63", "2)   20 Cups: $1.58", "3)   48 Cups: $3.27" };
        public List<string> IcePackages = new List<string> { "1)   100 Ice Cubes: $0.91", "2)   250 Ice Cubes: $2.11", "3)   500 Ice Cubes: $3.83" };
        public int choiceToPurchase = 0;




        //constructor
        public Game()
        {
             
        }

        //member methods
        public void RunGame()
        {
            DisplayRules();
            Console.ReadLine();
            CreatePlayer();
            DecideNumberOfDays();
            PurchasingMenu();
           


        }

        public void DisplayWeather()
        {
            Console.WriteLine($"Degrees:{daysWeather.weatherDegree} \nForecast:{daysWeather.forecast}");
        }
        public void DisplayRules()
        {
            Console.WriteLine("INSTRUCTIONS: \nYour goal is to make as much money as you can in 7, 14, or 30 days by selling lemonade at your lemonade stand. \nBuy cups, lemons, sugar, and ice cubes, then set your recipe based on the weather and conditions.\nStart with the basic recipe, but try to vary the recipe and see if you can do better.\nLastly, set your price and sell your lemonade at the stand. \nTry changing up the price based on the weather conditions as well. \nAt the end of the game, you'll see how much money you made. \nWrite it down and play again to try and beat your score!\n\nPress enter to play!");
        }

        public void CreatePlayer()
        {
            Console.WriteLine("Player, enter your name:");
            newPlayer = new Player(Console.ReadLine());
        }

        public void DecideNumberOfDays()
        {
            Console.WriteLine($"{newPlayer.name}, How many days would you like to run your stand for?\nType 7 for 7 days.\nType 14 for 14 days.\nType 30 for 30 days.");
            numberOfDays = Convert.ToInt32(Console.ReadLine());
            
            
        }
        public void DisplayAmountOfMoney()
        {
            Console.WriteLine($"Ben you have ${newPlayer.wallet.Money} and \n");
        }

        public void DisplayInventory()
        {
            Console.WriteLine($"Lemons:{Lemons.Count}\nCups:{Cups.Count}\nIce Cubes:{IceCubes.Count}\nSugar Cubes:{SugarCups.Count}");
        }

        public void PurchasingMenu()
        {
            DisplayWeather();
            DisplayAmountOfMoney();
            DisplayInventory();
            Console.WriteLine("Would you like to purchase any items?\n1)Yes\n2)No");
            choiceToPurchase = Convert.ToInt32(Console.ReadLine());
            while(choiceToPurchase == 1)
            {
                DisplayAmountOfMoney();
                DisplayInventory();
                Console.WriteLine("Type 1 to purchase more Lemons\nType 2 to purchase more Cups\nType 3 to purchase more Cups of Sugar\nType 4 to purchase more Ice Cubes\nType 5 to End Purchases");
                int choiceOfPurchase = Convert.ToInt32(Console.ReadLine());
                
                if (choiceOfPurchase == 5)
                {
                    break;
                    
                }
                else if(choiceOfPurchase == 1)
                {
                    Console.WriteLine("Choose a package:");
                    foreach(string option in lemonPackages)
                    {
                        Console.WriteLine(option);
                    }
                    string packageOption = Console.ReadLine();
                    if(packageOption == "1") 
                    {
                        newPlayer.wallet.money -= 0.88;
                        for (int i = 0; i < 10; i++)
                            Lemons.Add(lemon);
                        
                    }
                    else if(packageOption == "2")
                    {
                        newPlayer.wallet.money -= 2.17;
                        for (int i = 0; i < 30; i++)
                            Lemons.Add(lemon);

                    }
                    else if(packageOption == "3")
                    {
                        newPlayer.wallet.money -= 4.02;
                        for (int i = 0; i < 75; i++)
                            Lemons.Add(lemon);

                    }
                    else
                    {
                        Console.WriteLine("Not a valid choice.");
                    }


                }
                else if (choiceOfPurchase == 2)
                {
                    Console.WriteLine("Choose a package:");
                    foreach (string option in cupPackages)
                    {
                        Console.WriteLine(option);
                    }
                    string packageOption = Console.ReadLine();
                    if (packageOption == "1")
                    {
                        newPlayer.wallet.money -= 0.78;
                        for (int i = 0; i < 25; i++)
                            Cups.Add(cup);

                    }
                    else if (packageOption == "2")
                    {
                        newPlayer.wallet.money -= 1.72;
                        for (int i = 0; i < 50; i++)
                            Cups.Add(cup);
                    }
                    else if (packageOption == "3")
                    {
                        newPlayer.wallet.money -= 3.17;
                        for (int i = 0; i < 100; i++)
                            Cups.Add(cup);

                    }
                    else
                    {
                        Console.WriteLine("Not a valid choice.");
                    }


                }
                else if (choiceOfPurchase == 3)
                {
                    Console.WriteLine("Choose a package:");
                    foreach (string option in sugarCupPackages)
                    {
                        Console.WriteLine(option);
                    }
                    string packageOption = Console.ReadLine();
                    if (packageOption == "1")
                    {
                        newPlayer.wallet.money -= 0.63;
                        for (int i = 0; i < 8; i++)
                            SugarCups.Add(sugarCup);

                    }
                    else if (packageOption == "2")
                    {
                        newPlayer.wallet.money -= 1.58;
                        for (int i = 0; i < 20; i++)
                            SugarCups.Add(sugarCup);
                    }
                    else if (packageOption == "3")
                    {
                        newPlayer.wallet.money -= 3.27;
                        for (int i = 0; i < 48; i++)
                            SugarCups.Add(sugarCup);

                    }
                    else
                    {
                        Console.WriteLine("Not a valid choice.");
                    }


                }
                else if (choiceOfPurchase == 4)
                {
                    Console.WriteLine("Choose a package:");
                    foreach (string option in IcePackages)
                    {
                        Console.WriteLine(option);
                    }
                    string packageOption = Console.ReadLine();
                    if (packageOption == "1")
                    {
                        newPlayer.wallet.money -= 0.91;
                        for (int i = 0; i < 100; i++)
                            IceCubes.Add(iceCube);

                    }
                    else if (packageOption == "2")
                    {
                        newPlayer.wallet.money -= 2.11;
                        for (int i = 0; i < 250; i++)
                            IceCubes.Add(iceCube);
                    }
                    else if (packageOption == "3")
                    {
                        newPlayer.wallet.money -= 3.83;
                        for (int i = 0; i < 500; i++)
                            IceCubes.Add(iceCube);

                    }
                    else
                    {
                        Console.WriteLine("Not a valid choice.");
                    }


                }
                else 
                {
                    Console.WriteLine("Not a valid choice.");
                }
                


            }

        }
    }
}
