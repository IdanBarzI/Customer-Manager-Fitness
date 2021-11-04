using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager_1.Models
{

    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Gender { get; set; }

        public int? Age { get; set; }

        public double CurrentWeight { get; set; }

        public double TargetWeight { get; set; }

        public double BodyFatPercent { get; set; }

        public double Height { get; set; }

        public DateTime ListingDate { get; set; }

        public string Mail { get; set; }

        public string Phone { get; set; }

        public virtual ICollection<Menu> Menus { get; set; }

        public virtual ICollection<TrainingProgram> TrainingPrograms  { get; set; }

    }
}
