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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        Select s = new Select();
        checkandbalance c = new checkandbalance();
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = s.search("Select name,number,address from Customer Where Store="+Program.shopid);

        }
        Sales s1 = new Sales();
        private void btninsert_Click(object sender, EventArgs e)
        {
            string data = c.getstringvalue("select Name from Customer where Number = " + phone.Text  +" And Store ="+Program.shopid);
            if (data == "")
            {
                if (name.Text != "" && phone.Text != "" && address.Text != "")
                {
                    if (phone.Text.Length == 11)
                    {
                        s1.CustomerInsert(name.Text, phone.Text, address.Text);
                        MessageBox.Show(" " + name.Text + " Added Succesfully");
                        dataGridView2.DataSource = s.search("Select name,number,address from Customer Where Store=" + Program.shopid);
                        name.Text = "";
                        phone.Text = "";
                        address.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Enter Correct Phone Number");
                    }
                }
                else
                {
                    MessageBox.Show("Insert the values");
                }

            }
            else
            {

                MessageBox.Show("Customer Already Exist");
            }
            
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

               string name2 = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                dataGridView2.DataSource = s.search("select Invoice_NO, Sum(Price) as [Total Value],Sum(Qty) as [Quantity],date, username  from Sales join CustomerSales on Sales.Invoice_NO=CustomerSales.OrderID where CustomerSales.Customer="+ name2 + " And Store ="+Program.shopid+" group by Invoice_NO, date,username");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (label4.Text != "")
            {
                DialogResult dr = MessageBox.Show("Delete Item", "Are You Sure?", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    s1.deletecustumer(label4.Text);
                    label4.Text = "";
                    dataGridView2.DataSource = s.search("Select name,number,address from Customer Where Store="+Program.shopid);
                }
                else if (dr == DialogResult.No)
                {
                    label4.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please Select The Item To Delete");
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label4.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (label4.Text != "")
            {
                updatecustomer ue = new updatecustomer(label4.Text);
                this.Hide();
                ue.Show();
                label4.Text = "";
            }
            else
            {
                MessageBox.Show("Please Select The Customer To Edit");
            }
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter Digits Only");
            }
        }

        private void name_KeyPress(object sender, KeyPressEventArgs e)
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

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter Alphabets Only");
            }
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            dashboard d = new dashboard();
            d.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
