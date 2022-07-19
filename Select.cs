using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace GDL
{
    class Select
    {


        SqlDataAdapter adapt;
        DataTable dt;
        public SqlDataReader reader;
        public DataSet ds;
        SqlCommand cmd;

        public DataSet search1(string que)
        {

            adapt = new SqlDataAdapter(que, Connection.GetConnection());
            ds = new DataSet();
            adapt.Fill(ds);
            return ds;

        }
        public string MaxOrderNum()
        {

            string num = null;
            cmd = new SqlCommand("SELECT MAX(Invoice_No) FROM Sales where Store="+Program.shopid, Connection.GetConnection());
            //read = cmd.ExecuteReader();
            string o = cmd.ExecuteScalar().ToString();

            if (o == "")
            {
                return "0";

            }
            else
            {
                return o;

            }


        }

        public void Insert(string query)
        {
            cmd = new SqlCommand(query, Connection.GetConnection());
            cmd.ExecuteNonQuery();

        }
        public DataTable search(string que)
        {

            adapt = new SqlDataAdapter(que, Connection.GetConnection());
            dt = new DataTable();
            adapt.Fill(dt);
            return dt;

        }
    }
}
