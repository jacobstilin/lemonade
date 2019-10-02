using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        // variable
        public int ammountOfLemons;
        public int ammountOfSugarCubes;
        public int ammountOfIceCubes;
        public double pricePerCup;
        

        // constructor
        public Recipe()
        {
            
            ammountOfIceCubes = 6;
            ammountOfSugarCubes = 6;
            ammountOfLemons = 10;
            pricePerCup = .50;

        }

        // methods
        public void RecipeMenu(int currentDay, double money, string forecast, int temp, Inventory inventory)
        {
            Console.Clear();
            UserInterface.MenuReadout(currentDay, money, forecast, temp);
            UserInterface.DisplayInventory(inventory);
            UserInterface.DisplayRecipe(ammountOfSugarCubes, ammountOfLemons, ammountOfIceCubes, pricePerCup);
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "change":
                    ChangeRecipe(currentDay, money, forecast, temp, inventory);
                    break;
                case "proceed":
                    break;
                default:
                    break;
            }
            
            
        }

        
        public void ChangeRecipe(int currentDay, double money, string forecast, int temp, Inventory inventory)
        {
            Console.Clear();
            UserInterface.MenuReadout(currentDay, money, forecast, temp);
            UserInterface.DisplayInventory(inventory);
            UserInterface.DisplayRecipe(ammountOfSugarCubes, ammountOfLemons, ammountOfIceCubes, pricePerCup);

            Console.WriteLine("Enter 'sugar cubes', 'lemons', 'ice cubes', 'price' or 'go back'.");
            string choice = Console.ReadLine();
            
                switch (choice)
                {
                    case "go back":
                        RecipeMenu(currentDay, money, forecast, temp, inventory);
                        break;
                    case "sugar cubes":
                        ChangeSugarCubes();
                        ChangeRecipe(currentDay, money, forecast, temp, inventory);
                        break;
                    case "lemons":
                        ChangeLemons();
                        ChangeRecipe(currentDay, money, forecast, temp, inventory);
                        break;
                    case "ice cubes":
                        ChangeIceCubes();
                        ChangeRecipe(currentDay, money, forecast, temp, inventory);
                        break;
                    case "price":
                        ChangePrice();
                        ChangeRecipe(currentDay, money, forecast, temp, inventory);
                        break;
                default:
                        ChangeRecipe(currentDay, money, forecast, temp, inventory);
                        break;
                }
        }
        public void ChangePrice()
        {
            Console.WriteLine("Raise or lower price?");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "raise":
                    Console.WriteLine("By how much would you like to raise the price?");
                    double choice2 = double.Parse(Console.ReadLine());
                    pricePerCup += choice2;
                    break;
                case "lower":
                    Console.WriteLine("By how much would you like to lower the price?");
                    double choice3 = double.Parse(Console.ReadLine());
                    pricePerCup -= choice3;
                    break;
            }
        }
        public void ChangeSugarCubes()
        {
            Console.WriteLine("Add or subtract sugar cubes?");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "add":
                    Console.WriteLine("How many would you like to add?");
                    int choice2 = Int32.Parse(Console.ReadLine());
                    ammountOfSugarCubes += choice2;
                    break;
                case "subtract":
                    Console.WriteLine("How many would you like to subtract?");
                    int choice3 = Int32.Parse(Console.ReadLine());
                    ammountOfSugarCubes -= choice3;
                    break;
            }
        }

        public void ChangeLemons()
        {
            Console.WriteLine("Add or subtract lemons?");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "add":
                    Console.WriteLine("How many would you like to add?");
                    int choice2 = Int32.Parse(Console.ReadLine());
                    ammountOfLemons += choice2;
                    break;
                case "subtract":
                    Console.WriteLine("How many would you like to subtract?");
                    int choice3 = Int32.Parse(Console.ReadLine());
                    ammountOfLemons -= choice3;
                    break;
            }
        }

        public void ChangeIceCubes()
        {
            Console.WriteLine("Add or subtract ice cubes?");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "add":
                    Console.WriteLine("How many would you like to add?");
                    int choice2 = Int32.Parse(Console.ReadLine());
                    ammountOfIceCubes += choice2;
                    break;
                case "subtract":
                    Console.WriteLine("How many would you like to subtract?");
                    int choice3 = Int32.Parse(Console.ReadLine());
                    ammountOfIceCubes -= choice3;
                    break;
            }
        }

    }
}
