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
    public partial class Multi_Restaurant : Form
    {
        public Multi_Restaurant()
        {
            InitializeComponent();
        }
        Select s1 = new Select();
        bool f = false;
        private void Multi_Restaurant_Load(object sender, EventArgs e)
        {
            checkandbalance checknBalance = new checkandbalance();
            lbltotalsale.Text = checknBalance.getrate("select  Round(Sum(Price),0) from Sales s join MultiOutlets m on s.Store=m.Store  where Order_Status ='Paid' And m.Owner='" + Program.username + "'").ToString();
            label23.Text = checknBalance.getrate("select  Round(Sum(Price),0) from Sales s join MultiOutlets m on s.Store=m.Store  where Order_Status ='Paid' and date = '" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "'  And m.Owner='" + Program.username + "'").ToString();

            numofitem.Text = checknBalance.getrate(" select sum(Qty) from sales s join MultiOutlets m on s.Store=m.Store where date = '" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "' And m.Owner='" + Program.username + "'").ToString();
            label25.Text = checknBalance.getrate(" select sum(Qty) from sales s join MultiOutlets m on s.Store=m.Store where m.Owner='" + Program.username + "'").ToString();

            using (SqlDataAdapter sda = new SqlDataAdapter("SELECT MultiOutlets.Store, Outlet.Name, Outlet.Area FROM MultiOutlets JOIN Outlet ON MultiOutlets.Store = Outlet.ID where MultiOutlets.Owner = '" + Program.username + "'", Connection.GetConnection()))
            {
                //Fill the DataTable with records from Table.
                DataTable dt = new DataTable();
                sda.Fill(dt);

                //Insert the Default Item to DataTable.
                DataRow row = dt.NewRow();
                row[0] = 0;
                row[1] = "All";
                dt.Rows.InsertAt(row, 0);

                //Assign DataTable as DataSource.
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Store";
                
            }

           
          //  dataGridView1.Columns[0].Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (f == true)
            {
                dashboard m = new dashboard();
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Select a Shop");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try

            {
                f = true;
                label1.ForeColor = System.Drawing.Color.Black;
                Program.shopid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                label1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + " , " + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            }
            catch (Exception ex)
            {
                f = false;
                label1.ForeColor = System.Drawing.Color.Red;
                label1.Text = "Invalid Shop Selection !";


            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "All")
                {

                }
                else
                {
                    Program.shopid = int.Parse(comboBox1.SelectedValue.ToString());
                    dashboard m = new dashboard();
                    m.Show();
                    this.Hide();
                }
            }
            catch
            { }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
