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
    public partial class suppliers : Form
    {
        public suppliers()
        {
            InitializeComponent();
            label1.Text = "";
        }
        public void loaddatagrid()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM suppliers where Store ="+Program.shopid, Connection.GetConnection());
            DataSet ds = new DataSet();
            da.Fill(ds, "suppliers");
            dgsupply.DataSource = ds.Tables["suppliers"].DefaultView;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dashboard d = new dashboard();
            d.Show();
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
                        acc ac = new acc();
                        ac.addbalpay(metroTextBox2.Text, metroTextBox5.Text, "0", "0", "0");
                        MessageBox.Show(s.addsuppliers(metroTextBox1.Text, metroTextBox2.Text, metroTextBox3.Text, metroTextBox5.Text));
                        metroTextBox1.Text = "";
                        metroTextBox2.Text = "";
                        metroTextBox3.Text = "";
                        metroTextBox5.Text = "";
                        loaddatagrid();
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

        private void metroTextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter Digits Only");
            }
        }

        private void suppliers_Load(object sender, EventArgs e)
        {
            loaddatagrid();
        }

        private void metroTextBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter Alphabets Only");
            }
        }

        private void metroTextBox7_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgsupply.DataSource;
            bs.Filter = "Name like '%" + metroTextBox7.Text + "%'";
            dgsupply.DataSource = bs;
        }

        private void dgsupply_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = dgsupply.CurrentRow.Cells[3].Value.ToString();
        }

        private void deleteexpense_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                DialogResult dr = MessageBox.Show("Delete Item", "Are You Sure?", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    supply su = new supply();
                    MessageBox.Show(su.deletesupply(label1.Text));
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
                MessageBox.Show("Please Select The Supplier To Delete");
            }
        }

        private void upexpense_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                updatesupply ue = new updatesupply(dgsupply.CurrentRow.Cells[3].Value.ToString());
                this.Hide();
                ue.Show();
                label1.Text = "";
            }
            else
            {
                MessageBox.Show("Please Select The Supplier To Edit");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                managesupplies ms = new managesupplies(dgsupply.CurrentRow.Cells[3].Value.ToString());
                ms.Show();
                this.Hide();
                label1.Text = "";
            }
            else
            {
                MessageBox.Show("Please Select The Supplier");
            }
        }
    }
}
