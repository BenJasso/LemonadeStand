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

        public void deductInventory(List<CupOfLemonade> list, Inventory inventory)
            
        {
            CupOfLemonade cupOfLemonade = new CupOfLemonade();
            double TotalLemonsUsed = Math.Round((cupOfLemonade.amountOfLemon * list.Count), 0);
            double TotalCupsUsed = Math.Round((cupOfLemonade.amountOfCups * list.Count), 0);
            double TotalSugarUsed = Math.Round((cupOfLemonade.amountOfSugar * list.Count), 0);
            double TotalIceUsed = Math.Round((cupOfLemonade.amountOfIce * list.Count), 0);

            for (int i = 0; i < TotalLemonsUsed; i++)
            {
                if (inventory.lemons.Count > 0)
                    inventory.lemons.RemoveAt(0);
            }
            for (int i = 0; i < TotalCupsUsed; i++)
            {
                if (inventory.cups.Count > 0)
                    inventory.cups.RemoveAt(0);
            }
            for (int i = 0; i < TotalSugarUsed; i++)
            {
                if (inventory.sugarCubes.Count > 0)
                    inventory.sugarCubes.RemoveAt(0);
            }
            for (int i = 0; i < 1000; i++)
            {
                if(inventory.iceCubes.Count > 0)
                inventory.iceCubes.RemoveAt(0);
            }

            
        }
    }
}
