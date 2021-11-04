using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager_1.Models
{
    public class Food
    {
        [DisplayName("מספר זיהוי")]
        public int Id { get; set; }
        [DisplayName("מזון")]
        public string Name { get; set; }
        [DisplayName("מזון")]
        public string Calcium { get; set; }
        [DisplayName("קלוריות")]
        public string Calories { get; set; } //Per 100g
        [DisplayName("פחמימות")]
        public string Carbs { get; set; }//Per 100g
        [DisplayName("חלבונים")]
        public string Protein { get; set; }//Per 100g
        [DisplayName("שומנים")]
        public string Fat { get; set; }
        [DisplayName("ברזל")]
        public string Iron { get; set; }

        public string B12 { get; set; }
        [DisplayName("D ויטמין")]
        public string VitaminD { get; set; }
        [DisplayName("סיבים")]
        public string Fiber { get; set; }
        [DisplayName("תמונה")]
        public string Image { get; set; }
        [DisplayName("הערות וכמויות")]
        public string NotesAndAmounts { get; set; }
        [DisplayName("קטגוריה")]
        public string FoodCategoryName { get; set; }

        [DisplayName(".")]
        public virtual ICollection<Menu> Menus { get; set; }
    }
}
