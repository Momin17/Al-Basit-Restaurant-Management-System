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
    public partial class updateemployee : Form
    {
        public updateemployee(string s)
        {
            InitializeComponent();
            label1.Text = s;
        }

        private void updateemployee_Load(object sender, EventArgs e)
        {
            string query = "select * from Employee where Phone = '" + label1.Text + "' And Store="+Program.shopid;
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                mtname.Text = rd[0].ToString();
                mtphone.Text = rd[1].ToString();
                mtage.Text = rd[2].ToString();
                mtnic.Text = rd[3].ToString();
            }
            rd.Close();
        }

        private void btnupdateexp_Click(object sender, EventArgs e)
        {
            if (mtname.Text != "" && mtphone.Text != "" && mtage.Text != "" && mtnic.Text != "")
            {
                if (mtphone.Text.Length == 11)
                {
                    if (mtnic.Text.Length == 13)
                    {
                        employee emp = new employee();
                        MessageBox.Show(emp.updateemploee(mtname.Text, mtphone.Text, mtage.Text, mtnic.Text, label1.Text));
                        mtname.Text = "";
                        mtphone.Text = "";
                        mtage.Text = "";
                        mtnic.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Enter Correct NIC");
                    }
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
            foremplyee fe = new foremplyee();
            fe.Show();
            this.Hide();
        }

        private void mtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter Alphabets Only");
            }
        }

        private void mtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter Digits Only");
            }
        }

        private void mtage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter Digits Only");
            }
        }

        private void mtnic_KeyPress(object sender, KeyPressEventArgs e)
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
