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
    /// Interaction logic for ShowSnacks.xaml
    /// </summary>
    public partial class ShowSnacks : Window
    {
        private Snack _selectedSnack;

        private readonly DataAccessService _dataAccessService;

        public ShowSnacks(DataAccessService dataAccessService)
        {
            _dataAccessService = dataAccessService;

            InitializeComponent();

            snacksList.ItemsSource = _dataAccessService.Snacks;
        }

        private void SnacksList_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _selectedSnack = snacksList.SelectedValue as Snack;

            if (_selectedSnack != null && !string.IsNullOrEmpty(_selectedSnack.ImagePath))
            {
                Image.Source = new BitmapImage(new Uri(_selectedSnack.ImagePath, UriKind.Absolute));
                Image.Visibility = Visibility.Visible;
            }
            else
            {
                Image.Visibility = Visibility.Hidden;
            }
        }
    }
}
