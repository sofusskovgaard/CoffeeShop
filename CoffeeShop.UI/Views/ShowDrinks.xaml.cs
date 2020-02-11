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
using CoffeeShop.Lib.Enums;
using CoffeeShop.Lib.Models;
using CoffeeShop.Lib.Services;

namespace CoffeeShop.UI.Views
{
    /// <summary>
    /// Interaction logic for ShowDrinks.xaml
    /// </summary>
    public partial class ShowDrinks : Window
    {
        private Drink _selectedDrink;

        private readonly DataAccessService _dataAccessService;

        public ShowDrinks(DataAccessService dataAccessService)
        {
            _dataAccessService = dataAccessService;

            InitializeComponent();

            drinksList.ItemsSource = _dataAccessService.Drinks;

            BeanComboBox.ItemsSource = _dataAccessService.Beans;

            BeanOriginComboBox.ItemsSource = Enum.GetValues(typeof(Origin)).Cast<Origin>();
            BeanRoastComboBox.ItemsSource = Enum.GetValues(typeof(Roast)).Cast<Roast>();
        }

        private void DrinksList_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _selectedDrink = drinksList.SelectedValue as Drink;

            if (_selectedDrink != null && !string.IsNullOrEmpty(_selectedDrink.ImagePath))
            {
                Image.Source = new BitmapImage(new Uri(_selectedDrink.ImagePath, UriKind.Absolute));
                Image.Visibility = Visibility.Visible;
            }
            else
            {
                Image.Visibility = Visibility.Hidden;
            }
        }
    }
}
