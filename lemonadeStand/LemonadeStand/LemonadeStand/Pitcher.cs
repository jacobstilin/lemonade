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
        public void SellCups(int cupsSold)  //single responsibility principle
        {
            cupsLeftInPitcher -= cupsSold;  //open closed- more than one cup could be sold if need be
        }

        public void FillPitcher()  //single responsibility principle
        {
            cupsLeftInPitcher = 12;
            Console.WriteLine("New pitcher mixed up");
        }
        public int CupsInPitcher()  //single responsibility principle
        {
            return cupsLeftInPitcher;
        }

        public void DumpPitcher()  //single responsibility principle
        {
            cupsLeftInPitcher = 0;
            Console.WriteLine("Pitcher dumped at end of day.");
        }
        
    }
}
