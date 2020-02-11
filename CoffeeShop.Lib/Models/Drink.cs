using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Lib.Enums;

namespace CoffeeShop.Lib.Models
{
    public class Drink : Product
    {
        public string ImagePath { get; set; }

        public Bean Bean { get; set; }

        public List<Option> Configuration { get; set; }

        public IEnumerable<Allergen> Allergens => Configuration.Select(c => c.Allergen).Where(c => true);
    }
}
