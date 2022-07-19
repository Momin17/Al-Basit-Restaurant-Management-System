using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

using System.Threading.Tasks;

namespace GDL
{
    class checkandbalance
    {
        SqlCommand cmd3;
        SqlDataReader reader;

        public double getrate(string query)
        {

            double id = 0;

            //string query = ;
            cmd3 = new SqlCommand(query, Connection.GetConnection());
            reader = cmd3.ExecuteReader();
            if (reader.Read())
            {
                try
                {
                    id = double.Parse(reader[0].ToString());
                }
                catch
                {
                    id = 0;
                }
            }
            reader.Close();
            return id;
        }


        public string updateData(string query)
        {

        try
            {
                cmd3 = new SqlCommand(query, Connection.GetConnection());
                cmd3.ExecuteNonQuery();
                return "Updated Successfully";


            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        //"select distinct(t.TokenNo) from Token t join Sales s on s.Invoice_NO=t.Invoice_No where s.Invoice_No in (select Max(Invoice_NO) from Sales where Store=" + Program.shopid+")"
        public string MaxOrderNum()
        {

            string query= "select distinct(t.TokenNo) from Token t join Sales s on s.Invoice_NO=t.Invoice_No where s.Invoice_No in (select Max(Invoice_NO) from Sales where Store=" + Program.shopid + ")";
            int id = 0;

            //string query = ;
            cmd3 = new SqlCommand(query, Connection.GetConnection());
            reader = cmd3.ExecuteReader();
            if (reader.Read())
            {
                try
                {
                    id = int.Parse(reader[0].ToString());
                }
                catch
                {
                    id = 0;
                }
            }
            reader.Close();
            return id.ToString();



        }
        public string getstringvalue(string query)
        {

            string id = "";

            //string query = ;
            cmd3 = new SqlCommand(query, Connection.GetConnection());
            reader = cmd3.ExecuteReader();
            if (reader.Read())
            {
                try
                {
                    id = reader[0].ToString();
                }
                catch
                {
                    id = "";
                }
            }
            reader.Close();
            return id;
        }
    }
}
