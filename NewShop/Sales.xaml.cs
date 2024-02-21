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
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace NewShop
{
    /// <summary>
    /// Interaction logic for Sales.xaml
    /// </summary>
    public partial class Sales : Window
    {
        
        public Sales()
        {
            InitializeComponent();
        }

        DAO dao = new DAO();
        SqlDataReader dr;

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            PopComboCus();
            PopComboPro();
        }

        private void cboCustomer_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnBuy_Click(object sender, RoutedEventArgs e)
        {
            string cusName = txtFullName.Text;
            string pro = txtProductName.Text;
            decimal pri = decimal.Parse(txtPrice.Text);
            int qty = int.Parse(txtQty.Text);
            decimal tot = pri * qty;
            DateTime dt = DateTime.Now;
        }

        void PopComboCus()
        {
            SqlCommand cmd =  dao.OpenCon().CreateCommand();
            cmd.CommandText = "uspPopComboCus";
            cmd.CommandType = CommandType.StoredProcedure;

            dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                string cusId = dr["CustomerID"].ToString();
                cboCustomer.Items.Add(cusId);
            }
            dao.CloseCon();
        }


        void PopComboPro()
        {
            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = "uspPopComboPro";
            cmd.CommandType = CommandType.StoredProcedure;

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string proId = dr["ProductID"].ToString();
                cboProduct.Items.Add(proId);
            }
            dao.CloseCon();
        }

        private void cboCustomer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GetCusName();
        }

        private void cboProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GetProName();
        }

        void GetCusName()
        {
            string id = cboCustomer.SelectedItem.ToString();

            SqlCommand cmd = dao.OpenCon().CreateCommand();
            //int cusId = int.Parse(id);
            cmd.CommandText = "uspGetCusName";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cusId", id);

            dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                string fn = dr["FirstName"].ToString();
                string sn = dr["Surname"].ToString();
                txtFullName.Text = fn + " " + sn;
            }
            dao.CloseCon();

        }

        void GetProName()
        {
            string id = cboProduct.SelectedItem.ToString();

            SqlCommand cmd = dao.OpenCon().CreateCommand();
            //int cusId = int.Parse(id);
            cmd.CommandText = "uspGetProName";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ProId", id);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string pn = dr["ProductName"].ToString();
                string pri = dr["Price"].ToString();
                txtProductName.Text = pn;
                txtPrice.Text = pri;
            }
            dao.CloseCon() ;
        }


    }
}
