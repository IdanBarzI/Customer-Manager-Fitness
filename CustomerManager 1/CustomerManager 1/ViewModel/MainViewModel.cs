using CustomerManager_1.Services.IService;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Controls;

namespace CustomerManager_1.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private IFrameNavigationService _navigationService;
        private readonly IFoodDataService foodService;
        private readonly IMenuService menuService;
        private RelayCommand _loadedCommand;
        public RelayCommand LoadedCommand
        {
            get
            {
                return _loadedCommand
                    ?? (_loadedCommand = new RelayCommand(
                    () =>
                    {
                        _navigationService.NavigateTo("DashBordView");
                    }));
            }
        }


        public MainViewModel(IFoodDataService F_Service, IMenuService M_Service, IFrameNavigationService navigationService)
        {
            foodService = F_Service;
            menuService = M_Service;
            _navigationService = navigationService;
        }



    }
}