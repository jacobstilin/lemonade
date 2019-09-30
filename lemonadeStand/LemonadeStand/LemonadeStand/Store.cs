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
        public void DisplayStore()
        {
            Console.WriteLine("You have: ");
            player.inventory.DisplayItems();
        }
    }
}
