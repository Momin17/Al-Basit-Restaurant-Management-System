using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GDL
{
    class report
    {
        SqlCommand cmd;
        public string addreport(int tak,int ondraw,int left,string date,string name,int sale)
        {
            try
            {
                string query = "insert into Report values (" + tak + ","+ ondraw + ","+left+",'" + date + "','" + name + "',"+sale+","+Program.shopid+")";
                cmd = new SqlCommand(query, Connection.GetConnection());
                cmd.ExecuteNonQuery();
                return "Taking Added Successfully";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
