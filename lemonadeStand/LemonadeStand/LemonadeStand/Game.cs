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
        public double satisfaction;

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
            Customer customer = new Customer();

            for (currentDay = 1; currentDay <= totalDays; currentDay++)
            {
                Store store = new Store(player, weather);
                startMoney = player.wallet.GetMoney();
                KickUp(currentDay);
                bool bankrupt = store.PurchasingMenu(currentDay, player.wallet.GetMoney(), weather.DailyForecast(currentDay), weather.DailyTemperature(currentDay));
                if (bankrupt == true)
                {
                    bankruptGains = Bankrupt(player.wallet.GetMoney(), player.inventory.lemons.Count, player.inventory.sugarCubes.Count);
                    break;
                }
                RunDay(currentDay, player.wallet.GetMoney(), weather.DailyForecast(currentDay), weather.DailyTemperature(currentDay), customer);
                
            }
            finalMoney = player.wallet.GetMoney();
            UserInterface.FinalMoney(bankruptGains, finalMoney);
        }

        public void RunDay(int currentDay, double money, string forecast, int temp, Customer customer)
        {
            UserInterface.MenuReadout(currentDay, money, forecast, temp);
            UserInterface.DisplayInventory(player.inventory);
            satisfaction = customer.GetSatisfaction();

            for (int i = 0; i < customer.names.Count; i++)
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

                double customerWhim = rng.Next(1, 5);

                if (customer.ChanceToBuy(weather.DailyForecastNumber(currentDay), weather.DailyTemperature(currentDay), customerWhim, satisfaction) == true)
                {
                    
                    bool enough = player.CreateLemonadeCup(player.recipe.ammountOfIceCubes, player.inventory.iceCubes.Count, player.inventory.cups.Count);
                    if (enough == true)
                    {
                        Console.WriteLine(customer.GetName(i) + " buys!");
                        player.wallet.GainMoney(player.recipe.pricePerCup);
                        player.pitcher.SellCups(1);
                        customer.ChangeSatisfaction(player.recipe.ammountOfIceCubes, player.recipe.ammountOfLemons, player.recipe.ammountOfSugarCubes, player.recipe.pricePerCup, weather.DailyTemperature(currentDay));
                        satisfaction = customer.GetSatisfaction();
                    }
                    else
                    {
                        Console.ReadLine();
                           
                        break;
                    }
                }
            }
            double endMoney = player.wallet.GetMoney();
            player.wallet.GetDailyGains(startMoney, endMoney);
            player.wallet.GetTotalGains();
            player.inventory.IceMelts();
            player.pitcher.DumpPitcher();
            player.inventory.LemonsExpire(currentDay);
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();   
        }

        public double Bankrupt(double money, int lemons, int sugarCubes)
        {
            double lemonsPayout = (lemons * .01);
            double sugarCubesPayout = (sugarCubes * .01);
            double finalMoney = (lemonsPayout + sugarCubesPayout + 7);
            
            UserInterface.Bankrupt(lemonsPayout, sugarCubesPayout);
            return finalMoney;
        }
        
        public int DaysSelector() // fix if user just pushes enter
        {
            Console.Clear();
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

        public void KickUp(int day)
        {
            if (day % 7 == 1 && day != 1)
            {
                double cash = player.wallet.GetMoney();
                if (cash >= 5)
                {
                    player.wallet.LoseMoney(5);
                    Console.WriteLine("You kick up $5 to your crew chief.");
                    Console.ReadLine();
                }
                else if (cash < 5)
                {
                    Console.WriteLine("You don't have enough to kick up this week and get your ass kicked");
                    Console.WriteLine("Next time there won't be a next time.");
                    Console.WriteLine("Press enter to proceed.");
                    Console.ReadLine();
                }
            }
        }
    }
}
