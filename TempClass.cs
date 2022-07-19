using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

using System.Threading.Tasks;

namespace GDL
{
    class TempClass
    {
        SqlCommand cmd;

        public void addTemp(string tableno, string orderno, string item, string qty)
        {
                string query = "insert into [Temprory table] values ('" + tableno + "'," + orderno + "," + item + " ," + qty + "," + Program.shopid + ")";
                cmd = new SqlCommand(query, Connection.GetConnection());
                cmd.ExecuteNonQuery();
            
        }

        public void Delete(string table, int order)
        {

            string query = "delete from [Temprory table] where TableNo ='"+table+"' And OrderNo="+order +" And Store ="+Program.shopid;
            cmd = new SqlCommand(query, Connection.GetConnection());
            cmd.ExecuteNonQuery();
        }

        public void DeleteSales(int table, int order)
        {

            string query = "delete  from Sales where Sales.username = 'Dine' And Sale_Type ="+table+" And Invoice_NO ="+order+" And Store="+Program.shopid;
            cmd = new SqlCommand(query, Connection.GetConnection());
            cmd.ExecuteNonQuery();
        }


    }
}
