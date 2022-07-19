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
    public partial class newshop : Form
    {
        public newshop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboard d = new dashboard();
            d.Show();
            this.Hide();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroTextBox1.Text != "" && metroTextBox8.Text != "" && metroTextBox9.Text != "" && metroTextBox10.Text != "")
                {
                    RegistrationClass rs = new RegistrationClass();
                    rs.ShopRegistration(metroTextBox1.Text, metroTextBox8.Text, metroTextBox9.Text, metroTextBox10.Text);
                    int shopid = rs.getidwithcell(metroTextBox10.Text);
                    rs.MultiShopRegistration(shopid);

                    MessageBox.Show("New Shop Created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void newshop_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select City from City", Connection.GetConnection());
            SqlDataReader reder = cmd.ExecuteReader();
            AutoCompleteStringCollection Mycollection = new AutoCompleteStringCollection();
            while (reder.Read())
            {
                Mycollection.Add(reder.GetString(0));
            }
            metroTextBox9.AutoCompleteCustomSource = Mycollection;
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

        private void metroTextBox9_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter Alphabets Only");
            }
        }

        private void metroTextBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter Digits Only");
            }
        }
    }
    }

