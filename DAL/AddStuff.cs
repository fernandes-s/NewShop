using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class AddStuff : DAO
    {
        public void AddCus(string fn, string sn, string dob, string ge, string cy)
        {
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspAddCustomer";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@fn", fn);
            cmd.Parameters.AddWithValue("@sn", sn);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@ge", ge);
            cmd.Parameters.AddWithValue("@cy", cy);

            cmd.ExecuteNonQuery();
            CloseCon();
        }

        public void AddNewProduct(string pname, int qty, decimal pri)
        {
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspAddProduct";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@productName", pname );
            cmd.Parameters.AddWithValue("@quantity", qty);
            cmd.Parameters.AddWithValue("@price", pri);

            cmd.ExecuteNonQuery();
            CloseCon();
        }


        public void NewSale(string cusName, string proName, decimal pri, int qty, decimal tot, DateTime dt)
        {
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspNewSale";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@cusName", cusName);
            cmd.Parameters.AddWithValue("@proName", proName);
            cmd.Parameters.AddWithValue("@pri", pri);
            cmd.Parameters.AddWithValue("@qty", qty);
            cmd.Parameters.AddWithValue("@tot", tot);
            cmd.Parameters.AddWithValue("@dt", dt);

            cmd.ExecuteNonQuery();
            CloseCon();



        }


    }
}
