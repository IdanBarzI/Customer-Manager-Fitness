using CustomerManager_1.Services.IService;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager_1.ViewModel
{
    public class DashBoardViewModel : ViewModelBase
    {

        private readonly IDashBoardService dashBoardService;

        private string customersNumber;

        public string CustomersNumber
        {
            get { return customersNumber; }
            set
            {
                customersNumber = value;
                RaisePropertyChanged(nameof(customersNumber));
            }
        }

        private string menusNumber;

        public string MenusNumber
        {
            get { return menusNumber; }
            set
            {
                menusNumber = value;
                RaisePropertyChanged(nameof(menusNumber));
            }
        }

        private string trainingProgramssNumber;

        public string TrainingProgramssNumber
        {
            get { return trainingProgramssNumber; }
            set
            {
                trainingProgramssNumber = value;
                RaisePropertyChanged(nameof(trainingProgramssNumber));
            }
        }


        private RelayCommand _loadedCommand;

        public RelayCommand LoadedCommand
        {
            get
            {
                GetCustomersNumber();
                GetMenusNumber();
                GetTrainingProgramsNumber();
                return null;
            }
        }

        public DashBoardViewModel(IDashBoardService DashBoard_Service)
        {
            dashBoardService = DashBoard_Service;
        }


        private async void GetCustomersNumber() => CustomersNumber = await dashBoardService.GetCustomersNumberAsync();

        private async void GetMenusNumber() => MenusNumber = await dashBoardService.GetMenusNumberAsync();

        private async void GetTrainingProgramsNumber() => TrainingProgramssNumber = await dashBoardService.GetTrainingProgramsNumberAsync();

    }
}
