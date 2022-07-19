using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GDL
{
    public partial class forexpense : Form
    {
        public forexpense()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void forexpense_Load(object sender, EventArgs e)
        {
            loaddatagrid();
            int a = int.Parse(DateTime.Now.Hour.ToString());
            if (a >= 0 && a <= 6)
            {
                metroDateTime1.Text = DateTime.Parse(metroDateTime1.Text).AddDays(-1).ToString();
            }
        }
        public void loaddatagrid()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Expenses Where Store ="+Program.shopid, Connection.GetConnection());
            DataSet ds = new DataSet();
            da.Fill(ds, "Expenses");
            dgexpense.DataSource = ds.Tables["Expenses"].DefaultView;
        }
        
        private void addexpense_Click(object sender, EventArgs e)
        {
            if(metroTextBox2.Text != "" && metroTextBox3.Text != "" && metroTextBox1.Text != "")
            {
                    expenses i = new expenses();
                    MessageBox.Show(i.addexpense(metroTextBox2.Text, metroTextBox3.Text, metroDateTime1.Text,metroTextBox1.Text));
                    metroTextBox2.Text = "";
                    metroTextBox3.Text = "";
                    metroTextBox1.Text = "";
                    metroDateTime1.Text = "";
                    loaddatagrid();
                
            }
            else
            {
                MessageBox.Show("Insert The Values Please...");
            }
        }
        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void metroTextBox7_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgexpense.DataSource;
            bs.Filter = "Name like '%" + metroTextBox7.Text + "%'";
            dgexpense.DataSource = bs;
        }

        private void deleteexpense_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                DialogResult dr = MessageBox.Show("Delete Item", "Are You Sure?", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    expenses ee = new expenses();
                    ee.deleteexpense(label1.Text);
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

         

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dashboard d = new dashboard();
            d.Show();
            this.Hide();
        }

        private void upexpense_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                updateexpense ui = new updateexpense(dgexpense.CurrentRow.Cells[0].Value.ToString());
                this.Hide();
                ui.Show();
                label1.Text = "";
            }
            else
            {
                MessageBox.Show("Please Select The Expense To Edit");
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

        private void metroTextBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter Alphabets Only");
            }
        }

        private void dgexpense_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = dgexpense.CurrentRow.Cells[0].Value.ToString();
        }

        private void metroTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter Alphabets Only");
            }
        }

        private void metroTextBox4_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgexpense.DataSource;
            bs.Filter = "Person like '%" + metroTextBox4.Text + "%'";
            dgexpense.DataSource = bs;
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
