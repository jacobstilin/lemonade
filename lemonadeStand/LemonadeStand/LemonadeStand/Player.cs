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
        // constructor
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
            pitcher = new Pitcher();
        }

        public bool PitcherCheck()
        {
            if (pitcher.CupsInPitcher() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IngredientsCheck()
        {
                bool enough = CreatePitcher(recipe.ammountOfSugarCubes, recipe.ammountOfLemons, inventory.lemons.Count, inventory.sugarCubes.Count);
                if (enough == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
        }



        public bool CreatePitcher(int sugarCubes, int lemons, int sugarCubesInInv, int lemonsInInv)  //single responsibility principle
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

        public bool CreateLemonadeCup(int iceCubes, int iceCubesInInv, int cupsInInv)  //single responsibility principle
        {
            if (iceCubesInInv >= iceCubes && cupsInInv > 0)
            {
                inventory.RemoveItems("ice cubes", iceCubes);
                inventory.RemoveItems("cups", 1);
                return true;
            }
            else
            {
                Console.WriteLine("Not enough materials to sell another cup.");
                return false;
            }
        }
    }
}
