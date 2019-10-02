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
        public void GainMoney(double gains)
        {
            money += gains;
        }

        public void LoseMoney(double losses)
        {
            money -= losses;
        }

        public double GetMoney()
        {
            return money;
        }
        
    }
}
