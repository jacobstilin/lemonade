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
            Console.WriteLine("Here is some rules for you to follow");
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
