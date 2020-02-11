using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Lib.Enums;

namespace CoffeeShop.Lib.Models
{
    public class Snack : Product
    {
        public int Weight { get; set; }

        public List<Allergen> Allergens { get; set; }
    }
}
