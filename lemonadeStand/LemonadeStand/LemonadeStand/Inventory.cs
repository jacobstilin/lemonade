using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        // variable
        public List<Cup> cups;
        public List<Lemon> lemons;
        public List<SugarCube> sugarCubes;
        public List<IceCube> iceCubes;
        // constructor
        public Inventory()
        {
            cups = new List<Cup>();
            lemons = new List<Lemon>();
            sugarCubes = new List<SugarCube>();
            iceCubes = new List<IceCube>();
        }

        // methods
        public void DisplayItems()
        {
            Console.WriteLine("Cups: " + cups.Count);
            Console.WriteLine("Lemons: " + lemons.Count);
            Console.WriteLine("Sugar Cubes: " + sugarCubes.Count);
            Console.WriteLine("Ice Cubes: " + iceCubes.Count);

        }
    }
}
