using CustomerManager_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager_1.Services.IService
{
    public interface IMenuService
    {
        Action UpdateMenu { get; set; }

        Task<List<Food>> GetMenuAsync();

        Task AddToMenuAsync(Food food);

        Task<string[]> GetMenunNutritionalValuesAsync();

        Task SaveMenuAsync();

        Task RemoveFromMenuAsync(Food food);

        Task DeleteMenuAsync();
    }
}
