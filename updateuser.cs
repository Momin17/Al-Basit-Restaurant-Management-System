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
    public partial class updateuser : Form
    {
        public updateuser(string s)
        {
            InitializeComponent();
            label1.Text = s;
        }

        private void updateuser_Load(object sender, EventArgs e)
        {
            string query = "select * from Users where Cell = " + label1.Text + " And Store="+Program.shopid;
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                metroTextBox1.Text = rd[0].ToString();
                metroTextBox2.Text = rd[1].ToString();
                metroTextBox3.Text = rd[2].ToString();
                metroTextBox4.Text = rd[3].ToString();
                metroComboBox1.Text = rd[4].ToString();
            }
            rd.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text != "" && metroTextBox2.Text != "" && metroTextBox3.Text != "" && metroTextBox4.Text != "" && metroComboBox1.Text != "")
            {
                if (metroTextBox3.Text.Length == 11)
                {
                    user i = new user();
                    MessageBox.Show(i.updateuser(metroTextBox1.Text, metroTextBox2.Text, metroTextBox3.Text, metroTextBox4.Text, metroComboBox1.Text,label1.Text));
                    metroTextBox1.Text = "";
                    metroTextBox2.Text = "";
                    metroTextBox3.Text = "";
                    metroTextBox4.Text = "";
                    metroComboBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Enter Correct Phone Number");
                }
            }
            else
            {
                MessageBox.Show("Insert The Values Please...");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            foruser fu = new foruser();
            fu.Show();
            this.Hide();
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter Alphabets Only");
            }
        }

        private void metroTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter Alphabets Only");
            }
        }

        private void metroTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter Digits Only");
            }
        }
    }
}
