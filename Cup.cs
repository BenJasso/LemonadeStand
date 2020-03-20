using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Cup : Item
    {
        // member variables (HAS A)
        public double price;

        // constructor (SPAWNER)
        public Cup()
        {
            name = "cup";
        }

        // member methods (CAN DO)
        public void AssignPrice(string quantity)
        {
            if (quantity == "25")
            {
                price = 0.75;
            }
            else if (quantity == "50")
            {
                price = 1.50;
            }
            else if (quantity == "100")
            {
                price = 2.89;
            }
            else
            {
                Console.WriteLine("Not a valid option.");
            }
        }
    }
}
