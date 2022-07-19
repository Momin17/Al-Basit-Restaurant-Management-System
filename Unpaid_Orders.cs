using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDL
{
    public partial class Unpaid_Orders : Form
    {
        public Unpaid_Orders()
        {
            InitializeComponent();
        }
        bool val = true;
        private void Unpaid_Orders_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = s.search("select Invoice_NO, Sum(Price) as [Total Value],Sum(Qty) as [Quantity],date, username  from Sales where Order_Status ='Unpaid' And Store="+Program.shopid+" group by Invoice_NO, date,username");

        }
        Select s = new Select();
        checkandbalance c = new checkandbalance();
        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (metroTextBox1.Text != "")
                {
                    dataGridView2.DataSource = s.search("select Name,Qty as [Quantity], Price as [Sale]  from Sales  where Invoice_No =" + metroTextBox1.Text)+"And Store ="+Program.shopid;
                    label2.Text = c.getrate("select Sum(Price) from Sales  where Invoice_No =" + metroTextBox1.Text).ToString() +" And Store ="+Program.shopid;
                    label5.Text = c.getstringvalue("select Distinct(Order_Status) from Sales  where Invoice_No =" + metroTextBox1.Text)+" And Store ="+Program.shopid;
                    label7.Text = c.getstringvalue("select Distinct(date) from Sales  where Invoice_No =" + metroTextBox1.Text) + " And Store =" + Program.shopid;
                    label9.Text = c.getstringvalue("select Distinct(username) from Sales  where Invoice_No =" + metroTextBox1.Text) + " And Store =" + Program.shopid;

                }
                else
                {

                    dataGridView2.Rows.Clear();
                    dataGridView2.Refresh();
                    label2.Text = "";
                    label5.Text = "";
                    label7.Text = "";
                    label9.Text = "";

                }
            }
            catch
            { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = c.getstringvalue("Select Order_Status from sales where Invoice_No = " + metroTextBox1.Text) +" And Store ="+Program.shopid;
            if (data != "")
            {

                MessageBox.Show(c.updateData("update sales set Order_Status='Paid' where Invoice_No =" + metroTextBox1.Text)+" And Store ="+Program.shopid);
                dataGridView2.DataSource = s.search("select Invoice_NO, Sum(Price) as [Total Value],Sum(Qty) as [Quantity],date, username  from Sales where Order_Status ='Unpaid'  And Store =" + Program.shopid+" group by Invoice_NO, date,username");

            }
            else if (data == "Paid")
            {

                MessageBox.Show("Order Is Already Paid");
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Order No");
            }
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
  (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            InvoiceForm f = new InvoiceForm();
            f.Show();
            this.Hide();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(val==true)
            {   metroTextBox1.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                val = false;
            }
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            val = true;
            dataGridView2.DataSource = s.search("select Invoice_NO, Sum(Price) as [Total Value],Sum(Qty) as [Quantity],date, username  from Sales where Order_Status ='Unpaid' And Store="+Program.shopid+" group by Invoice_NO, date,username");
            metroTextBox1.Text = "";
            label2.Text = "";
            label5.Text = "";
            label7.Text = "";
            label9.Text = "";
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
