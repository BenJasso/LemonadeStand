using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class IceCube : Item
    {
        // member variables (HAS A)
        public double price;
        // constructor (SPAWNER)
        public IceCube()
        {
            name = "ice cube";
        }

        // member methods (CAN DO)
        public void AssignPrice(string quantity)
        {
            if (quantity == "100")
            {
                price = 0.94;
            }
            else if (quantity == "250")
            {
                price = 2.22;
            }
            else if (quantity == "500")
            {
                price = 3.62;
            }
            else
            {
                Console.WriteLine("Not a valid option.");
            }
        }
    }
}
