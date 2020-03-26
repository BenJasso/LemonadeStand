using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Player
    {
        // member variables (HAS A)
        public Inventory inventory;
        public Wallet wallet;
        public string name;

        // constructor (SPAWNER)
        public Player(string name)
        {
            inventory = new Inventory();
            wallet = new Wallet();
            this.name = name;
        }

        // member methods (CAN DO)
        public void addProfit(List<CupOfLemonade> list, double price)
        {
            double profit = list.Count * price;
            Console.WriteLine($"Your profit for the day was:{profit}");
            wallet.money += profit;
        }

        
    }
}
