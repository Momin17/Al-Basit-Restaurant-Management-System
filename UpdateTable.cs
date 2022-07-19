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
    public partial class UpdateTable : Form
    {
        public UpdateTable(string a)
        {
            InitializeComponent();
            label1.Text = a;
        }
       
        private void btnup_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text != "" && metroTextBox2.Text != "")
            {
                if (int.Parse(metroTextBox2.Text) > 0)
                {
                    delievery de = new delievery();
                    MessageBox.Show(de.updatetable(label1.Text, metroTextBox1.Text, int.Parse(metroTextBox2.Text)));
                    metroTextBox1.Text = "";
                    metroTextBox2.Text = "";
                }
                else
                {
                    MessageBox.Show("Enter Valid Values");
                }
            }
            else
            {
                MessageBox.Show("Insert the Values Please");
            }
        }

        private void UpdateTable_Load(object sender, EventArgs e)
        {
            string query = "select * from Tables where TableNo = '" + label1.Text+"' And Store="+Program.shopid ;
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                metroTextBox1.Text = rd[0].ToString();
                metroTextBox2.Text = rd[1].ToString();
            }
            rd.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 md = new Form2();
            md.Show();
            this.Hide();
        }
    }
}
