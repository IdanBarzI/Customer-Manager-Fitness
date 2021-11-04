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
    public class FoodViewModel : ViewModelBase
    {
        private readonly IFoodDataService foodService;

        private readonly IMenuService menuService;

        private ObservableCollection<Food> foodsToAutoComplete;

        public ObservableCollection<Food> FoodsToAutoComplete { get => foodsToAutoComplete; set => Set(ref foodsToAutoComplete, value); }

        private RelayCommand<object> getAutoFoodsFoodCommand { get; set; }

        public RelayCommand<object> GetAutoFoodsCommand
        {
            get
            {
                if (getAutoFoodsFoodCommand == null)
                {
                    getAutoFoodsFoodCommand = new RelayCommand<object>(GetFoodsByName);
                }

                return getAutoFoodsFoodCommand;
            }
        }

        public RelayCommand GetTotalCalCommand { get; set; }

        private Food selectedFood;

        public Food SelectedFood
        {
            get { return selectedFood; }
            set
            {
                if (selectedFood != value)
                {
                    selectedFood = value;
                    if (selectedFood != null)
                    {
                        UpdateSelectedFood(value);
                    }
                }
            }
        }

        private string foodNameAuto;

        public string FoodNameAuto
        {
            get { return foodNameAuto; }
            set
            {
                if (foodNameAuto != value)
                {
                    foodNameAuto = value;
                    if (foodNameAuto != null)
                    {
                        GetFoodsByName(value);
                    }
                }
            }
        }

        private string totalCalories;

        public string TotalCalories
        {
            get { return totalCalories; }
            set
            {
                if (totalCalories == "0")
                {
                    totalCalories = value;
                    RaisePropertyChanged(nameof(totalCalories));
                    return;
                }
                if (totalCalories != value)
                {
                    if (totalCalories != null)
                    {
                        totalCalories = value;
                        RaisePropertyChanged(nameof(totalCalories));
                    }
                }
            }
        }

        private string totalCarbs;

        public string TotalCarbs
        {
            get { return totalCarbs; }
            set
            {
                if (totalCarbs == "0")
                {
                    totalCarbs = value;
                    RaisePropertyChanged(nameof(totalCarbs));
                    return;
                }
                if (totalCarbs != value)
                {
                    if (totalCarbs != null)
                    {
                        totalCarbs = value;
                        RaisePropertyChanged(nameof(totalCarbs));
                    }
                }
            }
        }

        private string totalProtein;

        public string TotalProtein
        {
            get { return totalProtein; }
            set
            {
                if (totalProtein == "0")
                {
                    totalProtein = value;
                    RaisePropertyChanged(nameof(totalProtein));
                    return;
                }
                if (totalProtein != value)
                {
                    if (totalProtein != null)
                    {
                        totalProtein = value;
                        RaisePropertyChanged(nameof(totalProtein));
                    }
                }
            }
        }

        private string totalFat;

        public string TotalFat
        {
            get { return totalFat; }
            set
            {
                if (totalFat == "0")
                {
                    totalFat = value;
                    RaisePropertyChanged(nameof(totalFat));
                    return;
                }
                if (totalFat != value)
                {
                    if (totalFat != null)
                    {
                        totalFat = value;
                        RaisePropertyChanged(nameof(totalFat));
                    }
                }
            }
        }

        public string[] TotalNutri {
            set
            {
                TotalCalories = value[0];
                TotalCarbs = value[1];
                TotalProtein = value[2];
                TotalFat = value[3];
            }
        }


        public FoodViewModel(IFoodDataService F_Service, IMenuService M_Service)
        {
            foodService = F_Service;
            menuService = M_Service;
            totalCalories = "0";
            totalCarbs = "0";
            totalProtein = "0";
            totalFat = "0";

            foodService.UpdateAutoFoods += GetFoodsByName;
            menuService.UpdateMenu += GetTotalCalories;

            GetAllFoods();

        }

        private async void GetAllFoods(string none = "") => FoodsToAutoComplete = new ObservableCollection<Food>(await foodService.GetAllFoodsAsync());

        private async void GetFoodsByName(object foodName)
        {
            foodService.UpdateAutoFoods -= GetFoodsByName;

            var strFoodName = foodName as string;
            FoodsToAutoComplete = new ObservableCollection<Food>(await foodService.GetFoodsByNameAsync(strFoodName));

            foodService.UpdateAutoFoods += GetFoodsByName;
        }

        private async void UpdateSelectedFood(Food food)
        {
            foodService.UpdateSelectedFood -= UpdateSelectedFood;

            await foodService.GetSelectedFoodAsync(food);

            foodService.UpdateSelectedFood += UpdateSelectedFood;
        }


        private async void GetTotalCalories()
        {
            TotalNutri = await (menuService.GetMenunNutritionalValuesAsync());
        }
    }
}