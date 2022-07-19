using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GDL
{
    public partial class foritem : Form
    {
        public foritem()
        {
            InitializeComponent();
            label1.Text = "";
        }
        public void loaddatagrid()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Items where Store="+Program.shopid, Connection.GetConnection());
            DataSet ds = new DataSet();
            da.Fill(ds, "Items");
            dg.DataSource = ds.Tables["Items"].DefaultView;
        }

        private void foritem_Load(object sender, EventArgs e)
        {
            loaddatagrid();

            SqlCommand cmd = new SqlCommand("Select Distinct(Category) from items where Store="+Program.shopid, Connection.GetConnection());
            SqlDataReader reder = cmd.ExecuteReader();
            AutoCompleteStringCollection Mycollection = new AutoCompleteStringCollection();
            while (reder.Read())
            {
                Mycollection.Add(reder.GetString(0));
            }
            mtcategory.AutoCompleteCustomSource = Mycollection;
        }

        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dg.DataSource;
            bs.Filter = "Category like '%" + metroTextBox2.Text + "%'";
            dg.DataSource = bs;
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dg.DataSource;
            bs.Filter = "Name like '%" + metroTextBox1.Text + "%'";
            dg.DataSource = bs;
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                DialogResult dr = MessageBox.Show("Delete Item", "Are You Sure?", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    item i = new item();
                    i.deleteitembyid(Convert.ToInt32(label1.Text));
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
                MessageBox.Show("Please Select The Item To Delete");
            }
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            if (mtname.Text != "" && mtcategory.Text != "" && mtprice.Text != "" && mtcost.Text != "")
            {
                if (Convert.ToInt32(mtcost.Text) < Convert.ToInt32(mtprice.Text))
                {
                        item items = new item();
                        MessageBox.Show(items.addItem(mtname.Text, mtcategory.Text, Convert.ToDouble(mtprice.Text), Convert.ToDouble(mtcost.Text), avail.Text));
                        mtname.Text = "";
                        mtcategory.Text = "";
                        avail.Text = "";
                        mtprice.Text = "";
                        mtcost.Text = "";
                        loaddatagrid();             
                }
                else
                {
                    MessageBox.Show("Price Should Be Greater Than Cost!");
                }
            }
            else
            {
                MessageBox.Show("Insert The Values Please...");
            }
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = dg.CurrentRow.Cells[0].Value.ToString();
        }

        private void mtcost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter Digits Only");
            }
        }

        private void mtprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter Digits Only");
            }
        }

        private void mtsubcategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter Alphabets Only");
            }
        }

        private void mtcategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter Alphabets Only");
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
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter Alphabets Only");
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                updateitem ui = new updateitem(dg.CurrentRow.Cells[0].Value.ToString());
                this.Hide();
                ui.Show();
                label1.Text = "";
            }
            else
            {
                MessageBox.Show("Please Select The Item To Edit");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dashboard d = new dashboard();
            d.Show();
            this.Hide();
        }

        private void btninsert_Click_1(object sender, EventArgs e)
        {

            if (mtname.Text != "" && mtcategory.Text != "" && mtprice.Text != "" && mtcost.Text != "")
            {
                if (Convert.ToInt32(mtcost.Text) < Convert.ToInt32(mtprice.Text))
                {
                    item items = new item();
                    MessageBox.Show(items.addItem(mtname.Text, mtcategory.Text, Convert.ToDouble(mtprice.Text), Convert.ToDouble(mtcost.Text), avail.Text));
                    mtname.Text = "";
                    mtcategory.Text = "";
                    avail.Text = "";
                    mtprice.Text = "";
                    mtcost.Text = "";
                    loaddatagrid();
                }
                else
                {
                    MessageBox.Show("Price Should Be Greater Than Cost!");
                }
            }
            else
            {
                MessageBox.Show("Insert The Values Please...");
            }
        }
    }
}
