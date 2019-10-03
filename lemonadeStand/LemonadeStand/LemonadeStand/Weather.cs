using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        // variables
        public string condition;
        public int temperature;
        private List<string> weatherConditions;
        public List<int> monthForeCast;
        public List<int> monthTemperatures;
        public string predictedForecast;
        static Random rng = new Random(DateTime.Now.Millisecond);
        public Weather()
        {
            weatherConditions = new List<string>() { "Partly shitty", "Mostly shitty", "Increasingly shitty", "Shitty", "Overcast with shitty", "Shitty Thunderstorms", "Raining Shitty Cats and Dogs" };
            monthForeCast = new List<int>();
            monthTemperatures = new List<int>();
        }

        // methods
        public string DailyForecast(int currentDay)  //single responsibility principle
        {
            
            return weatherConditions[monthForeCast[currentDay - 1]];
        }

        public int DailyForecastNumber(int currentDay)  //single responsibility principle
        {
            return monthForeCast[currentDay - 1];
        }

        public int DailyTemperature(int currentDay)  //single responsibility principle
        {
            return monthTemperatures[currentDay - 1];
        }

        public void SevenDayForecast(int currentDay)
        {
            Console.Clear();
            Console.WriteLine("This is the NOAA weather console report seven day outlook.");
            Console.WriteLine("The weather for the next seven days is as follows:");
            Console.WriteLine();
            Console.WriteLine("Today: " + weatherConditions[monthForeCast[currentDay - 1]] + " with a high of " + monthTemperatures[currentDay - 1]);
            Console.WriteLine("Tomorrow: " + weatherConditions[monthForeCast[currentDay]] + " with a high of " + monthTemperatures[currentDay]);
            Console.WriteLine("In two days: " + weatherConditions[monthForeCast[currentDay + 1]] + " with a high of " + monthTemperatures[currentDay + 1]);
            Console.WriteLine("In three days: " + weatherConditions[monthForeCast[currentDay + 2]] + " with a high of " + monthTemperatures[currentDay + 2]);
            Console.WriteLine("In four days: " + weatherConditions[monthForeCast[currentDay + 3]] + " with a high of " + monthTemperatures[currentDay + 3]);
            Console.WriteLine("In five days: " + weatherConditions[monthForeCast[currentDay + 4]] + " with a high of " + monthTemperatures[currentDay + 4]);
            Console.WriteLine("In six days: " + weatherConditions[monthForeCast[currentDay + 5]] + " with a high of " + monthTemperatures[currentDay + 5]);
            Console.WriteLine();
            Console.WriteLine("Press enter to return to store");
            Console.ReadLine();
        }
        
        public void CreateTemperature()
        {
            for (int i = 0; i < 37; i++)
            {
                int temp = rng.Next(40, 100);
                monthTemperatures.Add(temp);
            }
        }
        public void CreateWeather()
        {
            for (int i = 0; i < 37; i++)
            {
                int randomNumber = rng.Next(1, 100);
                if (randomNumber < 20)
                {
                    monthForeCast.Add(0);
                }
                if (randomNumber < 40 && randomNumber > 19)
                {
                    monthForeCast.Add(1);
                }
                if (randomNumber < 60 && randomNumber > 39)
                {
                    monthForeCast.Add(2);
                }
                if (randomNumber < 80 && randomNumber > 59)
                {
                    monthForeCast.Add(3);
                }
                if (randomNumber < 95 && randomNumber > 79)
                {
                    monthForeCast.Add(4);
                }
                if (randomNumber < 98 && randomNumber > 94)
                {
                    monthForeCast.Add(5);
                }
                if (randomNumber < 100 && randomNumber > 97)
                {
                    monthForeCast.Add(6);
                }
            }
        }
    }
}
