using CustomerManager_1.Models;
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
    public class MenuViewModel : ViewModelBase
    {
        private readonly IFoodDataService foodService;

        private readonly IMenuService menuService;

        //private RelayCommand<object> getFoodsCommand { get; set; }

        private ObservableCollection<Food> menuFoods;

        public ObservableCollection<Food> MenuFoods { get => menuFoods; set => Set(ref menuFoods, value); }

        public RelayCommand SaveMenuCommand { get; set; }

        private RelayCommand<object> removeFromMenuCommand { get; set; }

        public RelayCommand<object> RemoveFromMenuCommand
        {
            get
            {
                if (removeFromMenuCommand == null)
                {
                    removeFromMenuCommand = new RelayCommand<object>(RemoveFromMenu);
                }

                return removeFromMenuCommand;
            }
        }

        private RelayCommand deleteMenuCommand { get; set; }

        public RelayCommand DeleteMenuCommand
        {
            get
            {
                if (deleteMenuCommand == null)
                {
                    deleteMenuCommand = new RelayCommand(DeleteMenu);
                }

                return deleteMenuCommand;
            }
        }


        public MenuViewModel(IFoodDataService F_Service, IMenuService M_Service)
        {
            foodService = F_Service;
            menuService = M_Service;

            SaveMenuCommand = new RelayCommand(SaveMenu);
            foodService.UpdateSelectedFood += GetFood;
            menuService.UpdateMenu += GetMenu;

            GetMenu();

        }

        private async void GetMenu() => MenuFoods = new ObservableCollection<Food>(await menuService.GetMenuAsync());

        private async void SaveMenu() => await menuService.SaveMenuAsync();

        private async void GetFood(object food) => await menuService.AddToMenuAsync(food as Food);

        private async void RemoveFromMenu(object food) => await menuService.RemoveFromMenuAsync(food as Food);

        private async void DeleteMenu() => await menuService.DeleteMenuAsync();

    }
}
