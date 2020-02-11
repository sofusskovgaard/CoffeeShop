using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Lib.Enums;

namespace CoffeeShop.Lib.Models
{
    public class Bean : Product
    {
        public string ImagePath { get; set; }

        public Origin Origin { get; set; }

        public Roast Roast { get; set; }
    }
}
