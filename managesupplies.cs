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
    public partial class managesupplies : Form
    {
        public managesupplies(string a)
        {
            InitializeComponent();
            label1.Text = "";
            label7.Text = a;
        }
        
        public void loaddatagrid1()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM supplies where Supplier_NIC =" + "'" + label7.Text + "' And Store="+Program.shopid, Connection.GetConnection());
            DataSet ds = new DataSet();
            da.Fill(ds, "supplies");
            dataGridView1.DataSource = ds.Tables["supplies"].DefaultView;
        }
        private void btninsert_Click(object sender, EventArgs e)
        {
            if(mtname.Text != "" && mtsname.Text != "" && mtnic.Text != "" && mtamount.Text != "" && mtdes.Text != "")
            {
                //int balanced;
                // balanced = int.Parse(mtamount.Text) - int.Parse(mtpay.Text);
                //if (int.Parse(mtamount.Text) > 0 && int.Parse(mtpay.Text) >= 0)
                if (int.Parse(mtamount.Text) != 0)
                {
                    
                        supply s = new supply();
                        acc a = new acc();
                        a.updatesupplieraccount(mtamount.Text,mtamount.Text, mtnic.Text);
                        MessageBox.Show(s.addsupplies(mtname.Text, mtsname.Text, mtnic.Text, mtamount.Text, mtdes.Text, metroDateTime1.Text));
                        mtname.Text = "";
                        mtamount.Text = "";
                        mtdes.Text = "";
                        mtnic.Text = "";
                        mtsname.Text = "";
                        loaddatagrid1();
                        gettotal();
                        getpaid();
                        getremaining();
                 
                }
                else
                {
                    MessageBox.Show("Invalid Amount");
                } 
            }
            else
            {
                MessageBox.Show("Insert the values please");
            }
        }

        private void managesupplies_Load(object sender, EventArgs e)
        {
            int a = int.Parse(DateTime.Now.Hour.ToString());
            if (a >= 0 && a <= 6)
            {
                metroDateTime1.Text = DateTime.Parse(metroDateTime1.Text).AddDays(-1).ToString();
            }
            loaddatagrid1();
            getname();
            gettotal();
            getpaid();
            getremaining();
            mtsname.Text = label9.Text;
            mtnic.Text = label7.Text;
        }
        
           // mtsname.Text = dg2.CurrentRow.Cells[1].Value.ToString();
         //   mtnic.Text = dg2.CurrentRow.Cells[3].Value.ToString();
        
        
        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
           
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                updatesupplies us = new updatesupplies(label1.Text);
                us.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a supply to Edit");
            }
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
        private void mtamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter Digits Only");
            }
        }
        private void mtpay_KeyPress(object sender, KeyPressEventArgs e)
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
            
                paytosupply pus = new paytosupply(label7.Text);
                pus.Show();
                this.Hide();
            
        }

        

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "Name like '%" + metroTextBox1.Text + "%'";
            dataGridView1.DataSource = bs;
        }

        public void gettotal()
        {
            string query = "select Total from record where Supplier_NIC =  " + "'" + label7.Text + "' And Store ="+Program.shopid;
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                label6.Text = rd[0].ToString() + " Rs";
            }
            rd.Close();
        }
        public void getpaid()
        {
            string query = "select Paid  from record where Supplier_NIC =  " + "'" + label7.Text + "' And Store="+Program.shopid;
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                label10.Text = rd[0].ToString() + " Rs";
            }
            rd.Close();
        }
        public void getname()
        {
            string query = "select Name  from suppliers where NIC =  " + "'" + label7.Text + "' And Store ="+Program.shopid;
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                label9.Text = rd[0].ToString();
            }
            rd.Close();
        }
        public void getremaining()
        {
            string query = "select Balance  from record where Supplier_NIC =  " + "'" + label7.Text + "' And Store="+Program.shopid;
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                label12.Text = rd[0].ToString() + " Rs";
            }
            rd.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            account a = new account(label7.Text);
            a.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            suppliers s = new suppliers();
            s.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
