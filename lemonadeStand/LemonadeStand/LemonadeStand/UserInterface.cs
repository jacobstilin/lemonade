using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    static class UserInterface
    {
        
        
        public static void Introduction()
        {
            Console.WriteLine("Welcome to Lemonade Stand.");
            Console.WriteLine();
            Console.WriteLine("Developed by Jacob Stilin.");
            Console.WriteLine();
            Console.WriteLine("Press Enter to begin.");
            Console.ReadLine();
        }
        public static void DisplayInstructions()
        {
            Console.Clear();
            Console.WriteLine("Now that you are nine years old, you have been given the corner of 5th and Maple to move lemonade.");
            Console.WriteLine("All you have to worry about now is kicking up five dollars to your crew chief once a week. To run");
            Console.WriteLine("a profitable lemonade stand, you must sell a lot of lemonade while keeping overhead down. Before");
            Console.WriteLine("you set up shop each day, stop by the store to re-up on supplies. Stay stocked with enough lemons,");
            Console.WriteLine("sugar cubes, cups and ice to make it though the day. Remember, ice melts at the end of each day,");
            Console.WriteLine("lemons go bad after three days and you have to dump out the lemonade you don't sell at the end of");
            Console.WriteLine("the day. Check the weather and temperature each day and adjust your pricing and recipe accordingly.");
            Console.WriteLine("Keep customers happy with cheap, sugary and lemony lemonade. On a hot day, use ice! You can also");
            Console.WriteLine("check the seven day forecast for an idea of what is to come. If you sell good product, customers");
            Console.WriteLine("will be more likely to buy, so it may be prudent to put out testers the first few days.");
            Console.WriteLine();
            Console.WriteLine("Good luck!");
            Console.WriteLine();
            Console.WriteLine("Press Enter to proceed");
            Console.ReadLine();
        }

        public static void MenuReadout(int currentDay, double money, string forecast, int temp)
        {
            Console.Clear();
            // displays day, money, high temp, weather forecast for day
            Console.WriteLine("Day: " + currentDay + "       Money: " + money + "       Weather: " + forecast + "       Temperature: " + temp);

        }
        public static void DisplayInventory(Inventory inventory)
        {
            Console.WriteLine();
            Console.WriteLine("You have: ");
            inventory.DisplayItems();
            Console.WriteLine();
        }

        public static void DisplayRecipe(int ammountOfSugarCubes, int ammountOfLemons, int ammountOfIceCubes, double pricePerCup)
        {
            Console.WriteLine("Your current lemonade recipe:");
            Console.WriteLine("Sugar cubes per pitcher: " + ammountOfSugarCubes);
            Console.WriteLine("Lemons per pitcher: " + ammountOfLemons);
            Console.WriteLine("Ice cubes per cup: " + ammountOfIceCubes);
            Console.WriteLine("Price per cup: " + pricePerCup);
            Console.WriteLine();
            Console.WriteLine("To change recipe, enter 'change'.");
            Console.WriteLine("Enter 'proceed' to start the day");
        }

        public static void FinalMoney(double bankruptGains, double finalMoney)
        {
            Console.WriteLine("Your final money is $" + (bankruptGains + finalMoney));
        }

        public static void Bankrupt(double lemonsPayout, double sugarCubesPayout)
        {
            Console.WriteLine("You have elected to file for bankruptcy. Creditors are on their way...");
            Console.WriteLine("You receive $" + lemonsPayout + " for your remaining lemons.");
            Console.WriteLine("You receive $" + sugarCubesPayout + " for your remaining sugar cubes.");
            Console.WriteLine("Ya mother gives you $7 because she feels bad");
            Console.WriteLine();
        }
    }
}
