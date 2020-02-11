﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Lib.Enums;
using CoffeeShop.Lib.Interfaces;

namespace CoffeeShop.Lib.Models
{
    public class Option : IOption
    {
        public Option()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public Allergen Allergen { get; set; }
    }
}
