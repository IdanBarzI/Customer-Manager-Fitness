using CustomerManager_1.AppLogic;
using CustomerManager_1.Models;
using CustomerManager_1.Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager_1.Services.Service
{
    class MenuService : IMenuService
    {
        readonly MenuLogic logic = new MenuLogic();

        public Action UpdateMenu { get ; set; }


        public Task<List<Food>> GetMenuAsync() => Task.Run(logic.GetMenu);

        public Task AddToMenuAsync(Food food) =>
            Task.Run(() => { logic.AddToMenu(food); UpdateMenu?.Invoke(); });

        public Task RemoveFromMenuAsync(Food food) =>
            Task.Run(() => { logic.RemoveFromMenu(food); UpdateMenu?.Invoke(); });


        public Task DeleteMenuAsync() =>
            Task.Run(() => { logic.DeleteMenu(); UpdateMenu?.Invoke(); });

        public Task<string[]> GetMenunNutritionalValuesAsync() => Task.Run(logic.GetMenunNutritionalValues);

        public Task SaveMenuAsync() => Task.Run(() => { logic.SaveMenu(); UpdateMenu?.Invoke(); });


    }
}
