using CustomerManager_1.DataAccess;
using CustomerManager_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CustomerManager_1.AppLogic
{
    class MenuLogic
    {
        private List<Food> foods;
        private Food selectedFood;
        private List<Food> menuFoods;

        public MenuLogic()
        {
            foods = GetAllFoods();
            selectedFood = new Food();
            menuFoods = new List<Food>();

        }

        public List<Food> GetAllFoods()
        {

            using (DataContext data = new DataAccess.DataContext())
            {
                foods = data.Foods.ToList();
            }
            //foods = File.ReadLines("Data/Foods.csv", System.Text.Encoding.GetEncoding("Windows-1255"))
            //                                         .Skip(1)
            //                                         .Select(ParseFoodFromLine)
            //                                         .ToList();

            //using (DataContext data = new DataAccess.DataContext())
            //{
            //    foreach (var food in foods)
            //    {
            //        data.Foods.Add(food);
            //    }
            //    data.SaveChanges();
            //}

            return foods;
        }

        public List<Food> GetFoodsByName(string foodName)
        {
            using (DataContext data = new DataAccess.DataContext())
            {
                foods = data.Foods
                 .Where(p => p.Name.Contains(foodName)).ToList();
            }
            //foods = File.ReadLines("Data/Foods.csv", System.Text.Encoding.GetEncoding("Windows-1255")).Skip(1)
            //     .Select(ParseFoodFromLine)
            //     .Where(p => p.Name.Contains(foodName)).ToList();


            return foods;
        }

        public Food GetFoodById(string foodId)
        {
            return foods.Where(f => f.Id == Convert.ToInt32(foodId)).FirstOrDefault();
        }

        private static Food ParseFoodFromLine(string line)
        {
            string[] parts = line.Split(',');
            try
            {
                return new Food
                {
                    Id = Convert.ToInt32(parts[0]),
                    Name = parts[2],
                    Protein = parts[3],
                    Fat = parts[4],
                    Carbs = parts[5],
                    Calories = parts[6],
                    Fiber = parts[7],
                    Calcium = parts[8],
                    Iron = parts[9],
                    B12 = parts[10],
                    VitaminD = parts[11]
                };
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry");
                throw;
            }

        }
        //Menu
        public List<Food> GetMenu() => menuFoods;

        public void AddToMenu(Food food) => menuFoods.Add(food);

        public void RemoveFromMenu(Food food) => menuFoods.Remove(food);

        public string[] GetMenunNutritionalValues()
        {
            string[] NutritionalValues = new string[4];
            int totalCal = 0;
            int totalCarb = 0;
            int totalProtein = 0;
            int totalFat = 0;
            menuFoods.ForEach(f =>
                  {
                      double calor;
                      if (double.TryParse(f.Calories, out calor))
                      {
                          totalCal += Convert.ToInt32(calor);
                      }
                      double carb;
                      if (double.TryParse(f.Carbs, out carb))
                      {
                          totalCarb += Convert.ToInt32(carb);
                      }
                      double protein;
                      if (double.TryParse(f.Protein, out protein))
                      {
                          totalProtein += Convert.ToInt32(protein);
                      }
                      double fat;
                      if (double.TryParse(f.Fat, out fat))
                      {
                          totalFat += Convert.ToInt32(fat);
                      }
                  });
            NutritionalValues[0] = totalCal.ToString();
            NutritionalValues[1] = totalCarb.ToString();
            NutritionalValues[2] = totalProtein.ToString();
            NutritionalValues[3] = totalFat.ToString();

            return NutritionalValues;
        }

        public void DeleteMenu() => menuFoods.Clear();

        public bool SaveMenu()
        {
            if (menuFoods.Count != 0)
            {
                Menu menu = new Menu();
                using (DataAccess.DataContext data = new DataAccess.DataContext())
                {
                    try
                    {
                        menu.Foods = menuFoods;
                        menu.Name = "FatAsFuck";
                        data.Menus.Add(menu);
                        data.Customers.Include("Menus").FirstOrDefault(c => c.Id == 1).Menus.Add(menu);
                        data.SaveChanges();
                        menuFoods.Clear();
                    }
                    catch (ValidationException e)
                    {
                    }
                }
                return true;
            }
            return false;
        }

    }
}
