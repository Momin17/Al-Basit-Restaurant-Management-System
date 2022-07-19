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
    public partial class account : Form
    {
        public account(string s)
        {
            InitializeComponent();
            label1.Text = s;
        }
        public void loaddatagrid()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM account where supplier_nic =" + "'" + label1.Text + "'And Store= "+Program.shopid, Connection.GetConnection());
            DataSet ds = new DataSet();
            da.Fill(ds, "account");
            dg2.DataSource = ds.Tables["account"].DefaultView;
        }
       
        private void account_Load(object sender, EventArgs e)
        {
            loaddatagrid();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            managesupplies d = new managesupplies(label1.Text);
            d.Show();
            this.Hide();
        }
    }
}
