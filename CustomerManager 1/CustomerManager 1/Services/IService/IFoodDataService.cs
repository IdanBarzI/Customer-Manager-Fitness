using CustomerManager_1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager_1.Services.IService
{
    public interface IFoodDataService
    {
        Action<string> UpdateAutoFoods { get; set; }

        Action<Food> UpdateSelectedFood { get; set; }

        Task<List<Food>> GetAllFoodsAsync();

        Task<List<Food>> GetFoodsByNameAsync(string foodName);

        Task<Food> GetSelectedFoodAsync(Food food);

    }
}
