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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dashboard d = new dashboard();
            d.Show();
            this.Hide();
        }
        public void loaddatagrid()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT TableNo as [Table],Capacity FROM Tables where Store="+Program.shopid, Connection.GetConnection());
            DataSet ds = new DataSet();
            da.Fill(ds, "Tables");
            dataGridView1.DataSource = ds.Tables["Tables"].DefaultView;
        }
        private void btnaddc_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text != "" && metroTextBox2.Text != "")
            {
                if (int.Parse(metroTextBox2.Text) > 0)
                {
                    delievery de = new delievery();
                    MessageBox.Show(de.addtables(metroTextBox1.Text, int.Parse(metroTextBox2.Text)));
                    metroTextBox1.Text = "";
                    metroTextBox2.Text = "";
                    loaddatagrid();
                }
                else
                {
                    MessageBox.Show("Please Enter Valid Capacity");
                }
            }
            else
            {
                MessageBox.Show("Insert the Values Please");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                UpdateTable ui = new UpdateTable(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                this.Hide();
                ui.Show();
                label1.Text = "";
            }
            else
            {
                MessageBox.Show("Please Select The Area To Edit");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loaddatagrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                DialogResult dr = MessageBox.Show("Delete Table " + label1.Text, " Are You Sure?", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    delievery de = new delievery();
                    MessageBox.Show(de.deleteTable(label1.Text));
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
    }
}
