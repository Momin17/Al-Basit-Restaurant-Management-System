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
    public partial class updatecustomer : Form
    {
        public updatecustomer(string s)
        {
            InitializeComponent();
            label1.Text = s;
        }

        private void updatecustomer_Load(object sender, EventArgs e)
        {
            string query = "select Name,Address from Customer where Number = " + label1.Text;
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                name.Text = rd[0].ToString();
                address.Text = rd[1].ToString();
            }
            rd.Close();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            if (name.Text != "" && address.Text != "")
            {
                Sales s1 = new Sales();
                MessageBox.Show(s1.updatecustomer(name.Text, address.Text, label1.Text));
                name.Text = "";
                address.Text = "";
            }
            else
            {
                MessageBox.Show("Enter the Values");
            }
        }

        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter Alphabets Only");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CustomerForm c = new CustomerForm();
            c.Show();
            this.Hide();
        }
    }
}
