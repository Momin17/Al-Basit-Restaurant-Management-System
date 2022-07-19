using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GDL
{
    class ChartClass
    {
        public static List<string> Category = new List<string>();
        public static List<string> QTY = new List<string>();

        public void datafetch()
        {
            try
            {

                string query = "select Items.Category,sum(Qty) as QuantitySold from Sales join Items on Items.ID = Sales.Item_ID where Sales.Order_Status !='Cancel' And Sales.Store="+Program.shopid+" group by Items.Category";


                SqlCommand comm = new SqlCommand(query, Connection.GetConnection());



                SqlDataReader reader = comm.ExecuteReader();


                while (reader.Read())
                {
                    Category.Add(reader.GetValue(0).ToString());
                    QTY.Add(reader.GetValue(1).ToString());

                }
                reader.Close();
            }
            catch
            {

            }

        }
        //SELECT YEAR(date) as SalesYear,MONTH(date) as SalesMonth, SUM(sale) AS TotalSales FROM Sales GROUP BY YEAR(date), MONTH(date) ORDER BY YEAR(date), MONTH(date)


        public static List<string> Category2 = new List<string>();
        public static List<string> QTY2 = new List<string>();

        public void datafetch2()
        {


            string query = "SELECT Month(date) as [Sales Month],day(date) as [Sales Day], SUM(Price) AS TotalSales FROM Sales where Order_Status ='Paid' And  DATEDIFF(day,date,GETDATE()) < 31 And Store="+Program.shopid+" GROUP BY Month(date), Day(date) ORDER BY Month(date), Day(date)  ";


            SqlCommand comm = new SqlCommand(query, Connection.GetConnection());



            SqlDataReader reader = comm.ExecuteReader();


            while (reader.Read())
            {
                Category2.Add(reader.GetValue(1).ToString() + "-" + reader.GetValue(0).ToString());
                QTY2.Add(reader.GetValue(2).ToString());

            }
            reader.Close();

        }
    }
}
