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
    public partial class foruser : Form
    {
        public foruser()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
        public void loaddatagrid()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Users where Store =" +Program.shopid, Connection.GetConnection());
            DataSet ds = new DataSet();
            da.Fill(ds, "Users");
            dg2.DataSource = ds.Tables["Users"].DefaultView;
        }

        private void foruser_Load(object sender, EventArgs e)
        {
            loaddatagrid();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            if(metroTextBox1.Text != "" && metroTextBox2.Text != "" && metroTextBox3.Text != "" && metroTextBox4.Text != "" && metroComboBox1.Text != "")
            {
                if(metroTextBox3.Text.Length == 11)
                {
                    user i = new user();
                    MessageBox.Show(i.adduser(metroTextBox1.Text, metroTextBox2.Text, metroTextBox3.Text, metroTextBox4.Text,metroComboBox1.Text));
                    metroTextBox1.Text = "";
                    metroTextBox2.Text = "";
                    metroTextBox3.Text = "";
                    metroTextBox4.Text = "";
                    metroComboBox1.Text = "";
                    loaddatagrid();
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

        private void metroTextBox7_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dg2.DataSource;
            bs.Filter = "Name like '%" + metroTextBox7.Text + "%'";
            dg2.DataSource = bs;
        }

        private void dg2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = dg2.CurrentRow.Cells[2].Value.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                DialogResult dr = MessageBox.Show("Delete Item", "Are You Sure?", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    user i = new user();
                    i.deleteuser(label1.Text);
                    label1.Text = "";
                    loaddatagrid();
                }
                else if (dr == DialogResult.No)
                {
                    label1.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please Select The Item To Delete");
            }
        }

        private void up_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                updateuser ui = new updateuser(dg2.CurrentRow.Cells[2].Value.ToString());
                this.Hide();
                ui.Show();
                label1.Text = "";
            }
            else
            {
                MessageBox.Show("Please Select The Item To Edit");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            dashboard d = new dashboard();
            d.Show();
            this.Hide();
        }
    }
}
