﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Program
    {

        static void Main(string[] args)
        {
            Game lemonadeGame = new Game();
            lemonadeGame.RunGame();
            lemonadeGame.CreatePlayer();
        }
           
       
    }
}