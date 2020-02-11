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

        public Menu()
        {
            _dataAccessService = new DataAccessService();

            InitializeComponent();
        }

        private void ShowBeans(object sender, RoutedEventArgs e)
        {
            new ShowBeans(_dataAccessService).Show();
        }

        private void ShowDrinks(object sender, RoutedEventArgs e)
        {
            new ShowDrinks().Show();
        }

        private void ShowSnacks(object sender, RoutedEventArgs e)
        {
            new ShowSnacks().Show();
        }

        private void EditBeans(object sender, RoutedEventArgs e)
        {
            new EditBeans().Show();
        }

        private void EditDrinks(object sender, RoutedEventArgs e)
        {
            new EditDrinks().Show();
        }

        private void EditSnacks(object sender, RoutedEventArgs e)
        {
            new EditSnacks().Show();
        }
    }
}
