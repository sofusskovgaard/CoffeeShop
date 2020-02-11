using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Lib.Interfaces;

namespace CoffeeShop.Lib.Models
{
    public class Business : IBusiness
    {
        public string Name { get; set; }
    }
}
