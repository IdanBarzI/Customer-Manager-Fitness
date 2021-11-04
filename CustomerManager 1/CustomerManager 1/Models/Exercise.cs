using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager_1.Models
{
    public class Exercise
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public virtual ICollection<TrainingProgram> TrainingPrograms{ get; set; }
    }
}
