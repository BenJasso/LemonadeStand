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
        public Player newPlayer;
        public List<Lemon> Lemons = new List<Lemon>();
        public List<Cup> Cups = new List<Cup>();
        public List<IceCube> IceCubes = new List<IceCube>();
        public List<SugarCube> SugarCubes = new List<SugarCube>();
        public Weather daysWeather = new Weather();
        public List<string> lemonPackages = new List<string> { "10 Lemons: $0.88", "30 Lemons:$2.17", "75 Lemons: $4.02" };





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
            Console.WriteLine($"Lemons:{Lemons.Count}\nCups:{Cups.Count}\nIce Cubes:{IceCubes.Count}\nSugar Cubes:{SugarCubes.Count}");
        }

        public void PurchasingMenu()
        {
            DisplayAmountOfMoney();
           DisplayInventory();
            Console.WriteLine("Would you like to purchase any items?\n1)Yes\n2)No");
            int choiceToPurchase = Convert.ToInt32(Console.ReadLine());
            while(choiceToPurchase == 1)
            {
                
                Console.WriteLine("Type 1 to purchase more Lemons\nType 2 to purchase more Cups\nType 3 to purchase more Ice Cubes\nType 4 to purchase more Sugar Cubes\nType 5 to End Purchases");
                int choiceOfPurchase = Convert.ToInt32(Console.ReadLine());
                DisplayAmountOfMoney();
                DisplayInventory();
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
                        newPlayer.wallet.money = -0.88;
                        for (int i = 0; i < 10; i++)
                            Lemons.Add(lemon);
                        Console.WriteLine(Lemons.Count);
                        Console.ReadLine();
                    }
                    
                }

            }

        }
    }
}
