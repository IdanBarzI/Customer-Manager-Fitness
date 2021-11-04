using CustomerManager_1.AppLogic;
using CustomerManager_1.Models;
using CustomerManager_1.Services.IService;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager_1.Services.Service
{
    public class FoodDataService : IFoodDataService
    {
        private readonly MenuLogic logic = new MenuLogic();

        public Action<string> UpdateAutoFoods { get; set; }

        public Action<Food> UpdateSelectedFood { get; set; }

        public Task<List<Food>> GetAllFoodsAsync() => Task.Run(logic.GetAllFoods);

        public Task<List<Food>> GetFoodsByNameAsync(string foodName)
        {
            Task.Run(() => { UpdateAutoFoods?.Invoke(foodName); });
            return Task.Run(() => logic.GetFoodsByName(foodName));
        }

        public Task<Food> GetSelectedFoodAsync(Food food)
        {
            Task.Run(() => { UpdateSelectedFood?.Invoke(food); });
            return Task.Run(() => logic.GetFoodById(food.Id.ToString()));
        }
    }
}
