using CustomerManager_1.AppLogic;
using CustomerManager_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager_1.Services.Service
{

    public class CustomersService : ICustomersService
    {
        private readonly CustomersLogic logic = new CustomersLogic();

        public Task<List<Customer>> GetAllCustomersAsync() => Task.Run(() => logic.GetAllCustomers());

        public Task<List<Customer>> GetCustomersByNameAsync(string customerName) => Task.Run(() => logic.GetCustomersByName(customerName));

        public Task RemoveCustomerAsync(Customer customer) => Task.Run(() => logic.RemoveCustomer(customer));
    }
}
