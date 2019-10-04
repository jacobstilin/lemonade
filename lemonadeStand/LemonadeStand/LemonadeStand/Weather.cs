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
        public int conditionInt;

        private List<string> weatherConditions;
       
        public string predictedForecast;
        static Random rng = new Random(DateTime.Now.Millisecond);
        public Weather()
        {
            weatherConditions = new List<string>() { "Partly shitty", "Mostly shitty", "Increasingly shitty", "Shitty", "Overcast with shitty", "Shitty Thunderstorms", "Raining Shitty Cats and Dogs" };
            CreateTemperature();
            CreateWeather();
            CreateForecast();
        }

        // methods
        private void CreateForecast()
        {

        }
        
        private void CreateTemperature()
        {
            temperature = rng.Next(40, 100);
        }
        private void CreateWeather()
        {
                int randomNumber = rng.Next(1, 100);
                if (randomNumber < 20)
                {
                    condition = weatherConditions[0];
                    conditionInt = 0;   
                }
                else if (randomNumber < 40 && randomNumber > 19)
                {
                    condition = weatherConditions[1];
                    conditionInt = 1;
                }
                else if (randomNumber < 60 && randomNumber > 39)
                {
                    condition = weatherConditions[2];
                    conditionInt = 2;
                }
                else if (randomNumber < 80 && randomNumber > 59)
                {
                    condition = weatherConditions[3];
                    conditionInt = 3;
                }
                else if (randomNumber < 95 && randomNumber > 79)
                {
                    condition = weatherConditions[4];
                    conditionInt = 4;
                }
                else if (randomNumber < 98 && randomNumber > 94)
                {
                    condition = weatherConditions[5];
                    conditionInt = 5;
                }
                else if (randomNumber < 100 && randomNumber > 97)
                {
                    condition = weatherConditions[6];
                    conditionInt = 6;
                }
            
        }
    }
}
