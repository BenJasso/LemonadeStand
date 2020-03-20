using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Lemon : Item
    {
        // member variables (HAS A)
        public double price;
        // constructor (SPAWNER)
        public Lemon()
        {
            name = "lemon";
        }

        // member methods (CAN DO)
        public void AssignPrice(string quantity)
        {
            if (quantity == "10")
            {
                price = 0.67;
            }
            else if (quantity == "30")
            {
                price = 2.23;
            }
            else if (quantity == "75")
            {
                price = 4.05;
            }
            else
            {
                Console.WriteLine("Not a valid option.");
            }
        }
    }
}
