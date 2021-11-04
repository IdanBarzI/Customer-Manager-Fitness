using CustomerManager_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager_1.Services.Service
{
    public interface ICustomersService
    {
        Task<List<Customer>> GetAllCustomersAsync();

        Task<List<Customer>> GetCustomersByNameAsync(string customerName);

        Task RemoveCustomerAsync(Customer customer);
    }
}
