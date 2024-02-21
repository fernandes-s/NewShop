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
using BIZ;

namespace NewShop
{
    /// <summary>
    /// Interaction logic for AddCustomer.xaml
    /// </summary>
    public partial class AddCustomer : Window
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string fn = txtFn.Text;
            string sn = txtSn.Text;
            string dob = dtpDOB.Text;
            string ge = "Male";
            if (rdoFemale.IsChecked == true)
                ge = "Female";
            string cy = txtCounty.Text;

            Customer c = new Customer(fn, sn, dob, ge, cy);

            txtCounty.Clear();
            txtFn.Clear();
            txtSn.Clear();
        }
    }
}
