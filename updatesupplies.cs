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
    public partial class updatesupplies : Form
    {
       
        public updatesupplies(string s)
        {
            InitializeComponent();
            label1.Text = s;
        }
        public void loaddatagrid()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM suppliers And Store="+ Program.shopid, Connection.GetConnection());
            DataSet ds = new DataSet();
            da.Fill(ds, "suppliers");
            dg2.DataSource = ds.Tables["suppliers"].DefaultView;
        }
        private void updatesupplies_Load(object sender, EventArgs e)
        {
            loaddatagrid();
            string query = "select * from supplies where Id = " + label1.Text + " And Store="+Program.shopid;
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                mtname.Text = rd[1].ToString();
                mtsname.Text = rd[2].ToString();
                mtnic.Text = rd[3].ToString();
               // mtamount.Text = rd[4].ToString();
                mtdes.Text = rd[5].ToString();
                metroDateTime1.Text = rd[6].ToString();
            }
            rd.Close();
            
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
        
            if (mtname.Text != "" && mtsname.Text != "" && mtnic.Text != "" && metroDateTime1.Text != ""&& mtdes.Text != "" )
            {
               
                       if (selectdate == true)
                       {

                            supply s = new supply();
                            MessageBox.Show(s.updatesupplies(mtname.Text, mtsname.Text, mtnic.Text, mtdes.Text, metroDateTime1.Text, label1.Text));
                            mtname.Text = "";
                            mtdes.Text = "";
                            mtnic.Text = "";
                            mtsname.Text = "";
                            metroDateTime1.Text = "";
                       }
                       else
                       {
                         MessageBox.Show("Please select a date");
                       }
             }
            else
             {
                    MessageBox.Show("Enter the correct value");
             }
        }

        private void dg2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mtsname.Text = dg2.CurrentRow.Cells[1].Value.ToString();
            mtnic.Text = dg2.CurrentRow.Cells[3].Value.ToString();
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

        private void mtdes_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            managesupplies ms = new managesupplies(mtnic.Text);
            ms.Show();
            this.Hide();
        }
        bool selectdate = false;

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            selectdate = true;
        }
    }
}
