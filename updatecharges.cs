using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GDL
{
    public partial class updatecharges : Form
    {
        public updatecharges(string a)
        {
            InitializeComponent();
            label1.Text = a;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            managedelievery md = new managedelievery();
            md.Show();
            this.Hide();
        }

        private void updatecharges_Load(object sender, EventArgs e)
        {
            string query = "select * from managedel where Area_Name = '" + label1.Text + "' And Store ="+Program.shopid;
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                metroTextBox1.Text = rd[0].ToString();
                metroTextBox2.Text = rd[1].ToString();
            }
            rd.Close();
        }

        private void btnup_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text != "" && metroTextBox2.Text != "")
            {
                if (int.Parse(metroTextBox2.Text) > 0)
                {
                    delievery de = new delievery();
                    MessageBox.Show(de.updatecharges(label1.Text,metroTextBox1.Text, int.Parse(metroTextBox2.Text)));
                    metroTextBox1.Text = "";
                    metroTextBox2.Text = "";
                }
                else
                {
                    MessageBox.Show("Charges can't be zero or less than zero");
                }
            }
            else
            {
                MessageBox.Show("Insert the Values Please");
            }
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
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter Digits Only");
            }
        }
    }
}
