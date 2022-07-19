using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GDL
{
    class employee
    {
        SqlCommand cmd;
        public string paysalary(string name,string phone,string amount,string date)
        {
            try
            {
                string query = "insert into Salary values ('" + name + "','" + phone + "','" + amount + "','" + date + "',"+Program.shopid+")";
                cmd = new SqlCommand(query, Connection.GetConnection());
                cmd.ExecuteNonQuery();
                return "Paid Successfully";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string addemployee(string name, string phone, string age,string nic)
        {
            try
            {
                string query = "insert into Employee values ('" + name + "','" + phone + "','" + age + "','"+nic +"', "+Program.shopid+")";
                cmd = new SqlCommand(query, Connection.GetConnection());
                cmd.ExecuteNonQuery();
                return "Employee Added Successfully";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string deleteemployee(string i)
        {
            try
            {
                string query = "delete from Employee where Phone = '" + i + "' And Store ="+Program.shopid;
                cmd = new SqlCommand(query, Connection.GetConnection());
                cmd.ExecuteNonQuery();
                return "Employee Deleted Successfully";

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string updateemploee(string name, string phone, string age, string nic,string id)
        {
            try
            {
                string query = "update Employee set EName ='" + name + "', Phone = '" + phone + "', Age = '" + age + "',nic = '" + nic + "' where Phone = " + "'"+id+"' And Store="+Program.shopid;
                cmd = new SqlCommand(query, Connection.GetConnection());
                cmd.ExecuteNonQuery();
                return "Employee Updated Successfully";

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
