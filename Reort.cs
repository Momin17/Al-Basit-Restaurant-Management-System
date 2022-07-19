using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace GDL
{
    public partial class Reort : Form
    {
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        string abcd;
        public Reort()
        {
            InitializeComponent();
        }


      
      
        public void loadtotalsalary()
        {
            string query = "SELECT SUM(CAST(Amount AS int)) FROM Salary where Issue_date = cast(getdate() as date) And Store="+Program.shopid;
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                label6.Text = rd[0].ToString();
            }
            rd.Close();
        }
        public void loadlastleftondrawer()
        {
            string query = "SELECT TOP 1 ondrawer FROM Report where Store="+Program.shopid+" ORDER BY Id DESC ";//daraz mai jo chora tha
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                abcd = rd[0].ToString();
            }
            rd.Close();
        }
        public void loadlasttaking()
        {
            string query = "select sum(taking) from Report where date = (cast(getdate() as date)) And Store="+Program.shopid;//taking jo kia
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                label18.Text = rd[0].ToString();
            }
            rd.Close();
        }
        public void loadtotalsale()
        {
            string query = "SELECT SUM(CAST(Price AS int)) FROM Sales where date  = cast(getdate() as date)  And Store="+Program.shopid;// todays sale
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                label8.Text = rd[0].ToString();
            }
            rd.Close();

            if (label8.Text == "")
            {
                label8.Text = "0";
                label10.Text = "0";
            }
        }
        public void loadleftsale()
        {
            checkandbalance ch = new checkandbalance();
            double num = ch.getrate("select Count(*) from Report where date  = cast(getdate() as date) And Store="+Program.shopid);
            //if (label3.Text != "" && label6.Text != "")
            //{
            //    if (int.Parse(label18.Text) != 0)
            //    {
            //        int a = int.Parse(label8.Text);
            //        int b = int.Parse(label3.Text) + int.Parse(label6.Text);
            //        int c = a - b;
            //        c = c + int.Parse(label4.Text) - int.Parse(label18.Text);
            //        label10.Text = c.ToString();
            //    }
            //    else
            //    {
            //        int a = int.Parse(label8.Text);
            //        int b = int.Parse(label3.Text) + int.Parse(label6.Text);
            //        int c = a - b;
            //        c = c + int.Parse(label4.Text);
            //        label10.Text = c.ToString();
            //    }
            //}
            //else
            //{
            //    int a = int.Parse(label8.Text);
            //    a = a + int.Parse(label4.Text);
            //    label10.Text = a.ToString();
            //}
            int sale;
            int expense;
            int wages;
            if (label8.Text != "")
            {
                sale = int.Parse(label8.Text);
            }
            else
            {
                sale = 0;
                label8.Text = "0";
            }
            if (label3.Text != "")
            {
                expense = int.Parse(label3.Text);
            }
            else
            {
                expense = 0;
                label3.Text = "0";
            }
            if (label6.Text != "")
            {
                wages = int.Parse(label6.Text);
            }
            else
            {
                wages = 0;
                label6.Text = "0";
            }
            int exp_plus_wage = expense + wages;
            int leftsale = sale - exp_plus_wage;
            leftsale = leftsale + int.Parse(abcd);
            int taking;
            if (label18.Text != "" )
            {
                taking = int.Parse(label18.Text);
            }
            else
            {
                taking = 0;
            }
          
            if (taking == 0)
                {
                    label10.Text = leftsale.ToString();
                }
                else if (taking > 0)
                {
                    leftsale = leftsale - taking;
                    label10.Text = leftsale.ToString();
                }
        }
     

     

        private void Reort_Load(object sender, EventArgs e)
        {
            loadtotalsale();
            loadlastleftondrawer();
            loadtotalsalary();
            loadlasttaking();
            loadleftsale();
            
        }

        private void button23_Click(object sender, EventArgs e)
        {

            
            if (metroTextBox1.Text != "")
            {
                if (int.Parse(metroTextBox1.Text) <= int.Parse(label10.Text))
                {
                    int a = int.Parse(label10.Text) - int.Parse(metroTextBox1.Text);
                    report r = new report();
                    //MessageBox.Show(r.addreport(int.Parse(metroTextBox1.Text), a, int.Parse(label10.Text), dateTimePicker3.Value.Date.ToString("yyyyMMdd"),Program.username));             
                    metroTextBox1.Text = "";
                    
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dashboard d = new dashboard();
            d.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Monthlyreport mr = new Monthlyreport();
            mr.Show();
            this.Hide();
        }

      
      

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
