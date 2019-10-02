using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        // variable
        public string name;
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public Pitcher pitcher;
        public double businessProfits;

        // constructor
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
            pitcher = new Pitcher();
        }

        // methods
        
        public bool CreatePitcher(int sugarCubes, int lemons, int sugarCubesInInv, int lemonsInInv)
        {
            if (sugarCubesInInv >= sugarCubes && lemonsInInv >= lemons)
            {
                inventory.RemoveItems("sugar cubes", sugarCubes);
                inventory.RemoveItems("lemons", lemons);
                return true;
            }
            else
            {
                Console.WriteLine("Out of ingredients.");
                return false;
            }
        }

        public bool CreateLemonadeCup(int iceCubes, int iceCubesInInv)
        {
            if (iceCubesInInv >= iceCubes)
            {
                inventory.RemoveItems("ice cubes", iceCubes);


                    return true;
            }
            else
            {
                Console.WriteLine("Out of ice cubes");
                return false;
            }
        }
    }
}
