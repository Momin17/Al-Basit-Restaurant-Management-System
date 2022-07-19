using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace GDL
{
    class Connection
    {
        public static SqlConnection myconn;

        public static SqlConnection GetConnection()
        {
            if (myconn == null)
            {
             
                myconn = new SqlConnection(ConfigurationManager.ConnectionStrings["my_connection"].ConnectionString);
                myconn.Open();

            }

            return myconn;
        }

    }
}
