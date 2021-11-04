using CustomerManager_1.DataAccess;
using CustomerManager_1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager_1.AppLogic
{
    class CustomersLogic
    {
        private List<Customer> customers;

        public CustomersLogic()
        {
            customers = GetAllCustomers();
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> custs = new List<Customer>();
            using (DataContext data = new DataAccess.DataContext())
            {
                custs = data.Customers.ToList();
            }
            return custs;
        }

        public List<Customer> GetCustomersByName(string customerName)
        {
            using (DataContext data = new DataContext())
            {
                customers = data.Customers
                                .Where(p => p.Name.Contains(customerName))
                                .ToList();
            }

            return customers;
        }

        public void RemoveCustomer(Customer customer)
        {
            customers.Remove(customer);

            using (DataContext data = new DataContext())
            {
                data.Entry(customer).State = EntityState.Deleted;
                data.Customers.Remove(customer);
                data.SaveChanges();
            }
        }
    }
}
