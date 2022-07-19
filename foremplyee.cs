using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GDL
{
    public partial class foremplyee : Form
    {
        public foremplyee()
        {
            InitializeComponent();
            label1.Text = "";
        }
        public void loaddatagrid()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Employee where Store ="+Program.shopid , Connection.GetConnection());
            DataSet ds = new DataSet();
            da.Fill(ds, "Employee");
            dgemployee.DataSource = ds.Tables["Employee"].DefaultView;
        }
        private void foremplyee_Load(object sender, EventArgs e)
        {
            loaddatagrid();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            if (mtname.Text != "" && mtphone.Text != "" && mtage.Text != "" && mtnic.Text != "")
            {
                if (mtphone.Text.Length == 11)
                {
                    if (mtnic.Text.Length == 13)
                    {
                        employee emp = new employee();
                        MessageBox.Show(emp.addemployee(mtname.Text, mtphone.Text, mtage.Text, mtnic.Text));
                        loaddatagrid();
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

        private void dgemployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = dgemployee.CurrentRow.Cells[1].Value.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                DialogResult dr = MessageBox.Show("Delete Item", "Are You Sure?", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    employee emp = new employee();
                    emp.deleteemployee(label1.Text);
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                updateemployee ue = new updateemployee(dgemployee.CurrentRow.Cells[1].Value.ToString());
                this.Hide();
                ue.Show();
                label1.Text = "";
            }
            else
            {
                MessageBox.Show("Please Select The Employee To Edit");
            }
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgemployee.DataSource;
            bs.Filter = "EName like '%" + metroTextBox1.Text + "%'";
            dgemployee.DataSource = bs;
        }

        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgemployee.DataSource;
            bs.Filter = "Phone like '%" + metroTextBox2.Text + "%'";
            dgemployee.DataSource = bs;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dashboard d = new dashboard();
            d.Show();
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

        private void btnsalary_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                managesalary ms = new managesalary(dgemployee.CurrentRow.Cells[1].Value.ToString());
                this.Hide();
                ms.Show();
                label1.Text = "";
            }
            else
            {
                MessageBox.Show("Please Select The Employee To Edit");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dashboard d = new dashboard();
            d.Show();
            this.Hide();
        }

        private void btninsert_Click_1(object sender, EventArgs e)
        {

            if (mtname.Text != "" && mtphone.Text != "" && mtage.Text != "" && mtnic.Text != "")
            {
                if (mtphone.Text.Length == 11)
                {
                    if (mtnic.Text.Length == 13)
                    {
                        employee emp = new employee();
                        MessageBox.Show(emp.addemployee(mtname.Text, mtphone.Text, mtage.Text, mtnic.Text));
                        loaddatagrid();
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
    }
}
