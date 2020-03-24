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

        //constructor


        //member methods
        public void CustomersPurchases(Weather weather, double price, List<CupOfLemonade> CupsofLemonade, Inventory inventory)
        {
            double lemonsUsed = inventory.lemons.Count;
            double iceCubesUsed = inventory. iceCubes.Count;
            double sugarUsed = inventory.sugarCubes.Count;
            double cupsUsed = inventory.cups.Count;

            
            


                Random RandomGen = new Random();


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
                            purchasePercentage = 15;
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
                            purchasePercentage = 15;
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
                            purchasePercentage = 15;
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
                            purchasePercentage = 15;
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



                for (int i = 1; i < 200; i++)
                {


                    while (lemonsUsed > 1 && cupsUsed > 1 && inventory.sugarCubes.Count > 1 && inventory.iceCubes.Count > 3)
                    {

                        int randomValueBetween0And99 = RandomGen.Next(100);
                        CupOfLemonade cupLemonade = new CupOfLemonade();
                        if (randomValueBetween0And99 < purchasePercentage)
                        {
                            lemonsUsed -= cupLemonade.amountOfLemon;
                            cupsUsed -= cupLemonade.amountOfCups;
                            sugarUsed -= cupLemonade.amountOfSugar;
                            iceCubesUsed -= cupLemonade.amountOfIce;

                            CupsofLemonade.Add(cupLemonade);

                        }
                    }
                }

        }

    }
    
}
