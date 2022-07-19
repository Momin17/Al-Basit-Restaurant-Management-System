using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GDL
{
    public partial class updatesupply : Form
    {
        public updatesupply(string s)
        {
            InitializeComponent();
            label1.Text = s;
        }

        private void updatesupply_Load(object sender, EventArgs e)
        {
            string query = "select * from suppliers where NIC = " + label1.Text + " And Store="+Program.shopid;
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                metroTextBox1.Text = rd[0].ToString();
                metroTextBox2.Text = rd[1].ToString();
                metroTextBox3.Text = rd[2].ToString();
                metroTextBox5.Text = rd[3].ToString();
            }
            rd.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            suppliers s = new suppliers();
            s.Show();
            this.Hide();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text != "" && metroTextBox2.Text != "" && metroTextBox3.Text != "" && metroTextBox5.Text != "")
            {
                if (metroTextBox3.Text.Length == 11)
                {
                    if (metroTextBox5.Text.Length == 13)
                    {
                        supply s = new supply();
                        s.updatesupplierbalpay(metroTextBox2.Text, metroTextBox5.Text, label1.Text);
                        MessageBox.Show(s.updatesupplier(metroTextBox1.Text, metroTextBox2.Text, metroTextBox3.Text, metroTextBox5.Text,label1.Text));
                        metroTextBox1.Text = "";
                        metroTextBox2.Text = "";
                        metroTextBox3.Text = "";
                        metroTextBox5.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Please Enter correct nic");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter correct phone number");
                }
            }
            else
            {
                MessageBox.Show("Please insert the values");
            }
        }
    }
}
