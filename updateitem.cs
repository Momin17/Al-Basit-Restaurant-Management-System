using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GDL
{
    public partial class updateitem : Form
    {
        public updateitem(string s)
        {
            InitializeComponent();
            label1.Text = s;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text != "" && metroTextBox2.Text != "" && metroTextBox4.Text != "")
            {
                if (Convert.ToInt32(metroTextBox5.Text) < Convert.ToInt32(metroTextBox4.Text))
                {
                        item i = new item();
                        MessageBox.Show(i.updateitem(Convert.ToInt32(label1.Text), metroTextBox1.Text, metroTextBox2.Text, Convert.ToDouble(metroTextBox4.Text), Convert.ToDouble(metroTextBox5.Text), ava.Text));
                        metroTextBox1.Text = "";
                        metroTextBox2.Text = "";
                        ava.Text = "";
                        metroTextBox4.Text = "";
                        metroTextBox5.Text = "";
                  
                }
                else
                {
                    MessageBox.Show("Price Should Be Greater Than Cost!");
                }
            }
            else
            {
                MessageBox.Show("Insert The Values Please...");
            }
        }

        private void updateitem_Load(object sender, EventArgs e)
        {
            string query = "select * from Items where id = " + label1.Text+" And Store ="+Program.shopid;
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                metroTextBox1.Text = rd[1].ToString();
                metroTextBox2.Text = rd[2].ToString();
                metroTextBox4.Text = rd[3].ToString();
                metroTextBox5.Text = rd[4].ToString();
                ava.Text = rd[5].ToString();
            }
            Decimal val1 = Decimal.Truncate(Convert.ToDecimal(metroTextBox4.Text));
            metroTextBox4.Text = val1.ToString();
            Decimal val2 = Decimal.Truncate(Convert.ToDecimal(metroTextBox5.Text));
            metroTextBox5.Text = val2.ToString();
            rd.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            foritem fi = new foritem();
            fi.Show();
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
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter Alphabets Only");
            }
        }

        private void metroTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter Digits Only");
            }
        }

        private void metroTextBox5_KeyPress(object sender, KeyPressEventArgs e)
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
