using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Lib.Enums;

namespace CoffeeShop.Lib.Interfaces
{
    public interface IOption
    {
        string Id { get; set; }

        string Name { get; set; }

        decimal Price { get; set; }

        Allergen Allergen { get; set; }
    }
}
