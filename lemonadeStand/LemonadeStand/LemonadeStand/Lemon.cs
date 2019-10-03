using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Lemon : Item
    {
        // variables
        // purchase date
        // expiration date
        public int purchaseDate;
        public int expirationDate;

        public Lemon(int currentDay)
        {
            purchaseDate = currentDay;
            expirationDate = currentDay + 3;
        }

        // methods
        

    }
}
