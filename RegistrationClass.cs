using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace GDL
{
    class RegistrationClass
    {

        string query;
        SqlCommand cmd;



        public void ShopRegistration(string Name, string Address, string City, string num)
        {
            query = "Insert into Outlet Values('" + Name + "','" + Address + "','" + City + "'," + num + ")";
            cmd = new SqlCommand(query, Connection.GetConnection());
            cmd.ExecuteNonQuery();

        }
        public int getid()
        {
            int id = 0;
            string query = "SELECT MAX(ID) FROM Outlet";
            SqlCommand cmd3 = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader reader = cmd3.ExecuteReader();
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
            return id;
        }
        public string getOwner(string contact)
        {
            string id = "";
            string query = "SELECT username FROM Users where Cell =" + contact + "";
            SqlCommand cmd3 = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader reader = cmd3.ExecuteReader();
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


        public int getidwithcell(string num)
        {
            int id = 0;
            string query = "SELECT ID FROM Outlet where cell =" + num;
            SqlCommand cmd3 = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader reader = cmd3.ExecuteReader();
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
            return id;
        }
        public void MultiShopRegistration(int store)
        {
            query = "Insert into MultiOutlets Values('" + Program.username + "'," + store + ")";
            cmd = new SqlCommand(query, Connection.GetConnection());
            cmd.ExecuteNonQuery();

        }


        public void MultiShopRegistration2(int store)
        {
            query = "Insert into MultiOutlets Values('" + Program.ownerid + "'," + store + ")";
            cmd = new SqlCommand(query, Connection.GetConnection());
            cmd.ExecuteNonQuery();

        }


    }
}
