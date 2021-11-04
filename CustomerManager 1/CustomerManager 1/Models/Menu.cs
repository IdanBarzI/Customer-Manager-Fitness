using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager_1.Models
{
    public class Menu
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Customer> Customers  { get; set; }

        public virtual ICollection<Food> Foods { get; set; }

    }
}
