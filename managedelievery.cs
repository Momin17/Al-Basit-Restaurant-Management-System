using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GDL
{
    public partial class managedelievery : Form
    {
        public managedelievery()
        {
            InitializeComponent();
            label1.Text = "";
        }
        public void loaddatagrid()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM managedel where Store="+Program.shopid, Connection.GetConnection());
            DataSet ds = new DataSet();
            da.Fill(ds, "managedel");
            dataGridView1.DataSource = ds.Tables["managedel"].DefaultView;
        }
        private void managedelievery_Load(object sender, EventArgs e)
        {
            loaddatagrid();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        private void btnaddc_Click(object sender, EventArgs e)
        {
            if(metroTextBox1.Text != "" && metroTextBox2.Text != "")
            {
                if(int.Parse(metroTextBox2.Text) > 0)
                {
                    delievery de = new delievery();
                    MessageBox.Show(de.addcharges(metroTextBox1.Text,int.Parse(metroTextBox2.Text)));
                    metroTextBox1.Text = "";
                    metroTextBox2.Text = "";
                    loaddatagrid();
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                DialogResult dr = MessageBox.Show("Delete Item", "Are You Sure?", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    delievery de = new delievery();
                    MessageBox.Show(de.deletecharges(label1.Text));
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
                MessageBox.Show("Please Select The Area To Delete");
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
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
        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                updatecharges ui = new updatecharges(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                this.Hide();
                ui.Show();
                label1.Text = "";
            }
            else
            {
                MessageBox.Show("Please Select The Area To Edit");
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            dashboard fd = new dashboard();
            fd.Show();
            this.Hide();
        }
    }
}
