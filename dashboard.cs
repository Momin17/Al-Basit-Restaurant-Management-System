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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }
        LoginClass l1 = new LoginClass();
        bool flag = true;
        private void dashboard_Load(object sender, EventArgs e)
        {
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

            int num = int.Parse(l1.CountShops());

            if (num == 1)
            {
             
            }
            else if (num > 1)
            {
                comboBox1.Visible = true;
            }

            flag = false;
            if (Program.mart=="Owner")
            {

                panel3.Visible = true;
                pictureBox8.Visible = true;

            }



            chart2.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            ChartClass.Category.Clear();
            ChartClass.QTY.Clear();

            foreach (var series in chart2.Series)
            {
                series.Points.Clear();
            }


            ChartClass p = new ChartClass();


            p.datafetch();
            for (int i = 0; i < ChartClass.Category.Count; i++)
            {
                chart2.Series["Series1"].Points.AddXY(ChartClass.Category[i], ChartClass.QTY[i]);
            }



            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;

            ChartClass.Category2.Clear();
            ChartClass.QTY2.Clear();
            //loadtotalemployees();
            //loadtotalusers();
            loadtotalcatogries();
            loadtotalitemsold();
          

          
            p.datafetch2();
            for (int i = 0; i < ChartClass.Category2.Count; i++)
            {
                chart1.Series["Series1"].Points.AddXY(ChartClass.Category2[i], ChartClass.QTY2[i]);
            }
            checkandbalance checknBalance = new checkandbalance();

            

            //Select s2 = new Select();
            //s2.search1("select distinct(Category) from Items where Store="+Program.shopid);
            //metroComboBox1.DisplayMember = "Category";
            //metroComboBox1.DataSource = s2.ds.Tables[0];


            lbltotalsale.Text = checknBalance.getrate("select  Round(Sum(Price),0) from Sales where Order_Status ='Paid' And Store=" + Program.shopid).ToString();
            label23.Text = checknBalance.getrate("select  Round(Sum(Price),0) from Sales where Order_Status ='Paid' and date = '"+ dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "' And Store ="+Program.shopid).ToString();

            order.Text = checknBalance.getrate("select Count(Distinct(Invoice_No))from Sales where Store ="+Program.shopid).ToString();
            
            numofitem.Text = checknBalance.getrate(" select sum(Qty) from sales where date = '" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "' And Store ="+Program.shopid).ToString();
            //   order.Text= checknBalance.getrate("Select Max(Invoice_NO)-1 from Sales").ToString() + " Orders";
            //

            //select top 5 Sale_Type , sum(Qty) as Quantity from Sales group by Sale_Type ORDER BY sum(Qty) DESC





        }

        public static List<string> c = new List<string>();
        public static List<string> q = new List<string>();

        //public void loadtotalemployees()
        //{
        //    string query = "select count(*) from employee";
        //    SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
        //    SqlDataReader rd = cmd.ExecuteReader();
        //    while (rd.Read())
        //    {
        //        label23.Text = rd[0].ToString();
        //    }
        //    rd.Close();
        //}
        //public void loadtotalusers()
        //{
        //    string query = "select count(*) from Users";
        //    SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
        //    SqlDataReader rd = cmd.ExecuteReader();
        //    while (rd.Read())
        //    {
        //        label19.Text = rd[0].ToString();
        //    }
        //    rd.Close();
        //}
        public void loadtotalcatogries()
        {
            string query = "select count(distinct(Invoice_NO)) from sales where date = cast(getdate() as date) And Store ="+Program.shopid;
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                label21.Text = rd[0].ToString();
            }
            rd.Close();
        }
       
        public void loadtotalitemsold()
        {
            string query = " select sum(Qty) from sales where Store ="+Program.shopid;
            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                label25.Text = rd[0].ToString();
            }
            rd.Close();
        }
        private void panellogout_Click(object sender, EventArgs e)
        {
            login f = new login();
            f.Show();
            this.Hide();
        }

        private void panelitem_Click(object sender, EventArgs e)
        {
            foritem fi = new foritem();
            fi.Show();
            this.Hide();
        }

        private void paneluser_Click(object sender, EventArgs e)
        {
            if (Program.mart == "Owner")
            {
                foruser fu = new foruser();
                fu.Show();
                this.Hide();

            }
            else { MessageBox.Show(" Only Owner Can Access"); }
        }

        private void panelexp_Click(object sender, EventArgs e)
        {
            forexpense fe = new forexpense();
            fe.Show();
            this.Hide();
        }

        private void panelemployee_Click(object sender, EventArgs e)
        {
            foremplyee femp = new foremplyee();
            femp.Show();
            this.Hide();
        }

        private void paneldel_Click(object sender, EventArgs e)
        {
            InvoiceForm f = new InvoiceForm();
            f.Show();
            this.Hide();
        }

        private void panelsupply_Click(object sender, EventArgs e)
        {
            suppliers s = new suppliers();
            s.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            forexpense fe = new forexpense();
            fe.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            forexpense fe = new forexpense();
            fe.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            foremplyee femp = new foremplyee();
            femp.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            foremplyee femp = new foremplyee();
            femp.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            suppliers s = new suppliers();
            s.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            suppliers s = new suppliers();
            s.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            foritem fi = new foritem();
            fi.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            foritem fi = new foritem();
            fi.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Program.mart == "Owner")
            {
                foruser fu = new foruser();
                fu.Show();
                this.Hide();

            }
            else { MessageBox.Show(" Only Owner Can Access"); }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if(Program.mart == "Owner")
            {
                foruser fu = new foruser();
                fu.Show();
                this.Hide();

            }
            else {
                MessageBox.Show(" Only Owner Can Access");
                }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            InvoiceForm f = new InvoiceForm();
            f.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            InvoiceForm f = new InvoiceForm();
            f.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            login f = new login();
            f.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            login f = new login();
            f.Show();
            this.Hide();
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            managedelievery md = new managedelievery();
            md.Show();
            this.Hide();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            managedelievery md = new managedelievery();
            md.Show();
            this.Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            managedelievery md = new managedelievery();
            md.Show();
            this.Hide();
        }

        private void pr(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            checkandbalance ch = new checkandbalance();
            double num = ch.getrate("select Count(*) from Report where date  = '" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "' And Store ="+Program.shopid);
            if (num == 0)
            {
                Reprtform femp = new Reprtform();
                femp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Taking has been closed");
            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            checkandbalance ch = new checkandbalance();
            double num = ch.getrate("select Count(*) from Report where date  = '" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "' And Store="+Program.shopid);
            if (num == 0)
            {
                Reprtform femp = new Reprtform();
                femp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Taking has been closed");
            }
        }

        private void panelreport_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelsupply_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panelreport_Click(object sender, EventArgs e)
        {
            checkandbalance ch = new checkandbalance();
            double num = ch.getrate("select Count(*) from Report where date  = '" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "' And Store ="+Program.shopid);
            if (num == 0)
            {
                Reprtform femp = new Reprtform();
                femp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Taking has been closed");
            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }
       
        private void chart4_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        //private void metroComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        //{
        //    chart2.ChartAreas["ChartArea1"].AxisX.Interval = 1;
        //    ChartClass.Category.Clear();
        //    ChartClass.QTY.Clear();

        //    foreach (var series in chart2.Series)
        //    {
        //        series.Points.Clear();
        //    }


        //    ChartClass p = new ChartClass();


        //    p.datafetch(metroComboBox1.Text, dateTimePicker2.Value.Date.ToString("yyyyMMdd"), dateTimePicker3.Value.Date.ToString("yyyyMMdd"));
        //    for (int i = 0; i < ChartClass.Category.Count; i++)
        //    {
        //        chart2.Series["Series1"].Points.AddXY(ChartClass.Category[i], ChartClass.QTY[i]);
        //    }

          
            

        //}


        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {
            Reporting femp = new Reporting();
            femp.Show();
            this.Hide();
        }

        private void panel14_Click(object sender, EventArgs e)
        {
            Reporting femp = new Reporting();
            femp.Show();
            this.Hide();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            Reporting femp = new Reporting();
            femp.Show();
            this.Hide();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            CustomerForm c = new CustomerForm();
            c.Show();
            this.Hide();
        }

        private void label29_Click(object sender, EventArgs e)
        {
            CustomerForm c = new CustomerForm();
            c.Show();
            this.Hide();
        }

        private void panel15_Click(object sender, EventArgs e)
        {
            CustomerForm c = new CustomerForm();
            c.Show();
            this.Hide();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
            
        }

        private void label11_Click(object sender, EventArgs e)
        {
            newshop m = new newshop();
            m.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            newshop m = new newshop();
            m.Show();
            this.Hide();
        }

        private void panellogout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelitem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void paneluser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "All" && flag==false)
                {
                    Multi_Restaurant m = new Multi_Restaurant();
                    m.Show();
                    this.Hide();
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

        //private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        //{

        //}
    }
}
