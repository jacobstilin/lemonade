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
            
            UserInterface.Introduction();
            UserInterface.DisplayInstructions();
            totalDays = DaysSelector();
            weather.CreateWeather();
            weather.CreateTemperature();
            
            
            for (currentDay = 1; currentDay <= totalDays; currentDay++)
            {
                Store store = new Store(player);
                store.PurchasingMenu(currentDay, player.wallet.GetMoney(), weather.DailyForecast(currentDay), weather.DailyTemperature(currentDay));
                Console.WriteLine("aow it's the day time");
                RunDay();
                Console.ReadLine();
            }
        }

        public void RunDay()
        {
            for (int i = 0; i < 25; i++)
            {
                if (player.pitcher.CupsInPitcher() == 0)
                {
                    bool enough = player.CreatePitcher(player.recipe.ammountOfSugarCubes, player.recipe.ammountOfLemons, player.inventory.lemons.Count, player.inventory.sugarCubes.Count);
                    if (enough == true)
                    {
                        player.pitcher.FillPitcher();
                        Console.WriteLine("New pitcher mixed up");
                    }
                    else
                    {
                        break;
                    }
                }
                Customer customer = new Customer();
                
                if (customer.ChanceToBuy(weather.DailyForecastNumber(currentDay), weather.DailyTemperature(currentDay)) == true)
                {
                    Console.WriteLine(customer.GetName(i) + " buys!");
                }
            }
            player.inventory.IceMelts();
            player.pitcher.DumpPitcher();
            Console.ReadLine();   

        }

        public void CupPurchased()
        {

        }
        
        public int DaysSelector() // fix if user just pushes enter
        {
            Console.Clear();
            int days = 1;
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

        
    }
}
