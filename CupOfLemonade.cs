using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class CupOfLemonade
    {

        //member variables
        public double amountOfSugar;
        public double amountOfIce;
        public double amountOfLemon;
        public double amountOfCups = 1;
        public int price;

        //constructor

        //member methods
        public void MakeRecipe()
        {
            Console.WriteLine("Please make a recipe for your lemonade per cup.\n\nHow many sugar cubes?(please type a number)");
            amountOfSugar = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How much of a lemon?(use decimals to represent how much a lemon):");
            amountOfLemon = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many ice cubes?(please type a number)");
            amountOfIce = Convert.ToDouble(Console.ReadLine());
        }

    }
}
