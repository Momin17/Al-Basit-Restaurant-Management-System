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

namespace GDL
{  
    public partial class paytosupply : Form
    {
        string sname, snic = "";
        public paytosupply(String s)
        {
            InitializeComponent();
            label1.Text = s;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            managesupplies ms = new managesupplies(label1.Text);
            ms.Show();
            this.Hide();
        }
        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void paytosupply_Load(object sender, EventArgs e)
        {
            checkandbalance checknBalance = new checkandbalance();
            Int64 payedtosupplier = Convert.ToInt64(checknBalance.getrate("select SUM(CAST(amount AS int))  from account where Store="+Program.shopid).ToString());
            Int64 takings = Convert.ToInt64( checknBalance.getrate("select sum(taking)  from Report where Store="+Program.shopid).ToString());
            Int64 totalvalue = takings - payedtosupplier;
           
            label9.Text = totalvalue.ToString();
            

            string query = "select Supplier_Name,Supplier_NIC,Total,Paid,Balance from record where Supplier_NIC = " + label1.Text + " And Store="+Program.shopid;
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                sname = rd[0].ToString();
                snic = rd[1].ToString();
                mta.Text = rd[2].ToString();
                mtpaid.Text = rd[3].ToString();
                mtb.Text = rd[4].ToString();
            }
            rd.Close();
        }

        private void paying_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter Digits Only");
            }
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            if(mta.Text != "" && mtb.Text != "" && mtpaid.Text != "" && paying.Text != "")
            {
             
                        int balance = int.Parse(mtb.Text) - int.Parse(paying.Text);
                        int total = int.Parse(paying.Text) + int.Parse(mtpaid.Text);
                        supply s = new supply();
                        acc a = new acc();
                        a.addpayment(sname, snic, int.Parse(paying.Text), metroDateTime1.Text);
                        MessageBox.Show(s.paysupply(Convert.ToString(total), Convert.ToString(balance), label1.Text));
                        mtb.Text = "";
                        mta.Text = "";
                        paying.Text = "";
                        mtpaid.Text = "";
                
                
                
            }
            else
            {
                MessageBox.Show("Please Insert the Values");
            }
        }
    }
}
