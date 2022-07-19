using System;
using System.Data.SqlClient;

namespace GDL
{
    class user
    {
        SqlCommand cmd;
        public string adduser(string uname, string name, string cell, string password, string utype)
        {
            try
            {
                string query = "insert into Users values ('" + uname + "','" + name + "','" + cell + "','" + password + "','" + utype + "',"+Program.shopid+")";
                cmd = new SqlCommand(query, Connection.GetConnection());
                cmd.ExecuteNonQuery();
                return "User Added Successfully";

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string deleteuser(string i)
        {
            try
            {
                string query = "delete from Users where Cell = '" + i + "' And Store="+Program.shopid;
                cmd = new SqlCommand(query, Connection.GetConnection());
                cmd.ExecuteNonQuery();
                return "User Deleted Successfully";

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string updateuser(string uname, string name, string cell, string password, string utype, string id)
        {
            try
            {
                string query = "update Users set username = '" + uname + "', Name ='" + name + "', Cell = " + cell + ", Password = '" + password + "', UserType = '" + utype + "' where Cell = " + id+" And Store = "+ Program.shopid;
                cmd = new SqlCommand(query, Connection.GetConnection());
                cmd.ExecuteNonQuery();
                return "User Updated Successfully";

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
