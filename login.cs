using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;
using System.Diagnostics;

namespace GDL
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        LoginClass l1 = new LoginClass();
        private void btnlogin_Click(object sender, EventArgs e)
        {
           
                if (txtusername.Text != "" && txtusername.Text != "")
                {
                   
                    
                    //txtusername.Text = "";
                    //txtpassword.Text = "";
                    //MessageBox.Show("Please select any option.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

                    bool value = l1.loginuser(txtusername.Text, txtpassword.Text);



                    if (l1.loginuser(txtusername.Text, txtpassword.Text) == true)
                    {

                        string user = l1.user(txtusername.Text, txtpassword.Text);
                        l1.username(txtusername.Text);
                       
                        Program.mart = user;
                        if (user != null)
                        {

                            if (user == "Owner")
                            {


                            int num = int.Parse(l1.CountShops());

                            if (num == 1)
                            {
                                dashboard main = new dashboard();
                                main.Show();
                                this.Hide();
                            }
                            else if (num > 1)
                            {
                                Multi_Restaurant m = new Multi_Restaurant();
                                m.Show();
                                this.Hide();
                            }

                          
                       
                      


                        }
                         

                            else if (user == "Admin")
                            {
                                dashboard d = new dashboard();
                                d.Show();
                                this.Hide();

                               
                              

                            }

                            else if (user == "Cashier")
                            {
                                InvoiceForm d = new InvoiceForm();
                                d.Show();
                                this.Hide();

                              


                            }
                        }

                        else
                        {

                            MessageBox.Show("Error");
                        }



                    }

                    else if (l1.loginuser(txtusername.Text, txtpassword.Text) == false)
                    {

                        MessageBox.Show("Please enter correct user ID or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                    else
                    {
                        MessageBox.Show("Connection Problem");

                    }

                }

                else
                {
                    MessageBox.Show("Please enter valid user ID or password to Login.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtusername.Text = "";
                    txtpassword.Text = "";

                }
           
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
            
        //        MailMessage mail = new MailMessage();
        //        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");


        //        mail.From = new MailAddress("muzzamilkorai06@gmail.com");
        //        mail.To.Add("syedkashan70@gmail.com ");
        //        mail.Subject = "Test Mail";
        //        mail.Body = "This is for testing SMTP mail from GMAIL";
        //    SmtpServer.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
        //                                        // ** HERE! **
        //    SmtpServer.UseDefaultCredentials = true;
        //    // ***********
         
        //    SmtpServer.Port = 587;
        //        SmtpServer.Credentials = new System.Net.NetworkCredential("muzzamilkorai06@gmail.com", "muzzamil1279001");
        //        SmtpServer.EnableSsl = true;

        //         SmtpServer.Send(mail);
        //        MessageBox.Show("mail Send");
          

        //}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OwnerRegistration o = new OwnerRegistration();
            o.Show();
            this.Hide();
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {
             
        }
    }
}
