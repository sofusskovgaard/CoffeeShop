using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
    /// Interaction logic for ShowBeans.xaml
    /// </summary>
    public partial class ShowBeans : Window
    {
        private Bean _selectedBean;

        private readonly DataAccessService _dataAccessService;

        public ShowBeans(DataAccessService dataAccessService)
        {
            _dataAccessService = dataAccessService;

            InitializeComponent();

            beansList.ItemsSource = _dataAccessService.Beans;
            OriginComboBox.ItemsSource = Enum.GetValues(typeof(Origin)).Cast<Origin>();
            RoastComboBox.ItemsSource = Enum.GetValues(typeof(Roast)).Cast<Roast>();
        }

        private void BeansList_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _selectedBean = beansList.SelectedValue as Bean;

            if (_selectedBean != null && !string.IsNullOrEmpty(_selectedBean.ImagePath))
            {
                Image.Source = new BitmapImage(new Uri(_selectedBean.ImagePath, UriKind.Absolute));
                Image.Visibility = Visibility.Visible;
            }
            else
            {
                Image.Visibility = Visibility.Hidden;
            }
        }
    }
}
