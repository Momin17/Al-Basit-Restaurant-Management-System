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
    public partial class Reprtform : Form
    {
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        public Reprtform()
        {
            InitializeComponent();
        }
        public void loadtotalsale()
        {
            string query = "SELECT SUM(CAST(Price AS int)) FROM Sales where date  = '" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "' And Store=" + Program.shopid;// todays sale
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                label8.Text = rd[0].ToString();
            }
            rd.Close();
        }
        public void loadtotalexpense()
        {
            string query = "SELECT SUM(CAST(Price AS int)) FROM Expenses where date = '" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "' And Store="+Program.shopid;
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                label3.Text = rd[0].ToString();
            }
            rd.Close();
        }
      
        public void totalsalary()
        {
            string query = "SELECT SUM(CAST(Amount AS int)) FROM Salary where Issue_date = '" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "' And Store="+Program.shopid;
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                label6.Text = rd[0].ToString();
            }
            rd.Close();
        }
        public void loadleftsale()
        {
            if (label3.Text == "")
            {
                label3.Text = "0";
            }
            if (label6.Text == "")
            {
                label6.Text = "0";
            }
            if (label8.Text == "")
            {
                label8.Text = "0";
            }
            if (label10.Text == "")
            {
                label10.Text = "0";
            }
            if (label13.Text == "")
            {
                label13.Text = "0";
            }
            int totalsale = int.Parse(label8.Text);
            int exp = int.Parse(label3.Text);
            int wages = int.Parse(label6.Text);
            int leftsale = totalsale - (exp + wages);
            label10.Text = leftsale.ToString();
        }
        public void loadlastleftondrawer()
        {
            string query = "SELECT TOP 1 ondrawer FROM Report where Store="+Program.shopid+" ORDER BY Id DESC ";//daraz mai jo chora tha
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                label4.Text = rd[0].ToString();
            }
            rd.Close();
        }
        public void loadlplusl()
        {
           int p = int.Parse(label10.Text) + int.Parse(label4.Text);
            label13.Text = p.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dashboard d = new dashboard();
            d.Show();
            this.Hide();
        }

        private void Reprtform_Load(object sender, EventArgs e)
        {
            
            
            int a = int.Parse(DateTime.Now.Hour.ToString());
                if (a >= 0 && a <= 6)
                {
                    dateTimePicker1.Text = DateTime.Parse(dateTimePicker1.Text).AddDays(-1).ToString();
                }
                if (label3.Text == "")
                {
                    label3.Text = "0";
                }
                if (label6.Text == "")
                {
                    label6.Text = "0";
                }
                if (label8.Text == "")
                {
                    label8.Text = "0";
                }
                if (label10.Text == "")
                {
                    label10.Text = "0";
                }
                if (label13.Text == "")
                {
                    label13.Text = "0";
                }
                loadtotalsale();
                loadtotalexpense();
                totalsalary();
                loadlastleftondrawer();
                loadleftsale();
                loadlplusl();
            
        }

        private void button23_Click(object sender, EventArgs e)
        {
           
                if (metroTextBox1.Text != "")
                {
                    if (int.Parse(metroTextBox1.Text) <= int.Parse(label13.Text))
                    {
                        int a = int.Parse(label10.Text) - int.Parse(metroTextBox1.Text);
                        report r = new report();
                        MessageBox.Show(r.addreport(int.Parse(metroTextBox1.Text), a, int.Parse(label10.Text), dateTimePicker1.Value.Date.ToString("yyyyMMdd"), Program.username, int.Parse(label8.Text)));
                        
                    
              
                    dashboard dash = new dashboard();
                    dash.Show();
                    this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Taking amount is more than amount on drawer");
                    }

                }
                else
                {
                    MessageBox.Show("Enter Taking Amount");
                }
            }
     
    }
}
