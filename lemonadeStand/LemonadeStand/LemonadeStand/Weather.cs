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
        public string DailyForecast(int currentDay)
        {
            
            return weatherConditions[monthForeCast[currentDay - 1]];
        }

        public int DailyForecastNumber(int currentDay)
        {
            return monthForeCast[currentDay];
        }

        public int DailyTemperature(int currentDay)
        {
            return monthTemperatures[currentDay];
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
                    monthForeCast.Add(1);
                }
                if (randomNumber < 40 && randomNumber > 19)
                {
                    monthForeCast.Add(2);
                }
                if (randomNumber < 60 && randomNumber > 39)
                {
                    monthForeCast.Add(3);
                }
                if (randomNumber < 80 && randomNumber > 59)
                {
                    monthForeCast.Add(4);
                }
                if (randomNumber < 95 && randomNumber > 79)
                {
                    monthForeCast.Add(5);
                }
                if (randomNumber < 98 && randomNumber > 94)
                {
                    monthForeCast.Add(6);
                }
                if (randomNumber < 100 && randomNumber > 97)
                {
                    monthForeCast.Add(7);
                }
            }
        }
    }
}
