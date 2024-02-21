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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NewShop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddCus_Click(object sender, RoutedEventArgs e)
        {
            AddCustomer ac = new AddCustomer();
            ac.Show();
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            ShowAll sa = new ShowAll();
            sa.Show();
        }

        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            AddProduct aap = new AddProduct();
            aap.Show();
        }

        private void btnSales_Click(object sender, RoutedEventArgs e)
        {
            Sales s = new Sales();
            s.Show();
        }
    }
}
