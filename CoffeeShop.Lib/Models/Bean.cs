using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Lib.Enums;

namespace CoffeeShop.Lib.Models
{
    public class Bean : Product
    {
        public Origin Origin { get; set; }

        public Roast Roast { get; set; }
    }
}
