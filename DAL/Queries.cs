using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Queries : DAO
    {
        SqlDataAdapter da;
        DataTable dt;

        public DataTable AllCus()
        {
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspAllCus";
            cmd.CommandType = CommandType.StoredProcedure;

            da = new SqlDataAdapter();
            dt = new DataTable();

            da.SelectCommand = cmd;
            da.Fill(dt);
            CloseCon();
            return dt;

        }

        public DataTable MySpend(decimal sp) 
        {
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspSpend";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@sp", sp);

            da = new SqlDataAdapter();
            dt = new DataTable();

            da.SelectCommand = cmd;
            da.Fill(dt);

            CloseCon();
            return dt;


        }



    }
}
