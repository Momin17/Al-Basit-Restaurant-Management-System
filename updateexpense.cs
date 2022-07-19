using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GDL
{
    public partial class updateexpense : Form
    {
        public updateexpense(string s)
        {
            InitializeComponent();
            label1.Text = s;
        }

        private void updateexpense_Load(object sender, EventArgs e)
        {
            string query = "select * from Expenses where ID = " + label1.Text + " And Store="+ Program.shopid;
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                metroTextBox2.Text = rd[1].ToString();
                metroTextBox3.Text = rd[3].ToString();
                metroDateTime1.Text = rd[2].ToString();
            }
            rd.Close();
        }

        private void btnupdateexp_Click(object sender, EventArgs e)
        {
            if(metroDateTime1.Text != "" && metroTextBox2.Text != "" && metroTextBox3.Text != "")
            {
                expenses ee = new expenses();
                MessageBox.Show(ee.updateexpense(label1.Text, metroTextBox2.Text, metroTextBox3.Text, metroDateTime1.Text));
                metroDateTime1.Text = "";
                metroTextBox2.Text = "";
                metroTextBox3.Text = "";
            }
            else
            {
                MessageBox.Show("Insert The Values Please...");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            forexpense fe = new forexpense();
            fe.Show();
            this.Hide();
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
