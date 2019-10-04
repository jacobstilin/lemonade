using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        // variables
        public Weather weather;
        public List<Customer> customers;
        Random rng;

        // constructor
        public Day(Random rng)
        {
            this.rng = rng;
            customers = new List<Customer>();
            weather = new Weather();
            CreateCustomer();
            
        }

        // methods
        
        private void CreateCustomer()
        {
            int dailyCustomers = new Random().Next(50, 100);
            for (int i = 0; i < dailyCustomers; i++)
            {
                Customer customer = new Customer(rng);
                customers.Add(customer);

            }
        }


    }
}


