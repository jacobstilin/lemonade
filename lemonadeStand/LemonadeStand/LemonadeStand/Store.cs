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
        
        // constructor
        public Store(Player player)
        {
            this.player = player;
            
        }

        // methods
        

        public void PurchasingMenu(int currentDay, double money, string forecast, int temp)
        {
            Console.Clear();
            UserInterface.MenuReadout(currentDay, money, forecast, temp);
            UserInterface.DisplayInventory(player.inventory);
            Console.WriteLine("Enter 'purchase', 'help', 'bankrupt' or 'proceed'");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "purchase":
                    Purchasing(currentDay, money, forecast, temp);
                    break;
                case "help":
                    UserInterface.DisplayInstructions();
                    PurchasingMenu(currentDay, money, forecast, temp);
                    break;
                case "bankrupt":
                    break;
                case "proceed":
                    QualityControl(currentDay, money, forecast, temp);
                    break;
                default:
                    PurchasingMenu(currentDay, money, forecast, temp);
                    break;
            }
        }

        public void Purchasing(int currentDay, double money, string forecast, int temp)
        {
            UserInterface.MenuReadout(currentDay, money, forecast, temp);
            UserInterface.DisplayInventory(player.inventory);
            Console.WriteLine("What would you like to purchase?");
            Console.WriteLine("Enter 'cups', 'lemons', 'sugar cubes', 'ice cubes' or 'go back'.");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "cups":
                    player.wallet.LoseMoney(BuyCups(money));
                    break;
                case "lemons":
                    player.wallet.LoseMoney(BuyLemons(money));
                    break;
                case "sugar cubes":
                    player.wallet.LoseMoney(BuySugarCubes(money));
                    break;
                case "ice cubes":
                    player.wallet.LoseMoney(BuyIceCubes(money));
                    break;
                case "go back":
                    break;
            }
            PurchasingMenu(currentDay, player.wallet.GetMoney(), forecast, temp);
        }

        public double BuyCups(double money)
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
                        player.inventory.AddItems("cups", 10);
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
                        player.inventory.AddItems("cups", 20);
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
                        player.inventory.AddItems("cups", 30);
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
        public double BuyLemons(double money)
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
                        player.inventory.AddItems("lemons", 10);
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
                        player.inventory.AddItems("lemons", 20);
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
                        player.inventory.AddItems("lemons", 30);
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
        public double BuySugarCubes(double money)
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
                        player.inventory.AddItems("sugar cubes", 10);
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
                        player.inventory.AddItems("sugar cubes", 20);
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
                        player.inventory.AddItems("sugar cubes", 30);
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
        public double BuyIceCubes(double money)
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
                        player.inventory.AddItems("ice cubes", 10);
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
                        player.inventory.AddItems("ice cubes", 20);
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
                        player.inventory.AddItems("ice cubes", 30);
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
