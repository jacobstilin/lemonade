using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        // variable
        Player player;
        Weather weather;

        // constructor
        public Store(Player player, Weather weather)
        {
            this.player = player;
            this.weather = weather;
        }

        // methods
        

        public bool PurchasingMenu(int currentDay, double money, string forecast, int temp, Day day)
        {
            Console.Clear();
            UserInterface.MenuReadout(currentDay, money, forecast, temp);
            UserInterface.DisplayInventory(player.inventory);
            Console.WriteLine("Enter 'purchase', 'help', 'bankrupt', 'forecast' or 'proceed'");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "purchase":
                    Purchasing(currentDay, money, forecast, temp, day);
                    break;
                case "help":
                    UserInterface.DisplayInstructions();
                    PurchasingMenu(currentDay, money, forecast, temp, day);
                    break;
                case "bankrupt":
                    return true;
                case "proceed":
                    QualityControl(currentDay, money, forecast, temp);
                    break;
                default:
                    PurchasingMenu(currentDay, money, forecast, temp, day);
                    break;
            }
            return false;
        }

        public void Purchasing(int currentDay, double money, string forecast, int temp, Day day)  // Open closed principle- code allows for more items to be added to store
        {
            UserInterface.MenuReadout(currentDay, money, forecast, temp);
            UserInterface.DisplayInventory(player.inventory);
            Console.WriteLine("What would you like to purchase?");
            Console.WriteLine("Enter 'cups', 'lemons', 'sugar cubes', 'ice cubes' or 'go back'.");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "cups":
                    player.wallet.LoseMoney(BuyCups(money, currentDay));
                    break;
                case "lemons":
                    player.wallet.LoseMoney(BuyLemons(money, currentDay));
                    break;
                case "sugar cubes":
                    player.wallet.LoseMoney(BuySugarCubes(money, currentDay));
                    break;
                case "ice cubes":
                    player.wallet.LoseMoney(BuyIceCubes(money, currentDay));
                    break;
                case "go back":
                    break;
            }
            PurchasingMenu(currentDay, player.wallet.GetMoney(), forecast, temp, day);
        }

        public double BuyCups(double money, int currentDay)  // Open closed principle- code allows easy modification of price and ammount purchased
        {
            int price;
            Console.WriteLine("Buy small, medium, large pack or none?");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "small":
                    price = 1;
                    if (price > money)
                    {
                        price = 0;
                        Console.WriteLine("Insufficient funds");
                        Console.ReadLine();
                    }
                    else
                    {
                        player.inventory.AddItems("cups", 10, currentDay);
                    }
                    break;
                case "medium":
                    price = 2;
                    if (price > money)
                    {
                        price = 0;
                        Console.WriteLine("Insufficient funds");
                        Console.ReadLine();
                    }
                    else
                    {
                        player.inventory.AddItems("cups", 25, currentDay);
                    }
                    break;
                case "large":
                    price = 3;
                    if (price > money)
                    {
                        price = 0;
                        Console.WriteLine("Insufficient funds");
                        Console.ReadLine();
                    }
                    else
                    {
                        player.inventory.AddItems("cups", 40, currentDay);
                    }
                    break;
                case "none":
                    price = 0;
                    break;
                default:
                    price = 0;
                    break;
            }
            return price;
        }
        public double BuyLemons(double money, int currentDay)  // Open closed principle- code allows easy modification of price and ammount purchased
        {
            int price;
            Console.WriteLine("Buy small, medium, large bag or none?");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "small":
                    price = 1;
                    if (price > money)
                    {
                        price = 0;
                        Console.WriteLine("Insufficient funds");
                        Console.ReadLine();
                    }
                    else
                    {
                        player.inventory.AddItems("lemons", 10, currentDay);
                    }
                    break;
                case "medium":
                    price = 2;
                    if (price > money)
                    {
                        price = 0;
                        Console.WriteLine("Insufficient funds");
                        Console.ReadLine();
                    }
                    else
                    {
                        player.inventory.AddItems("lemons", 22, currentDay);
                    }
                    break;
                case "large":
                    price = 3;
                    if (price > money)
                    {
                        price = 0;
                        Console.WriteLine("Insufficient funds");
                        Console.ReadLine();
                    }
                    else
                    {
                        player.inventory.AddItems("lemons", 35, currentDay);
                    }
                    break;
                case "none":
                    price = 0;
                    break;
                default:
                    price = 0;
                    break;
            }
            return price;
        }
        public double BuySugarCubes(double money, int currentDay)  // Open closed principle- code allows easy modification of price and ammount purchased
        {
            int price;
            Console.WriteLine("Buy small, medium, large box or none?");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "small":
                    price = 1;
                    if (price > money)
                    {
                        price = 0;
                        Console.WriteLine("Insufficient funds");
                        Console.ReadLine();
                    }
                    else
                    {
                        player.inventory.AddItems("sugar cubes", 10, currentDay);
                    }
                    break;
                case "medium":
                    price = 2;
                    if (price > money)
                    {
                        price = 0;
                        Console.WriteLine("Insufficient funds");
                        Console.ReadLine();
                    }
                    else
                    {
                        player.inventory.AddItems("sugar cubes", 22, currentDay);
                    }
                    break;
                case "large":
                    price = 3;
                    if (price > money)
                    {
                        price = 0;
                        Console.WriteLine("Insufficient funds");
                        Console.ReadLine();
                    }
                    else
                    {
                        player.inventory.AddItems("sugar cubes", 35, currentDay);
                    }
                    break;
                case "none":
                    price = 0;
                    break;
                default:
                    price = 0;
                    break;
            }
            return price;
        }
        public double BuyIceCubes(double money, int currentDay)  // Open closed principle- code allows easy modification of price and ammount purchased
        {
            int price;
            Console.WriteLine("Buy small, medium, large bag or none?");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "small":
                    price = 1;
                    if (price > money)
                    {
                        price = 0;
                        Console.WriteLine("Insufficient funds");
                        Console.ReadLine();
                    }
                    else
                    {
                        player.inventory.AddItems("ice cubes", 10, currentDay);
                    }
                    break;
                case "medium":
                    price = 2;
                    if (price > money)
                    {
                        price = 0;
                        Console.WriteLine("Insufficient funds");
                        Console.ReadLine();
                    }
                    else
                    {
                        player.inventory.AddItems("ice cubes", 25, currentDay);
                    }
                    break;
                case "large":
                    price = 3;
                    if (price > money)
                    {
                        price = 0;
                        Console.WriteLine("Insufficient funds");
                        Console.ReadLine();
                    }
                    else
                    {
                        player.inventory.AddItems("ice cubes", 50, currentDay);
                    }
                    break;
                case "none":
                    price = 0;
                    break;
                default:
                    price = 0;
                    break;
            }
            return price;
        }

        public void QualityControl(int currentDay, double money, string forecast, int temp)
        {
            Console.Clear();
            UserInterface.MenuReadout(currentDay, money, forecast, temp);
            UserInterface.DisplayInventory(player.inventory);
            Console.WriteLine();
            player.recipe.RecipeMenu(currentDay, money, forecast, temp, player.inventory);
        }

        
    }
}
