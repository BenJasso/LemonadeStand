﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Game
    {
        //member variables
        public int numberOfDays;

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
        }
        public void DisplayRules()
        {
            Console.WriteLine("INSTRUCTIONS: \nYour goal is to make as much money as you can in 7, 14, or 30 days by selling lemonade at your lemonade stand. \nBuy cups, lemons, sugar, and ice cubes, then set your recipe based on the weather and conditions.\nStart with the basic recipe, but try to vary the recipe and see if you can do better.\nLastly, set your price and sell your lemonade at the stand. \nTry changing up the price based on the weather conditions as well. \nAt the end of the game, you'll see how much money you made. \nWrite it down and play again to try and beat your score!\n\nPress enter to play!");
        }

        public void CreatePlayer()
        {
            Console.WriteLine("Player, enter your name:");
            Player newPlayer = new Player(Console.ReadLine());
        }

        public void DecideNumberOfDays()
        {
            Console.WriteLine("How many days would you like to run your stand for?\nType 7 for 7 days.\nType 14 for 14 days.\nType 30 for 30 days.");
            numberOfDays = Convert.ToInt32(Console.ReadLine());
        }
    }
}