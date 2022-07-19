using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;

namespace GDL
{
    public partial class Reporting : Form
    {
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        string exp, sale, wages, taking;
        public Reporting()
        {
            InitializeComponent();
        }
        checkandbalance c = new checkandbalance();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = s1.search("select Invoice_No as [Order No],Name as Item ,Qty as Quantity,Price as Value ,Sale_Type as [Order Type],date,username as [User] from Sales where Order_Status ='Paid' And date between '" + metroDateTime4.Value.ToString("yyyyMMdd") + "' and '" + metroDateTime3.Value.ToString("yyyyMMdd") + "' And Store="+Program.shopid+" order by Invoice_No");

            label4.Text = "Total";
            label6.Text = c.getrate("select Sum(Price) from Sales where Order_Status = 'Paid' And date between '" + metroDateTime4.Value.ToString("yyyyMMdd") + "' and '" + metroDateTime3.Value.ToString("yyyyMMdd") + "' And Store ="+Program.shopid).ToString();
            label7.Text = "QTY Sold : ";
            label9.Text = c.getrate("select Sum(Qty) from Sales where Order_Status = 'Paid' And date between '" + metroDateTime4.Value.ToString("yyyyMMdd") + "' and '" + metroDateTime3.Value.ToString("yyyyMMdd") + "' And Store="+Program.shopid).ToString();


        }
        Select s1 = new Select();
        private void metroTextBox1_TabIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (metroTextBox1.Text != "")
                {
                    dataGridView2.DataSource = s1.search("select Name as Item ,Qty as Quantity,Price as Value ,Sale_Type as [Order Type],date,username as [User] from Sales where Invoice_No =" + metroTextBox1.Text+" And Store ="+Program.shopid);

                }
                if (metroTextBox1.Text == "")
                {

                    this.dataGridView2.DataSource = null;
                }

                
            }
            catch (Exception ex)
            {
                
            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = s1.search("select Name,Price as Amount,Person,date from Expenses where date between '" + metroDateTime4.Value.ToString("yyyyMMdd") + "' and '" + metroDateTime3.Value.ToString("yyyyMMdd") + "' And Store="+Program.shopid+" order by date desc");
            label4.Text = "Total";
            label6.Text = c.getrate("select Sum(CAST(Price AS int)) from Expenses where date between '" + metroDateTime4.Value.ToString("yyyyMMdd") + "' and '" + metroDateTime3.Value.ToString("yyyyMMdd") + "' And Store="+Program.shopid).ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = s1.search("select Name,Amount,Issue_date as date from Salary where Issue_date between '" + metroDateTime4.Value.ToString("yyyyMMdd") + "' and '" + metroDateTime3.Value.ToString("yyyyMMdd") + "' And Store="+Program.shopid+"  order by Issue_date");
            label4.Text = "Total";
            label6.Text = c.getrate("select Sum(CAST(Amount AS int)) Amount from Salary where Issue_date between '" + metroDateTime4.Value.ToString("yyyyMMdd") + "' and '" + metroDateTime3.Value.ToString("yyyyMMdd") + "' And Store="+Program.shopid).ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = s1.search("select * from Report where Date between '" + metroDateTime4.Value.ToString("yyyyMMdd") + "' and '" + metroDateTime3.Value.ToString("yyyyMMdd") + "' And Store="+Program.shopid+"  order by Date");
            label4.Text = "Total";
            label6.Text = c.getrate("select Sum(taking) from Report where Date between '" + metroDateTime4.Value.ToString("yyyyMMdd") + "' and '" + metroDateTime3.Value.ToString("yyyyMMdd") + "' And Store="+Program.shopid).ToString();



        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = s1.search("select Invoice_No as [Order No],Name as Item ,Qty as Quantity,Price as Value ,Sale_Type as [Order Type],date,username as [User] from Sales where Order_Status ='Paid' And Sale_Type='Delivery' and date between '" + metroDateTime4.Value.ToString("yyyyMMdd") + "' and '" + metroDateTime3.Value.ToString("yyyyMMdd") + "'  And Store ="+Program.shopid+" order by Invoice_No");
            label4.Text = "Total";
            label6.Text = c.getrate("select Sum(Price) from Sales where Order_Status ='Paid' And Sale_Type='Delivery' and date between '" + metroDateTime4.Value.ToString("yyyyMMdd") + "' and '" + metroDateTime3.Value.ToString("yyyyMMdd") + "' And Store="+Program.shopid).ToString();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = s1.search("select Invoice_No as [Order No],Name as Item ,Qty as Quantity,Price as Value ,Sale_Type as [Order Type],date,username as [User] from Sales where Order_Status ='Paid' And Sale_Type='DineIn' and date between '" + metroDateTime4.Value.ToString("yyyyMMdd") + "' and '" + metroDateTime3.Value.ToString("yyyyMMdd") + "' And Store="+Program.shopid+" order by Invoice_No");
            label4.Text = "Total";
            label6.Text = c.getrate("select Sum(Price) from Sales where Order_Status ='Paid' And Sale_Type='DineIn' and date between '" + metroDateTime4.Value.ToString("yyyyMMdd") + "' and '" + metroDateTime3.Value.ToString("yyyyMMdd") + "' And Store ="+Program.shopid).ToString();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = s1.search("select Invoice_No as [Order No],Name as Item ,Qty as Quantity,Price as Value ,Sale_Type as [Order Type],date,username as [User] from Sales where Order_Status ='Paid' And Sale_Type='TakeAway' and date between '" + metroDateTime4.Value.ToString("yyyyMMdd") + "' and '" + metroDateTime3.Value.ToString("yyyyMMdd") + "'  And Store ="+Program.shopid+" order by Invoice_No");
            label4.Text = "Total";
            label6.Text = c.getrate("select Sum(Price) from Sales where Order_Status ='Paid' And  Sale_Type='TakeAway' and date between '" + metroDateTime4.Value.ToString("yyyyMMdd") + "' and '" + metroDateTime3.Value.ToString("yyyyMMdd") + "' And Store="+Program.shopid).ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dashboard d = new dashboard();
            d.Show();
            this.Hide();
        }
        public void loatlastmonthsale()
        {
            string query = "SELECT SUM(Price) FROM Sales where date between '" + metroDateTime4.Value.ToString("yyyyMMdd") + "' and '" + metroDateTime3.Value.ToString("yyyyMMdd") + "' And Store ="+Program.shopid;
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                sale = rd[0].ToString() + " Rs";
            }
            rd.Close();
        }
        public void last30daysexpense()
        {
            string query = "SELECT SUM(CAST(Price AS int)) FROM Expenses where date between '" + metroDateTime4.Value.ToString("yyyyMMdd") + "' and '" + metroDateTime3.Value.ToString("yyyyMMdd") + "' And Store="+Program.shopid;
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                exp = rd[0].ToString() + " Rs";
            }
            rd.Close();
        }
        public void loatlastmonthwages()
        {
            string query = "SELECT SUM(CAST(Amount AS int)) FROM Salary where Issue_date between '" + metroDateTime4.Value.ToString("yyyyMMdd") + "' and '" + metroDateTime3.Value.ToString("yyyyMMdd") + "' And Store="+Program.shopid;
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
               wages = rd[0].ToString() + " Rs";
            }
            rd.Close();
        }

        private void Reporting_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = s1.search("select Invoice_No as [Order No],Name as Item ,Qty as Quantity,Price as Value ,Sale_Type as [Order Type],date,username as [User] from Sales where Order_Status ='Unpaid' And date between '" + metroDateTime4.Value.ToString("yyyyMMdd") + "' and '" + metroDateTime3.Value.ToString("yyyyMMdd") + "' And Store="+Program.shopid+" order by Invoice_No");

            label4.Text = "Total";
            label6.Text = c.getrate("select Sum(Price) from Sales where Order_Status = 'Unpaid' And date between '" + metroDateTime4.Value.ToString("yyyyMMdd") + "' and '" + metroDateTime3.Value.ToString("yyyyMMdd") + "' And Store="+Program.shopid).ToString();
            label7.Text = "QTY Sold : ";
            label9.Text = c.getrate("select Sum(Qty) from Sales where Order_Status = 'Unpaid' And date between '" + metroDateTime4.Value.ToString("yyyyMMdd") + "' and '" + metroDateTime3.Value.ToString("yyyyMMdd") + "' And Store="+Program.shopid).ToString();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = s1.search("select Invoice_No as [Order No],Name as Item ,Qty as Quantity,Price as Value ,Sale_Type as [Order Type],date,username as [User] from Sales where Order_Status ='Cancel' And date between '" + metroDateTime4.Value.ToString("yyyyMMdd") + "' and '" + metroDateTime3.Value.ToString("yyyyMMdd") + "' And Store ="+Program.shopid+" order by Invoice_No");

            label4.Text = "Total";
            label6.Text = c.getrate("select Sum(Price) from Sales where Order_Status = 'Cancel' And date between '" + metroDateTime4.Value.ToString("yyyyMMdd") + "' and '" + metroDateTime3.Value.ToString("yyyyMMdd") + "' And Store="+Program.shopid).ToString();
            label7.Text = "QTY Sold : ";
            label9.Text = c.getrate("select Sum(Qty) from Sales where Order_Status = 'Cancel' And date between '" + metroDateTime4.Value.ToString("yyyyMMdd") + "' and '" + metroDateTime3.Value.ToString("yyyyMMdd") + "' And Store="+Program.shopid).ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save as Excel File";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Excel Files(2013) |*.xlsx ";
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);
                ExcelApp.Columns.ColumnWidth = 20;

                //storing Header
                for (int i = 1; i < dataGridView2.Columns.Count + 1; i++)
                {
                    ExcelApp.Cells[1, i] = dataGridView2.Columns[i - 1].HeaderText;
                }
                //Storing each row and colum in excel sheet
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView2.Columns.Count; j++)
                    {
                        ExcelApp.Cells[i + 2, j + 1] = dataGridView2.Rows[i].Cells[j].Value.ToString();
                    }
                }
                ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                ExcelApp.ActiveWorkbook.Saved = true;
                ExcelApp.Quit();
            }
        }

        public void loatlastmonthtaking()
        {
            string query = "SELECT SUM(taking) FROM Report where date between '" + metroDateTime4.Value.ToString("yyyyMMdd") + "' and '" + metroDateTime3.Value.ToString("yyyyMMdd") + "' And Store="+Program.shopid;
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                taking = rd[0].ToString() + " Rs";
            }
            rd.Close();
        }
     
     

    }
}
