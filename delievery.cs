using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GDL
{
    class delievery
    {
        SqlCommand cmd;
        public string addcharges(string name,int charges)
        {
            try
            {
                string query = "insert into managedel values ('" + name + "',"+charges+","+Program.shopid+")";
                cmd = new SqlCommand(query, Connection.GetConnection());
                cmd.ExecuteNonQuery();
                return "Charges Added Successfully";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string deletecharges(string i)
        {
            try
            {
                string query = "delete from managedel where Area_Name = '" + i + "' And Store ="+Program.shopid;
                cmd = new SqlCommand(query, Connection.GetConnection());
                cmd.ExecuteNonQuery();
                return "Charges Deleted Successfully";

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string updatecharges(string i,string name,int amount)
        {
            try
            {
                string query = "update managedel set Area_Name ='" + name + "',Charges = " + amount + " where Area_Name = '" + i + "' And Store ="+Program.shopid;
                cmd = new SqlCommand(query, Connection.GetConnection());
                cmd.ExecuteNonQuery();
                return "Charges Updated Successfully";

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }






        public string addtables(string tableno, int capacity)
        {
            try
            {
                string query = "insert into Tables values ('" + tableno + "'," + capacity + ","+Program.shopid+")";
                cmd = new SqlCommand(query, Connection.GetConnection());
                cmd.ExecuteNonQuery();
                return "Table No "+ tableno + " Added Successfully";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }



        public string deleteTable(string i)
        {
            try
            {
                string query = "delete from Tables where TableNO = '" + i+"' And Store ="+Program.shopid ;
                cmd = new SqlCommand(query, Connection.GetConnection());
                cmd.ExecuteNonQuery();
                return "Table Deleted Successfully";

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string updatetable(string i, string tableno, int capacity)
        {
            try
            {
                string query = "update Tables set TableNo ='" + tableno + "',Capacity = " + capacity + " where TableNo = '" + i + "' And Store ="+Program.shopid;
                cmd = new SqlCommand(query, Connection.GetConnection());
                cmd.ExecuteNonQuery();
                return "Table Updated Successfully";

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

    }
}
