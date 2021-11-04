using CustomerManager_1.AppLogic;
using CustomerManager_1.Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager_1.Services.Service
{
    public class DashBoardService : IDashBoardService
    {
        private readonly DashBoardLogic logic = new DashBoardLogic();

        public Task<string> GetCustomersNumberAsync() => Task.Run(logic.GetCustomersNumber);

        public Task<string> GetMenusNumberAsync() => Task.Run(logic.GetMenusNumber);

        public Task<string> GetTrainingProgramsNumberAsync() => Task.Run(logic.GetTrainingProgramsNumber);

    }
}
