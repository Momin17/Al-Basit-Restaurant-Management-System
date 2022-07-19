using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GDL
{
    class acc
    {
        SqlCommand cmd;
        string totaloflastsupplies = "";//add of total amount of supplies
        string totallastbalance = "";    // update total balance
       
        public string addpayment(string sname,string snic,int amout,string date)
        {
            try
            {
                string query = "insert into account values ('" + sname + "','" + snic + "','" + amout + "','" + date  +"',"+Program.shopid+")";
                cmd = new SqlCommand(query, Connection.GetConnection());
                cmd.ExecuteNonQuery();
                return "Payment Added Successfully";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string addbalpay(string sname, string snic,string t, string p,string b) // to add supplier in a record table
        {
            try
            {
                string query = "insert into record values ('" + sname + "','" + snic + "','" + t + "','" + p + "','" + b + "',"+Program.shopid+")";
                cmd = new SqlCommand(query, Connection.GetConnection());
                cmd.ExecuteNonQuery();
                return "Paid Successfully";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string updatesupplieraccount(string total,string bal, string n)//To add amount in supplier account in record table
        {
            try
            {
                string query = "select Total,Balance from record where Supplier_NIC= " + "'" + n + "' And Store =" +Program.shopid;
                cmd = new SqlCommand(query, Connection.GetConnection());
                SqlDataReader rd1 = cmd.ExecuteReader();
                while (rd1.Read())
                {
                    totaloflastsupplies = rd1[0].ToString();
                    totallastbalance = rd1[1].ToString();
                }
                rd1.Close();
                int Final = int.Parse(total) + int.Parse(totaloflastsupplies);
                int Final2 = int.Parse(bal) + int.Parse(totallastbalance);
                string query2 = "update record set Total = '" + Convert.ToString(Final) + "',Balance = '" + Convert.ToString(Final2) + "' where Supplier_NIC= " + "'" + n + "' And Store="+Program.shopid;
                cmd = new SqlCommand(query2, Connection.GetConnection());
                cmd.ExecuteNonQuery();
                return "Supplier Updated Successfully";

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
      
    }
}
