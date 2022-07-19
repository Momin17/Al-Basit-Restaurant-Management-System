using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GDL
{
    class Sales
    {

        public void Sale_Insert(int _invoice,int barcode,string _product,int _qty,double _sale,string _saletype,string _date,string _user,string status)
        {
            string queree = "insert into Sales values (" + _invoice + "," + barcode + ",'" + _product + "'," + _qty + "," + _sale + ",'"+_saletype+"','" + _date + "','" + _user + "','" + status + "',"+Program.shopid+")";
            SqlCommand cmd = new SqlCommand(queree, Connection.GetConnection());
            cmd.ExecuteNonQuery();


        }

        public void CustomerInsert(string name,string num,string address)
        {   string queree = "insert into Customer values ('" + name + "'," + num + ",'" + address + "' ," + Program.shopid + ")";
            SqlCommand cmd = new SqlCommand(queree, Connection.GetConnection());
            cmd.ExecuteNonQuery();

        }
        public string updatecustomer(string name, string address, string num)
        {
            try
            {
                string query = "update Customer set Name ='" + name + "', Address= '" + address + "' where Number = " + num + " And Store ="+Program.shopid;
                SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
                cmd.ExecuteNonQuery();
                return "Customer Updated Successfully";

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string deletecustumer(string i)
        {
            try
            {
                string query = "delete from Customer where Number = '" + i + "' And Store="+Program.shopid;
                SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
                cmd.ExecuteNonQuery();
                return "Customer Deleted Successfully";

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public void DelSales(string mobile,int orderid,int del)
        {
            string queree = "insert into CustomerSales values ("+mobile+","+orderid+","+del+ "," + Program.shopid + ")";
            SqlCommand cmd = new SqlCommand(queree, Connection.GetConnection());
            cmd.ExecuteNonQuery();


        }


    }
}
