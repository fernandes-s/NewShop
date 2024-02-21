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
using DAL;
using BIZ;


namespace NewShop
{
    /// <summary>
    /// Interaction logic for AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Window
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        

        private void btnAddpro_Click(object sender, RoutedEventArgs e)
        {
            string pname = cboProdName.SelectedItem.ToString();
            int qty = int.Parse(txtQty.Text);
            decimal pri = decimal.Parse(txtPrice.Text);

            Product p = new Product(pname, qty, pri);
            p.AddMyNewProduct();

            txtPrice.Clear();
            txtQty.Clear();

        }
    }
}
