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

namespace NewShop
{
    /// <summary>
    /// Interaction logic for ShowAll.xaml
    /// </summary>
    public partial class ShowAll : Window
    {
        public ShowAll()
        {
            InitializeComponent();
        }
        Queries q = new Queries();

        private void btnShowCus_Click(object sender, RoutedEventArgs e)
        {
            Queries q = new Queries();
            dgv.ItemsSource = q.AllCus().DefaultView;
        }

        private void btnSpend_Click(object sender, RoutedEventArgs e)
        {
            decimal spend = decimal.Parse(txtSpend.Text);   
            dgv.ItemsSource = q.MySpend(spend).DefaultView;
        }
    }
}
