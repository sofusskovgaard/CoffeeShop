using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Lib.Interfaces
{
    public interface IProduct
    {
        string Id { get; set; }

        string Name { get; set; }

        decimal Price { get; set; }

        string Description { get; set; }
    }
}
