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
using CoffeeShop.Lib.Models;
using CoffeeShop.Lib.Services;

namespace CoffeeShop.UI.Views
{
    /// <summary>
    /// Interaction logic for ShowBeans.xaml
    /// </summary>
    public partial class ShowBeans : Window
    {
        public DataAccessService DataAccessService;

        public ShowBeans(DataAccessService dataAccessService)
        {
            DataAccessService = dataAccessService;

            InitializeComponent();

            beansList.ItemsSource = dataAccessService.Beans;
        }
    }
}
