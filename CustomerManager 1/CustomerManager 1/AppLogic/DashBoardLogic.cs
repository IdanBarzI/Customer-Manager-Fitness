using CustomerManager_1.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager_1.AppLogic
{
    class DashBoardLogic
    {
        private string numberOfCustomers; 
        private string numberOfMenus; 
        private string numberOfTrainingPrograms;

        public DashBoardLogic()
        {
            numberOfCustomers = null;
            numberOfMenus = null;
            numberOfTrainingPrograms = null;
        }

        public string GetCustomersNumber()
        {
            using (DataContext data = new DataContext())
            {
                numberOfCustomers = data.Customers.Count().ToString();
                return numberOfCustomers;
            }
        }

        public string GetMenusNumber()
        {
            using (DataContext data = new DataContext())
            {
                numberOfMenus = data.Menus.Count().ToString();
                return numberOfMenus;
            }
        }

        public string GetTrainingProgramsNumber()
        {
            using (DataContext data = new DataContext())
            {
                numberOfTrainingPrograms = data.TrainingPrograms.Count().ToString();
                return numberOfTrainingPrograms;
            }
        }
    }
}
