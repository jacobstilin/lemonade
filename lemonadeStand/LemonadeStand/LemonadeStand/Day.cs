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

        // constructor
        public Day()
        {
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
                Customer customer = new Customer();
                customers.Add(customer);

            }
        }


    }
}


