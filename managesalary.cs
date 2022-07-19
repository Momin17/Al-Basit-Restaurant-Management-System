using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GDL
{
    public partial class managesalary : Form
    {
        public managesalary(string s)
        {
            InitializeComponent();
            label4.Text = s;
        }
        
        public void loaddatagridforsalary()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Salary where phone ='"+label4.Text+"' And Store="+Program.shopid, Connection.GetConnection());
            DataSet ds = new DataSet();
            da.Fill(ds, "Salary");
            dataGridView1.DataSource = ds.Tables["Salary"].DefaultView;
        }
        private void managesalary_Load(object sender, EventArgs e)
        {
            int a = int.Parse(DateTime.Now.Hour.ToString());
            if (a >= 0 && a <= 6)
            {
                metroDateTime2.Text = DateTime.Parse(metroDateTime2.Text).AddDays(-1).ToString();
            }
            loaddatagridforsalary();
            getname();
            metroTextBox1.Text = label5.Text;
            metroTextBox2.Text = label4.Text;
            label9.Text = label5.Text;
        }
        public void getname()
        {
            string query = "select EName  from Employee where Phone =  " + "'" + label4.Text + "' And Store="+Program.shopid;
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                label5.Text = rd[0].ToString();
            }
            rd.Close();
        }
        private void Paysal_Click(object sender, EventArgs e)
        {
            if (metroTextBox2.Text != "" && metroTextBox3.Text != "")
             {
            //    if (dateselect == true)
            //    {
                    if (metroTextBox2.Text.Length == 11)
                    {
                        if (int.Parse(metroTextBox3.Text) > 0)
                        {
                            employee emp = new employee();
                            MessageBox.Show(emp.paysalary(metroTextBox1.Text, metroTextBox2.Text, metroTextBox3.Text, metroDateTime2.Text));
                            metroTextBox1.Text = "";
                            metroTextBox2.Text = "";
                            metroTextBox3.Text = "";
                            metroDateTime2.Text = "";
                            loaddatagridforsalary();
                        }
                        else
                        {
                            MessageBox.Show("Insert Correct Amount");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Insert Correct Phone Number");
                    }
                //}
                //else
                //{
                //    MessageBox.Show("Please select Date");
                //}
            }
            else
            {
                MessageBox.Show("Insert The Values Please...");
            }
        }
        

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
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

        private void metroTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter Digits Only");
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


      

      

        private void metroTextBox5_KeyPress(object sender, KeyPressEventArgs e)
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
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            foremplyee d = new foremplyee();
            d.Show();
            this.Hide();
        }
    }
}
