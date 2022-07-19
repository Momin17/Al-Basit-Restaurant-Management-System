using System;
using System.Data.SqlClient;

namespace GDL
{
    class item
    {
        SqlCommand cmd;
        public string addItem(string name, string category,  double price, double cost, string sub_Category)
        {
            try
            {
                string query = "insert into Items values ('" + name+ "','" + category + "'," + price + "," + cost + ",'" + sub_Category + "',"+Program.shopid+")";
                cmd = new SqlCommand(query, Connection.GetConnection());
                cmd.ExecuteNonQuery();
                return "Item Added Successfully";

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string updateitem(int id,string name, string category, double price, double cost, string sub_Category)
        {
            try
            {
                string query = "update Items set Name = '"+name+"', Category ='"+ category+"', Price = "+price+", Cost = "+cost+ ", isAvailable = '" + sub_Category + "'where id = " + id +" And Store ="+Program.shopid;
                cmd = new SqlCommand(query, Connection.GetConnection());
                cmd.ExecuteNonQuery();
                return "Item Updated Successfully";

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string deleteitembyid(int i)
        {
            try
            {
                string query = "delete from Items where id = " + i+" And Store ="+Program.shopid;
                cmd = new SqlCommand(query, Connection.GetConnection());
                cmd.ExecuteNonQuery();
                return "Item Deleted Successfully";

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

     
    }
}
