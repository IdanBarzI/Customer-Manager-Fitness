using CustomerManager_1.Services.IService;
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
    public class NavigationViewModel : ViewModelBase
    {
        private IFrameNavigationService _navigationService;

        private ObservableCollection<object> histori;

        public ObservableCollection<object> Histori { get => histori; set => Set(ref histori, value); }


        private RelayCommand dashBordCommand;

        public RelayCommand DashBordCommand
        {
            get
            {
                return dashBordCommand
                    ?? (dashBordCommand = new RelayCommand(
                    () =>
                    {
                        _navigationService.NavigateTo("DashBordView");
                    }));
            }
        }

        private RelayCommand customersCommand;

        public RelayCommand CustomersCommand
        {
            get
            {
                return customersCommand
                    ?? (customersCommand = new RelayCommand(
                    () =>
                    {
                        _navigationService.NavigateTo("CustomersView");
                    }));
            }
        }

        private RelayCommand customerCommand;

        public RelayCommand CustomerCommand
        {
            get
            {
                return customerCommand
                    ?? (customerCommand = new RelayCommand(
                    () =>
                    {
                        _navigationService.NavigateTo("CustomerView");
                    }));
            }
        }

        private RelayCommand goBackCommand { get; set; }

        public RelayCommand GoBackCommand
        {
            get
            {
                return goBackCommand
                       ?? (goBackCommand = new RelayCommand(
                           () =>
                           {
                               _navigationService.GoBack();
                           }));
            }

        }

        private RelayCommand _menuCommand;
        public RelayCommand MenuCommand
        {
            get
            {
                return _menuCommand
                       ?? (_menuCommand = new RelayCommand(
                           () =>
                           {
                               _navigationService.NavigateTo("MenuView");
                           }));
            }
        }

        public NavigationViewModel(IFrameNavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
