using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace GDL
{
    public partial class Monthlyreport : Form
    {
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        public Monthlyreport()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reort r = new Reort();
            r.Show();
            this.Hide();
        }
        public void loadsale()
        {         
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM sales where date >= DATEADD(day, -30, GETDATE())  And Store ="+Program.shopid, Connection.GetConnection());
            DataSet ds = new DataSet();
            da.Fill(ds, "sales");
            dgall.DataSource = ds.Tables["sales"].DefaultView;
        }
        public void loadexpense()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Expenses where date >= DATEADD(day, -30, GETDATE()) And Store ="+Program.shopid, Connection.GetConnection());
            DataSet ds = new DataSet();
            da.Fill(ds, "Expenses");
            dgall.DataSource = ds.Tables["Expenses"].DefaultView;
        }
        public void loadlabour()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM salary where Issue_date >= DATEADD(day, -30, GETDATE()) And Store ="+Program.shopid, Connection.GetConnection());
            DataSet ds = new DataSet();
            da.Fill(ds, "salary");
            dgall.DataSource = ds.Tables["salary"].DefaultView;
        }
        public void loadreport()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM report where date >= DATEADD(day, -30, GETDATE()) And Store= "+Program.shopid, Connection.GetConnection());
            DataSet ds = new DataSet();
            da.Fill(ds, "report");
            dgall.DataSource = ds.Tables["report"].DefaultView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = "Last 30 Days Sale:";
            loadsale();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label5.Text = "Last 30 Days Expenses:";
            loadexpense();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = "Last 30 Days Wages:";
            loadlabour();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = "Last 30 Days Taking/ Withdraw:";
            loadreport();
        }
        public void loatlastmonthsale()
        {
            string query = "SELECT SUM(Price) FROM Sales where Store="+Program.shopid+" GROUP BY MONTH(date) ORDER BY  MONTH(date)";
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                label8.Text = rd[0].ToString() + " Rs";
            }
            rd.Close();
        }
        public void loatlastmonthexpense()
        {
            string query = "SELECT SUM(CAST(Price AS int)) FROM Expenses where Store=" + Program.shopid + " GROUP BY MONTH(date) ORDER BY  MONTH(date)";
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                label3.Text = rd[0].ToString() + " Rs";
            }
            rd.Close();
        }
        public void loatlastmonthwages()
        {
            string query = "SELECT SUM(CAST(Amount AS int)) FROM Salary where Store=" + Program.shopid + " GROUP BY MONTH(Issue_date) ORDER BY  MONTH(Issue_date)";
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                label6.Text = rd[0].ToString() + " Rs";
            }
            rd.Close();
        }
        public void loatlastmonthtakingandondrawer()
        {
            string query = "SELECT SUM(taking),sum(ondrawer) FROM Report where Store=" + Program.shopid + " GROUP BY MONTH(Date) ORDER BY  MONTH(Date)";
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                label10.Text = rd[0].ToString() + " Rs";
                label4.Text = rd[1].ToString() + " Rs";
            }
            rd.Close();
        }
        public void loadbetweendatesale()
        {
            string query = "SELECT SUM(Price) FROM Sales where date between '" +metroDateTime1.Value.Date.ToString("yyyyMMdd") + "' and '" + metroDateTime2.Value.Date.ToString("yyyyMMdd") + "' And Store="+Program.shopid;
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                label18.Text = rd[0].ToString() + " Rs";
            }
            rd.Close();
        }
        public void loadbetweendateexpense()
        {
            string query = "SELECT SUM(CAST(Price AS int)) FROM Expenses where date between '" + metroDateTime1.Value.Date.ToString("yyyyMMdd") + "' and '" + metroDateTime2.Value.Date.ToString("yyyyMMdd") + "' And Store="+Program.shopid;
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                label22.Text = rd[0].ToString() + " Rs";
            }
            rd.Close();
        }
        public void loadbetweendatewages()
        {
            string query = "SELECT SUM(CAST(Amount AS int)) FROM Salary where Issue_date between '" + metroDateTime1.Value.Date.ToString("yyyyMMdd") + "' and '" + metroDateTime2.Value.Date.ToString("yyyyMMdd") + "' And Store="+Program.shopid;
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                label20.Text = rd[0].ToString() + " Rs";
            }
            rd.Close();
        }
        public void loadbetweendatetakingandondrawer()
        {
            string query = "SELECT SUM(taking),sum(ondrawer) FROM Report where date between '" + metroDateTime1.Value.Date.ToString("yyyyMMdd") + "' and '" + metroDateTime2.Value.Date.ToString("yyyyMMdd") + "' And Store="+Program.shopid;
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                label16.Text = rd[0].ToString() + " Rs";
                label13.Text = rd[1].ToString() + " Rs";
            }
            rd.Close();
        }
        private void Monthlyreport_Load(object sender, EventArgs e)
        {
            loatlastmonthsale();
            loatlastmonthexpense();
            loatlastmonthwages();
            loatlastmonthtakingandondrawer();
        }

        private void metroDateTime2_ValueChanged(object sender, EventArgs e)
        {
            loadbetweendatesale();
            loadbetweendateexpense();
            loadbetweendatewages();
            loadbetweendatetakingandondrawer();
        }

      
      
    }
}
