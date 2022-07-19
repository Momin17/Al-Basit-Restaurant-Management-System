using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;

using System.Threading.Tasks;

namespace GDL
{
    class LoginClass
    {

        public bool loginuser(string id, string pass)
        {

            string query = "select * from Users where username ='" + id + "' and Password ='" + pass + "' ";
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {


                return true;
            }
            else
            {
                return false;
            }
        }
        public void username(string id)
        {
            string type = null;
            string query = "select username,Store from Users where username ='" + id + "'";
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                try
                {
                    Program.username = (reader[0].ToString());
                    Program.shopid = int.Parse(reader[1].ToString());
                }
                catch
                {
                    Program.username = null;

                }
            }

        }




        public string CountShops()
        {

            string sqlQuery1 = "select count(Store) from multioutlets where Owner ='" + Program.username+"'";
            SqlCommand cmd1 = new SqlCommand(sqlQuery1, Connection.GetConnection());
            string o = cmd1.ExecuteScalar().ToString();
            return o;
        }


        public string user(string id, string pass)
        {
            string type = null;
            string query = "select UserType  from Users where username ='" + id + "' and Password ='" + pass + "' ";
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {

                try
                {
                    type = (reader[0].ToString());
                }
                catch
                {
                    type = null;

                }
            }
            else
            {
                type = null;
            }
            return type;
        }
    }
}
