using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Lib.Enums;
using CoffeeShop.Lib.Models;

namespace CoffeeShop.Lib.Services
{
    public class DataAccessService
    {
        public ObservableCollection<Bean> Beans { get; set; }
        public ObservableCollection<Drink> Drinks { get; set; }
        public ObservableCollection<Snack> Snacks { get; set; }

        public DataAccessService()
        {

            Beans = new ObservableCollection<Bean>();
            Drinks = new ObservableCollection<Drink>();
            Snacks = new ObservableCollection<Snack>();



            Beans.Add(new Bean()
            {
                Name = "Shitty Bean",
                Description = "Shitty beans, made from shitty elephants",
                Origin = Origin.Guatemala,
                Roast = Roast.Dark,
                Price = 99.99M
            });

            Drinks.Add(new Drink()
            {
                Name = "Shitty Coffee",
                Description = "Shitty coffee made from the shittiest beans",
                Bean = Beans[0],
                Price = 29.99M
            });

            Snacks.Add(new Snack()
            {
                Name = "Shitty Snack",
                Description = "This is elephant shit",
                Price = 19.99M,
                Weight = 75
            });
        }
    }
}
