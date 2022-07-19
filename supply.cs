using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GDL
{
    class supply
    {
        SqlCommand cmd;
        public string addsuppliers(string uname,string name,string cell,string nic)
        {
            try
            {
                string query = "insert into suppliers values ('" + uname + "','" + name + "','" + cell + "','" + nic + "'," + Program.shopid + ")";
                cmd = new SqlCommand(query, Connection.GetConnection());
                cmd.ExecuteNonQuery();
                return "Supplier Added Successfully";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string deletesupply(string i)
        {
            try
            {
                string query = "delete from suppliers where NIC = '" + i + "' And Store="+Program.shopid;
                cmd = new SqlCommand(query, Connection.GetConnection());
                cmd.ExecuteNonQuery();
                return "Supplier Deleted Successfully";

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string updatesupplier(string uname, string name,string cell,string nic,string n)
        {
            try
            {
                string query = "update suppliers set UserName ='" + uname + "',Name = '" + name + "',Cell = '" + cell + "',NIC = '" + nic + "' where NIC= " + "'" + n + "' And Store="+Program.shopid;
                cmd = new SqlCommand(query, Connection.GetConnection());
                cmd.ExecuteNonQuery();
                return "Supplier Updated Successfully";

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string updatesupplierbalpay(string name,string nic, string n)//To update supplier of balpay table
        {
            try
            {
                string query = "update record set Supplier_Name = '" + name + "',Supplier_NIC = '" + nic + "' where Supplier_NIC= " + "'" + n + "' And Store="+Program.shopid;
                cmd = new SqlCommand(query, Connection.GetConnection());
                cmd.ExecuteNonQuery();
                return "Supplier Updated Successfully";

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string addsupplies(string name,string sname,string snic,string amount, string des, string date)
        {
            try
            {
                string query = "insert into supplies values ('" + name + "','" + sname + "','" + snic + "','" + amount + "','" + des + "','" + date + "'," + Program.shopid + ")";
                cmd = new SqlCommand(query, Connection.GetConnection());
                cmd.ExecuteNonQuery();
                return "Supplies Added Successfully";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string updatesupplies(string name, string sname, string snic,string des, string date, string id)
        {
            try
            {
                string query = "update supplies set Name ='" + name + "',Supplier_Name = '" + sname + "',Supplier_NIC = '" + snic + "',Description = '" + des + "',Date = '" + date +"' where Id= " + "'" + id + "' And Store ="+Program.shopid;
                cmd = new SqlCommand(query, Connection.GetConnection());
                cmd.ExecuteNonQuery();
                return "Supplies Updated Successfully";

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string paysupply(string pay,string bal,string id)
        {
            try
            {
                string query = "update record set Paid = '" + pay + "',Balance = '" + bal + "' where Supplier_NIC= " + "'" + id + "' And Store="+Program.shopid;
                cmd = new SqlCommand(query, Connection.GetConnection());
                cmd.ExecuteNonQuery();
                return "Paid Successfully";

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
