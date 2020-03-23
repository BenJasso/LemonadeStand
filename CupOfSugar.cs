using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class CupOfSugar : Item
    {
        // member variables (HAS A)
        public double price;
        // constructor (SPAWNER)
        public CupOfSugar()
        {
            
            name = "sugar cube";
        }

        // member methods (CAN DO)
        public void AssignPrice(string quantity)
        {
            if (quantity == "8")
            {
                price = 0.66;
            }
            else if(quantity == "20")
            {
                price = 1.63;
            }
            else if(quantity == "48")
            {
                price = 3.37;
            }
            else
            {
                Console.WriteLine("Not a valid option.");
            }
        }



    }


}
