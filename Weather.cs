using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{

    public class Weather
    {
        //Member Variables
        public Random random = new Random();
        public List<string> forecasts = new List<string> { "Rain", "Sunny" };
        public int weatherDegree;
        public string forecast;


        //Constructor

        public Weather()
        {

            weatherDegree = random.Next(65, 100);

            int index = random.Next(forecasts.Count);
            forecast = forecasts[index];




        }

        public void DisplayWeather()
        {
            Console.WriteLine($"Degrees:{weatherDegree} \nForecast:{forecast}");
        }



    }


}
