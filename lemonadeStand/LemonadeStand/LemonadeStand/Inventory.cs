﻿using System;
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
            StarterPack();
        }

        // methods
        public void DisplayItems()  //single responsibility principle
        {
            Console.WriteLine("Cups: " + cups.Count);
            Console.WriteLine("Lemons: " + lemons.Count);
            Console.WriteLine("Sugar Cubes: " + sugarCubes.Count);
            Console.WriteLine("Ice Cubes: " + iceCubes.Count);

        }
        public void StarterPack()
        {
            for (int i = 0; i < 100; i++)
            {
                cups.Add(new Cup());
            }
            for (int i = 0; i < 100; i++)
            {
                lemons.Add(new Lemon(1));
            }
            for (int i = 0; i < 100; i++)
            {
                sugarCubes.Add(new SugarCube());
            }
            for (int i = 0; i < 100; i++)
            {
                iceCubes.Add(new IceCube());
            }
        }
        public void AddItems(string item, int quantity, int currentDay)  //single responsibility principle
        {
            switch (item)
            {
                case "cups":
                    for (int i = 0; i < quantity; i++)
                    {
                        cups.Add(new Cup());
                    }
                    break;
                case "lemons":
                    for (int i = 0; i < quantity; i++)
                    {
                        lemons.Add(new Lemon(currentDay));
                    }
                    break;
                case "sugar cubes":
                    for (int i = 0; i < quantity; i++)
                    {
                        sugarCubes.Add(new SugarCube());
                    }
                    break;
                case "ice cubes":
                    for (int i = 0; i < quantity; i++)
                    {
                        iceCubes.Add(new IceCube());
                    }
                    break;
            }
        }
        public void RemoveItems(string item, int quantity)  //single responsibility principle
        {
            switch (item)
            {
                case "cups":
                    for (int i = 0; i < quantity; i++)
                    {
                        cups.RemoveAt(0);
                    }
                    break;
                case "lemons":
                    for (int i = 0; i < quantity; i++)
                    {
                        lemons.RemoveAt(0);
                    }
                    break;
                case "sugar cubes":
                    for (int i = 0; i < quantity; i++)
                    {
                        sugarCubes.RemoveAt(0);
                    }
                    break;
                case "ice cubes":
                    for (int i = 0; i < quantity; i++)
                    {
                        iceCubes.RemoveAt(0);
                    }
                    break;
            }
        }

        public void IceMelts()  //single responsibility principle
        {
            if (iceCubes.Count > 0)
            {
                iceCubes.Clear();
                Console.WriteLine("All ice cubes melt.");
            }
        }

        public void LemonsExpire(int currentDay)
        {
            int expiredLemons = 0;
            for (int i = 0; i < lemons.Count; i++)
            {
                if (lemons[i].expirationDate == currentDay)
                {
                    lemons.RemoveAt(i);
                    expiredLemons++;
                    i--;
                }
            }
            if (expiredLemons > 0)
            {
                Console.WriteLine("You lost " + expiredLemons + " lemons.");
            }
        }
    }
}
