using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CoffeeShop.Lib.Services;
using CoffeeShop.UI.Views;

namespace CoffeeShop.UI
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        private DataAccessService _dataAccessService;

        private bool _adminDest = true;

        public Menu()
        {
            _dataAccessService = new DataAccessService();

            InitializeComponent();

            if (!_adminDest)
            {
                editBeansButton.IsEnabled = false;
                editDrinksButton.IsEnabled = false;
                editSnacksButton.IsEnabled = false;
            }
        }

        private void ShowBeans(object sender, RoutedEventArgs e)
        {
            new ShowBeans(_dataAccessService).Show();
        }

        private void ShowDrinks(object sender, RoutedEventArgs e)
        {
            new ShowDrinks(_dataAccessService).Show();
        }

        private void ShowSnacks(object sender, RoutedEventArgs e)
        {
            new ShowSnacks(_dataAccessService).Show();
        }

        private void EditBeans(object sender, RoutedEventArgs e)
        {
            new EditBeans(_dataAccessService).Show();
        }

        private void EditDrinks(object sender, RoutedEventArgs e)
        {
            new EditDrinks(_dataAccessService).Show();
        }

        private void EditSnacks(object sender, RoutedEventArgs e)
        {
            new EditSnacks(_dataAccessService).Show();
        }
    }
}
