using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Customer
    {

        //member variables
        public int purchasePercentage;
        Random RandomGen;


        //constructor
        public Customer()
        {
            RandomGen = new Random();
        }

        //member methods
        public void CustomersPurchases(Weather weather, double price, List<CupOfLemonade> CupsofLemonade, Inventory inventory, CupOfLemonade cupOfLemonade, Customer customer, bool decision)
        {
            int randomValueBetween0And99 = customer.RandomGen.Next(100);
            
            
            //determine chances of purchase
            if (weather.forecast == "Sunny")
                {
                    if (weather.weatherDegree >= 80)
                    {
                        if (price <= 0.30)
                        {
                            purchasePercentage = 90;
                        }
                        else if (price > 0.30 && price <= 0.45)
                        {
                            purchasePercentage = 70;
                        }
                        else if (price > 0.45 && price <= 0.70)
                        {
                            purchasePercentage = 50;
                        }
                        else
                        {
                            purchasePercentage = 20;
                        }
                    }
                    else if (weather.weatherDegree < 80 && weather.weatherDegree >= 70)
                    {
                        if (price <= 0.30)
                        {
                            purchasePercentage = 80;
                        }
                        else if (price > 0.30 && price <= 0.45)
                        {
                            purchasePercentage = 60;
                        }
                        else if (price > 0.45 && price <= 0.70)
                        {
                            purchasePercentage = 40;
                        }
                        else
                        {
                            purchasePercentage = 3;
                        }
                    }
                    else
                    {
                        if (price <= 0.30)
                        {
                            purchasePercentage = 70;
                        }
                        else if (price > 0.30 && price <= 0.45)
                        {
                            purchasePercentage = 40;
                        }
                        else if (price > 0.45 && price <= 0.70)
                        {
                            purchasePercentage = 25;
                        }
                        else
                        {
                            purchasePercentage = 3;
                        }
                    }
                }
                
                if (weather.forecast == "Rain")
                {
                    if (weather.weatherDegree >= 80)
                    {
                        if (price <= 0.30)
                        {
                            purchasePercentage = 75;
                        }
                        else if (price > 0.30 && price <= 0.45)
                        {
                            purchasePercentage = 65;
                        }
                        else if (price > 0.45 && price <= 0.70)
                        {
                            purchasePercentage = 40;
                        }
                        else
                        {
                            purchasePercentage = 3;
                        }
                    }
                    else if (weather.weatherDegree < 80 && weather.weatherDegree >= 70)
                    {
                        if (price <= 0.30)
                        {
                            purchasePercentage = 70;
                        }
                        else if (price > 0.30 && price <= 0.45)
                        {
                            purchasePercentage = 55;
                        }
                        else if (price > 0.45 && price <= 0.70)
                        {
                            purchasePercentage = 35;
                        }
                        else
                        {
                            purchasePercentage = 3;
                        }
                    }
                    else
                    {
                        if (price <= 0.30)
                        {
                            purchasePercentage = 50;
                        }
                        else if (price > 0.30 && price <= 0.45)
                        {
                            purchasePercentage = 40;
                        }
                        else if (price > 0.45 && price <= 0.70)
                        {
                            purchasePercentage = 20;
                        }
                        else
                        {
                            purchasePercentage = 5;
                        }
                    }
                }
            if (randomValueBetween0And99 < purchasePercentage && inventory.lemons.Count >= cupOfLemonade.amountOfLemon && inventory.sugarCubes.Count >= cupOfLemonade.amountOfSugar && inventory.cups.Count >= 1 && inventory.iceCubes.Count >= cupOfLemonade.amountOfIce)
            {
                CupsofLemonade.Add(cupOfLemonade);
                decision = true;

            }
            if (decision == true)
            {
                inventory.lemonsUsedCounter += cupOfLemonade.amountOfLemon;
                if(inventory.lemonsUsedCounter >= 1)
                {
                    inventory.lemons.RemoveAt(0);
                    inventory.lemonsUsedCounter -= 1;
                }
                for (int i = 0; i < cupOfLemonade.amountOfIce; i++)
                {
                    inventory.iceCubes.RemoveAt(0);
                }
                for (int i = 0; i < cupOfLemonade.amountOfSugar; i++)
                {
                    inventory.sugarCubes.RemoveAt(0);
                }
                inventory.cups.RemoveAt(0);
            }






        }

    }
    
}
