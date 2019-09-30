using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Pitcher
    {
        // variable
        public int cupsLeftInPitcher;

        // constructor
        public Pitcher()
        {
            cupsLeftInPitcher = 12;
        }

        // methods
        public void SellCups(int cupsSold)
        {
            cupsLeftInPitcher -= cupsSold;
        }
    }
}
