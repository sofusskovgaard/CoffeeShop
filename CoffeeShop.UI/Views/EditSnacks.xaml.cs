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
    /// Interaction logic for EditSnacks.xaml
    /// </summary>
    public partial class EditSnacks : Window
    {
        private Snack _selectedSnack;

        private readonly DataAccessService _dataAccessService;

        public EditSnacks(DataAccessService dataAccessService)
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
                AddImageButton.Visibility = Visibility.Hidden;
            }
            else
            {
                Image.Visibility = Visibility.Hidden;
                AddImageButton.Visibility = Visibility.Visible;
            }
        }

        private void CreateSnackButton_OnClick(object sender, RoutedEventArgs e)
        {
            var newBean = new Snack();
            _dataAccessService.Snacks.Add(newBean);
            snacksList.SelectedValue = newBean;
        }

        private void RemoveSnackButton_OnClick(object sender, RoutedEventArgs e)
        {
            _dataAccessService.Snacks.Remove(_selectedSnack);
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
                _selectedSnack.ImagePath = fileDialog.FileName;
            }

            Image.Source = new BitmapImage(new Uri(_selectedSnack.ImagePath, UriKind.Absolute));
            Image.Visibility = Visibility.Visible;
            AddImageButton.Visibility = Visibility.Hidden;
        }
    }
}
