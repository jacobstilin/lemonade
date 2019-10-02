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
            cupsLeftInPitcher = 0;
        }

        // methods
        public void SellCups(int cupsSold)
        {
            cupsLeftInPitcher -= cupsSold;
        }

        public void FillPitcher()
        {
            cupsLeftInPitcher = 12;
        }
        public int CupsInPitcher()
        {
            return cupsLeftInPitcher;
        }

        public void DumpPitcher()
        {
            cupsLeftInPitcher = 0;
            Console.WriteLine("Pitcher dumped at end of day.");
        }
    }
}
