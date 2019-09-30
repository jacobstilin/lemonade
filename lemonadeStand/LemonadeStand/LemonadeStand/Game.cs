using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        // variables
        Player player = new Player();
        List<Day> days;
        Weather weather = new Weather();
        public static int currentDay;
        public int totalDays;

        // constructor
        public Game()
        {
            currentDay = 1;
        }

        // methods
        public void StartGame()
        {
            
            Introduction();
            DisplayInstructions();
            totalDays = DaysSelector();
            weather.CreateWeather();
            MenuReadout();
            
            for (currentDay = 1; currentDay <= totalDays; currentDay++)
            {
                Store store = new Store(player);
                store.DisplayStore();
            }
        }

        public void Introduction()
        {
            Console.WriteLine("Welcome to Lemonade Stand.");
            Console.WriteLine();
            Console.WriteLine("Developed by Jacob Stilin.");
            Console.WriteLine();
            Console.WriteLine("Press Enter to begin.");
            Console.ReadLine();
        }

        public void DisplayInstructions()
        {
            Console.Clear();
            Console.WriteLine("Here is some rules for you to follow");
            Console.WriteLine("Press Enter to proceed");
            Console.ReadLine();
        }

        public int DaysSelector()
        {
            Console.Clear();
            int days;
            do
            {
                
                Console.WriteLine("How many days will this game last? Please enter a number between 7 and 30.");
                days = Int32.Parse(Console.ReadLine());
                if (days < 7 || days > 30)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a valid number between 7 and 30.");
                }
            } while (days < 7 || days > 30);
            Console.WriteLine("This game will last " + days + " days.");
            Console.WriteLine("Press Enter to proceed.");
            Console.ReadLine();
            return days;
        }

        public void MenuReadout()
        {
            Console.Clear();
            // displays day, money, high temp, weather forecast for day
            Console.WriteLine("Day: " + currentDay + "       Money: " + player.wallet.GetMoney() + "       Weather: " + weather.DailyForecast());
            
            Console.WriteLine();

        }
    }
}
