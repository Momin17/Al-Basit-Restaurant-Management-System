using System;
using System.Data.SqlClient;

namespace GDL
{
    class expenses
    {
        SqlCommand cmd;
        public string addexpense(string name, string price, string date,string pname)
        {
            try
            {
                string query = "insert into Expenses values ('" + name + "','" + date + "','" + price + "','" + pname + "',"+Program.shopid+")";
                cmd = new SqlCommand(query, Connection.GetConnection());
                cmd.ExecuteNonQuery();
                return "Expenses Added Successfully";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
}
        public string deleteexpense(string i)
        {
            try
            {
                string query = "delete from Expenses where ID = '" + i + "' And Store ="+Program.shopid;
                cmd = new SqlCommand(query, Connection.GetConnection());
                cmd.ExecuteNonQuery();
                return "Expense Deleted Successfully"; 

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string updateexpense(string id,string name, string price, string date)
        {
            try
            {
                string query = "update Expenses set Name ='" + name + "', date = '" + date + "', Price = '" + price + "' where ID = " + id +" And Store ="+Program.shopid;
                cmd = new SqlCommand(query, Connection.GetConnection());
                cmd.ExecuteNonQuery();
                return "Expense Updated Successfully";

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
