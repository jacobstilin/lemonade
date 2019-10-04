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
        public double satisfactionMultiplier;

        // constructor
        public Game()
        {
            days = new List<Day>();
            currentDay = 0;
            satisfaction = 1;
            CreateDay();
            
        }

        // methods
        public void StartGame()
        {
            
            UserInterface.Introduction();
            UserInterface.DisplayInstructions();
            totalDays = DaysSelector();
            

            for (currentDay = 0; currentDay < totalDays; currentDay++)
            {
                Store store = new Store(player, weather);
                Day day = days[currentDay];
                startMoney = player.wallet.GetMoney();
                KickUp(currentDay);
                bool bankrupt = store.PurchasingMenu(currentDay, player.wallet.GetMoney(), day.weather.condition, day.weather.temperature, day);
                if (bankrupt == true)
                {
                    bankruptGains = Bankrupt(player.wallet.GetMoney(), player.inventory.lemons.Count, player.inventory.sugarCubes.Count);
                    break;
                }

                RunDay(currentDay, player.wallet.GetMoney(), day.weather.condition, day.weather.temperature, day);
                
            }
            finalMoney = player.wallet.GetMoney();
            UserInterface.FinalMoney(bankruptGains, finalMoney);
        }

        public void RunDay(int currentDay, double money, string forecast, int temp, Day day)
        {
            UserInterface.MenuReadout(currentDay, money, forecast, temp);
            UserInterface.DisplayInventory(player.inventory);
            

            for (int i = 0; i < day.customers.Count; i++)
            {
                if (player.PitcherCheck() == true)
                {
                    bool enough = player.IngredientsCheck();
                    if (enough == true)
                    {
                        player.pitcher.FillPitcher();
                    }
                    else
                    {
                        break;
                    }
                }
                
                
                if (day.customers[i].ChanceToBuy(day.weather.conditionInt, day.weather.temperature, satisfaction) == true)
                {
                    
                    bool enough = player.CreateLemonadeCup(player.recipe.ammountOfIceCubes, player.inventory.iceCubes.Count, player.inventory.cups.Count);
                    if (enough == true)
                    {
                        Console.WriteLine(day.customers[i].name + " buys!");
                        player.wallet.GainMoney(player.recipe.pricePerCup);
                        player.pitcher.SellCups(1);
                        ChangeSatisfaction(player.recipe.ammountOfIceCubes, player.recipe.ammountOfLemons, player.recipe.ammountOfSugarCubes, player.recipe.pricePerCup, day.weather.temperature);
                        Console.WriteLine(satisfaction);
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

        public void CreateDay()
        {
            for (int i = 0; i < 37; i++)
            {
                Day day = new Day(rng);
                days.Add(day);
            }
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

        public void ChangeSatisfaction(int ice, int lemons, int sugar, double price, int temp)
        {
            double change = 0;
            if (ice < 3 && temp < 70)
            {
                change += .005;
            }
            else if (ice > 3 && temp > 70)
            {
                change += .005;
            }
            else
            {
                change -= .01;
            }
            if (lemons >= 10)
            {
                change += .005;
            }
            else
            {
                change -= .005;
            }
            if (sugar >= 6)
            {
                change += .005;
            }
            else
            {
                change -= .005;
            }
            if (price == 0)
            {
                change += .02;
            }
            if (price <= 1 && price > 0)
            {
                change += .005;
            }
            else
            {
                change -= .005;
            }
            satisfaction += change;
        }
        
    }

}
