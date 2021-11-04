using CustomerManager_1.Models;
using CustomerManager_1.Services.Service;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager_1.ViewModel
{
    public class CustomersViewModel : ViewModelBase
    {
        private readonly ICustomersService customersService;

        private ObservableCollection<Customer> customers;

        public ObservableCollection<Customer> Customers { get => customers; set => Set(ref customers, value); }

        private string customerName;

        public string CustomerName
        {
            get { return customerName; }
            set
            {
                if (customerName != value)
                {
                    customerName = value;
                    if (customerName != null)
                    {
                        getCustomersByName(value);
                    }
                }
            }
        }

        private RelayCommand<object> removeCustomerCommand { get; set; }

        public RelayCommand<object> RemoveCustomerCommand
        {
            get
            {
                if (removeCustomerCommand == null)
                {
                    removeCustomerCommand = new RelayCommand<object>(RemoveCustomer);
                }

                return removeCustomerCommand;
            }
        }

        public CustomersViewModel(ICustomersService C_Service)
        {
            customersService = C_Service;

            GetAllCustomers();
        }
        private async void RemoveCustomer(object customer)
        {
            await customersService.RemoveCustomerAsync(customer as Customer);
            GetAllCustomers();
        }

        private async void GetAllCustomers() => Customers = new ObservableCollection<Customer>(await customersService.GetAllCustomersAsync());

        private async void getCustomersByName(object customerName)
        {
            string strCustomerName = customerName.ToString();
            Customers = new ObservableCollection<Customer>(await customersService.GetCustomersByNameAsync(strCustomerName));
        }
    }
}
