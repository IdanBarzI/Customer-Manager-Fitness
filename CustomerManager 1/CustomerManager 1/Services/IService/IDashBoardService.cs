using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager_1.Services.IService
{
    public interface IDashBoardService
    {
        Task<string> GetCustomersNumberAsync();

        Task<string> GetMenusNumberAsync();

        Task<string> GetTrainingProgramsNumberAsync();
    }
}
