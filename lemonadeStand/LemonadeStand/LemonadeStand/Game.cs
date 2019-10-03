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
        public double finalMoney;
        public double bankruptGains;
        public double startMoney;
        static Random rng = new Random(DateTime.Now.Millisecond);

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
                Store store = new Store(player, weather);
                startMoney = player.wallet.GetMoney();
                bool bankrupt = store.PurchasingMenu(currentDay, player.wallet.GetMoney(), weather.DailyForecast(currentDay), weather.DailyTemperature(currentDay));
                if (bankrupt == true)
                {
                    bankruptGains = Bankrupt(player.wallet.GetMoney(), player.inventory.lemons.Count, player.inventory.sugarCubes.Count);
                    break;
                }
                RunDay(currentDay, player.wallet.GetMoney(), weather.DailyForecast(currentDay), weather.DailyTemperature(currentDay));
                
            }
            finalMoney = player.wallet.GetMoney();
            Console.WriteLine("Your final money is $" + (bankruptGains + finalMoney));
        }

        public void RunDay(int currentDay, double money, string forecast, int temp)
        {
            UserInterface.MenuReadout(currentDay, money, forecast, temp);
            UserInterface.DisplayInventory(player.inventory);
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
                double customerWhim = rng.Next(1, 5);

                if (customer.ChanceToBuy(weather.DailyForecastNumber(currentDay), weather.DailyTemperature(currentDay), customerWhim) == true)
                {
                    
                    bool enough = player.CreateLemonadeCup(player.recipe.ammountOfIceCubes, player.inventory.iceCubes.Count);
                    if (enough == true)
                    {
                        Console.WriteLine(customer.GetName(i) + " buys!");

                        

                        player.wallet.GainMoney(player.recipe.pricePerCup);
                        player.pitcher.SellCups(1);
                    }
                    else
                    {
                        break;
                    }
                    
                    
                }
            }
            double endMoney = player.wallet.GetMoney();
            player.wallet.GetDailyGains(startMoney, endMoney);
            player.wallet.GetTotalGains();
            player.inventory.IceMelts();
            player.pitcher.DumpPitcher();
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();   

        }
        public double Bankrupt(double money, int lemons, int sugarCubes)
        {
            double lemonsPayout = (lemons * .01);
            double sugarCubesPayout = (sugarCubes * .01);
            
                Console.WriteLine("You have elected to file for bankruptcy. Creditors are on their way...");
                Console.WriteLine("You receive $" + lemonsPayout + " for your remaining lemons.");
                Console.WriteLine("You receive $" + sugarCubesPayout + " for your remaining sugar cubes.");
                Console.WriteLine("Ya mother gives you $7 because she feels bad");
                double finalMoney = (lemonsPayout + sugarCubesPayout + 7);
                Console.WriteLine();
            return finalMoney;
            
            
        }
        public void CupPurchased()
        {
            
        }
        
        public int DaysSelector() // fix if user just pushes enter
        {
            
            int days = 1;

            Console.WriteLine("How many days will this game last? Please enter a number between 7 and 30.");
            do
            {
                
                
                string result = Console.ReadLine();
                while(!Int32.TryParse(result, out days))
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a valid number between 7 and 30.");
                    result = Console.ReadLine();
                }
                days = Int32.Parse(result);

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
