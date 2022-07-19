using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GDL
{
    public partial class OwnerRegistration : MetroFramework.Forms.MetroForm
    {
        public OwnerRegistration()
        {
            InitializeComponent();
        }

        private void OwnerRegistration_Load(object sender, EventArgs e)
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


        user u1 = new user();
        RegistrationClass rs = new RegistrationClass();
    //    Login l1 = new Login();
        private void button19_Click(object sender, EventArgs e)
        {
            string number = metroTextBox10.Text;
            //^((\+92)|(0092))-{0,1}\d{3}-{0,1}\d{7}$|^\d{11}$|^\d{4}-\d{7}$

            //string pattern = @"\+923\d{9}";
            string pattern = @"(030|021|033|031|034|032)[0-9]{1}([0-9])(?!\1{6})[0-9]{6}";
            bool isMatched = Regex.IsMatch(number, pattern);


            string number2 = metroTextBox4.Text;
            //^((\+92)|(0092))-{0,1}\d{3}-{0,1}\d{7}$|^\d{11}$|^\d{4}-\d{7}$

            //string pattern = @"\+923\d{9}";
            string pattern2 = @"(030|021|033|031|034|032)[0-9]{1}([0-9])(?!\1{6})[0-9]{6}";
            bool isMatched2 = Regex.IsMatch(number2, pattern2);


            //=======================


            if (metroTextBox1.Text != "")
            {
                label1.Visible = false;
            }

            if (metroTextBox9.Text != "")
            {
                label2.Visible = false;
            }

            if (metroTextBox8.Text != "")
            {
                label3.Visible = false;
            }
            if (metroTextBox10.Text != "")
            {
                label4.Visible = false;
            }


            if (metroTextBox2.Text != "")
            {
                label5.Visible = false;
            }
            if (metroTextBox3.Text != "")
            {
                label6.Visible = false;
            }
            if (metroTextBox4.Text != "")
            {
                label7.Visible = false;
            }
            if (metroTextBox7.Text != "")
            {
                label8.Visible = false;
            }
           

            //=======================


            if (metroTextBox1.Text == "")
            {
                label1.Visible = true;
            }

            if (metroTextBox9.Text == "")
            {
                label2.Visible = true;
            }

            if (metroTextBox8.Text == "")
            {
                label3.Visible = true;
            }
            if (metroTextBox10.Text == "" || metroTextBox10.Text.Length < 11 || isMatched == false)
            {
                label4.Visible = true;
            }


            if (metroTextBox2.Text == "")
            {
                label5.Visible = true;
            }
            if (metroTextBox3.Text == "")
            {
                label6.Visible = true;
            }
            if (metroTextBox4.Text == "" || metroTextBox4.Text.Length < 11 || isMatched2 == false)
            {
                label7.Visible = true;
            }
            if (metroTextBox7.Text == "")
            {
                label8.Visible = true;
            }
           








            if (metroTextBox8.Text != "" && metroTextBox1.Text != "" && metroTextBox2.Text != "" && metroTextBox3.Text != "" && metroTextBox9.Text != "" && metroTextBox10.Text != "" && metroTextBox4.Text != ""  && metroTextBox7.Text != "" && metroTextBox4.Text.Length == 11 && metroTextBox10.Text.Length == 11  && isMatched == true && isMatched2 == true)
            {
                rs.ShopRegistration(metroTextBox1.Text, metroTextBox8.Text, metroTextBox9.Text, metroTextBox10.Text);
                //  = rs.getid();
                int shopid = rs.getidwithcell(metroTextBox10.Text);
                //-----------
                Program.shopid = shopid;



              //  u1.adduser(metroTextBox2.Text, "Owner", metroTextBox3.Text, metroTextBox4.Text, metroTextBox7.Text, metroTextBox5.Text, metroTextBox6.Text, dateTimePicker1.Value.ToString("yyyyMMdd"));

                u1.adduser(metroTextBox7.Text, metroTextBox2.Text, metroTextBox4.Text,metroTextBox3.Text, "Owner");

                


             
                Program.shopid = shopid;
                string owner = rs.getOwner(metroTextBox4.Text);
                Program.Owner = owner;
                Program.ownerid = owner;
               

                rs.MultiShopRegistration2(shopid);

                MetroFramework.MetroMessageBox.Show(this, "" + "\n\n" + "Username : " + Program.ownerid + "\n" + "Owner : " + metroTextBox2.Text + "\n" + "Shop Name : " + metroTextBox1.Text + "\n", "Shop Created Successfully", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                metroTextBox1.Text = "";
                metroTextBox2.Text = "";
                metroTextBox3.Text = "";
                metroTextBox4.Text = "";
               
                metroTextBox7.Text = "";
                metroTextBox8.Text = "";
                metroTextBox9.Text = "";
                metroTextBox10.Text = "";


                //    MessageBox.Show("Shop Created " + "\n"+ + "");
                //MessageBox.Show("Shop Created " + "\n" + "User ID : " + id + "\n" + "Owner : " + metroTextBox2.Text + "\n" + "Shop Name " + metroTextBox1.Text + "\n" + "","New Shop",)
                //metroLabel3_Click
                //    mainForm od = new mainForm();
                //    od.Show(); ;
                //    this.Hide();


            }

            else
            {
                MessageBox.Show("Please fill required fields", "Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
