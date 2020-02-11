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
using Microsoft.Win32;

namespace CoffeeShop.UI.Views
{
    /// <summary>
    /// Interaction logic for EditBeans.xaml
    /// </summary>
    public partial class EditBeans : Window
    {
        private Bean _selectedBean;

        private readonly DataAccessService _dataAccessService;

        public EditBeans(DataAccessService dataAccessService)
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
                AddImageButton.Visibility = Visibility.Hidden;
            }
            else
            {
                Image.Visibility = Visibility.Hidden;
                AddImageButton.Visibility = Visibility.Visible;
            }
        }

        private void CreateBeanButton_OnClick(object sender, RoutedEventArgs e)
        {
            var newBean = new Bean();
            _dataAccessService.Beans.Add(newBean);
            beansList.SelectedValue = newBean;
        }

        private void RemoveBeanButton_OnClick(object sender, RoutedEventArgs e)
        {
            _dataAccessService.Beans.Remove(_selectedBean);
        }

        private void AddImageButton_OnClick(object sender, RoutedEventArgs e)
        {
            var fileDialog = new OpenFileDialog
            {
                Multiselect = false,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };

            if (fileDialog.ShowDialog() == true)
            {
                _selectedBean.ImagePath = fileDialog.FileName;
            }

            Image.Source = new BitmapImage(new Uri(_selectedBean.ImagePath, UriKind.Absolute));
            Image.Visibility = Visibility.Visible;
            AddImageButton.Visibility = Visibility.Hidden;
        }
    }
}
