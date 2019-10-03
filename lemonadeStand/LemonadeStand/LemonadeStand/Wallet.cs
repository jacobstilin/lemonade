using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Wallet
    {
        // variable
        private double money;

        // constructor
        public Wallet()
        {
            money = 20.00;
        }

        // methods
        public void GainMoney(double gains)  //single responsibility principle
        {
            money += gains;
        }

        public void LoseMoney(double losses)  //single responsibility principle
        {
            money -= losses;
        }

        public double GetMoney()  //single responsibility principle
        {
            return money;
        }

        public void GetDailyGains(double startMoney, double endMoney)  //single responsibility principle
        {
            if (startMoney < endMoney)
            {
                Console.WriteLine("Made a profit of $" + (endMoney - startMoney) + " today.");
            }
            else if (startMoney > endMoney)
            {
                Console.WriteLine("Lost $" + (startMoney - endMoney) + " today.");
            }
            else if (startMoney == endMoney)
            {
                Console.WriteLine("Broke even today.");
            }
        }

        public void GetTotalGains()  //single responsibility principle
        {
            double currentMoney = GetMoney();
            
            if (currentMoney > 20)
            {
                Console.WriteLine("As of today you have made $" + (currentMoney - 20));
            }
            else if (currentMoney < 20)
            {
                Console.WriteLine("As of today you have lost $" + (20 - currentMoney));
            }
            else if (currentMoney == 20)
            {
                Console.WriteLine("As of today you are breaking even");
            }
        }
        
    }
}
