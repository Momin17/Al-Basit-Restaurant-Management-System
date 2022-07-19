using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace GDL
{
    public partial class InvoiceForm : MetroFramework.Forms.MetroForm
    {
        public InvoiceForm()
        {
            InitializeComponent();
        }

        string[] array = new string[3];
        int xlocation = 5;
        int i = 0;


        public double total()
        {
            double totalSum = 0;
            
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    totalSum += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);

                }
            return totalSum;
        }

        public double QTY()
        {
            double totalSum = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                totalSum += Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);

            }
            return totalSum;
        }

        public void insertListData()
        {
            Select s = new Select();
        
            string name="";
            string cname = null;

            listBox2.Items.Add("        Counter Slip");
            listBox2.Items.Add("");
            listBox2.Items.Add("");



            listBox1.Items.Add("");
          
            listBox1.Items.Add("     FYP RMS");
            listBox1.Items.Add("");
            listBox1.Items.Add("");
      
            listBox1.Items.Add("");
            listBox1.Items.Add("");
            
         
       

            listBox1.Items.Add("_______________________________________________________________");
            listBox1.Items.Add("                                        Sale Receipt");
            listBox1.Items.Add("_______________________________________________________________");
            
           ka.Text = Convert.ToString(Convert.ToInt32(s.MaxOrderNum()) + 1);
            listBox2.Items.Add("Order # " + ka.Text + "        D/T : " + DateTime.Today.ToShortDateString() + "  " + DateTime.Now.ToLongTimeString().ToString());
         
            c.updateData("insert into Token values(" + ka.Text + "," + label14.Text + ")");

            listBox1.Items.Add("Order # " + ka.Text + "        D/T : " + DateTime.Today.ToShortDateString() + "  " + DateTime.Now.ToLongTimeString().ToString());
            listBox2.Items.Add("Token # " + label14.Text);
            listBox1.Items.Add("Token # " + label14.Text);

            // listBox1.Items.Add("Date & Time: " + DateTime.Today.ToLongDateString() + "  " + dateTimePicker1.Value.ToLongTimeString().ToString());
            if (metroRadioButton1.Checked)
            {
                name = "Delivery";
                cname = metroTextBox2.Text;
                
            }
            else if (metroRadioButton2.Checked)
            {

              
              
                name = "Take Away";
                cname = "WalkIn Customer";

            }

            if (metroRadioButton3.Checked)
            {
                name = "Dine In";
              

            }

          
            listBox2.Items.Add("");
            if (metroRadioButton1.Checked)
            {
                listBox1.Items.Add("Customer: " + name + ", Name : " + cname);
                listBox1.Items.Add("Cell # " + metroTextBox1.Text + ", Address : " + metroTextBox3.Text);
            }
            else
            {
                listBox1.Items.Add("Customer: " + name);
            }
           
             if (metroRadioButton3.Checked)
            {
                listBox1.Items.Add("Table : " + textBox3.Text);
            }
          
            listBox1.Items.Add("Cashier : " + label12.Text );
           
            listBox1.Items.Add("");
            listBox1.Items.Add("Product        Qty        Price        Total");
            listBox1.Items.Add("");
            listBox1.Items.Add("_______________________________________________________________");
                
            
            


        }

        checkandbalance c = new checkandbalance();

        public void getToken()
        {
            string a1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string a2 = c.getstringvalue("Select Distinct(FORMAT(date,'yyyy-MM-dd')) from Sales where Invoice_NO in ( select Max(Invoice_NO) from Sales where Store ="+Program.shopid+") And Store ="+Program.shopid);

            if (a1 == a2)
            {
                //=============Matched

                label14.Text = Convert.ToString(Convert.ToInt32(c.MaxOrderNum()) + 1);
            }
            else
            {
                label14.Text = "1";
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
            




            getToken();
            //===========================================================

            //===========================================================
            dataGridView1.ReadOnly = true;
         
            //================================================================



            label12.Text = Program.username;
            Select s1 = new Select();
            s1.search1("select Area_Name from managedel where Store="+Program.shopid);
            comboBox1.DisplayMember = "Area_Name";

            comboBox1.DataSource = s1.ds.Tables[0];
            comboBox1.Text = "";
            ka.Text = Convert.ToString(Convert.ToInt32(s1.MaxOrderNum()) + 1);


         



            int n = 10;
            

            string query = "SELECT Distinct(Category) FROM Items Where Store="+Program.shopid;
            SqlCommand cmd3 = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader reader = cmd3.ExecuteReader();
           
            while (reader.Read())
            {
                //   id = (reader[0].ToString());
                i++;
               
                {
                    Button newButton = new Button();

                    newButton.Name = string.Format(i.ToString());
                    newButton.Text = string.Format(reader[0].ToString());
                    newButton.Location = new System.Drawing.Point(xlocation, n);
                    newButton.Size = new System.Drawing.Size(125, 50);
                    newButton.Click += btn_msg;
                    
                    panel1.Controls.Add(newButton);

                    if (i % 2 == 0)
                    {


                        n = n + 60;
                    }

                }
                xlocation = xlocation + 130;
                if (i % 2 == 0)
                {
                    xlocation = 5;
                }


            }
            reader.Close();
            

            //--------------

          
          

        }

        public void Print()
        {
            // Thread.Sleep(3000);
            PrintDialog PrintDialog = new PrintDialog();
            PrintDocument PrintDocument = new PrintDocument();
            PrintDialog.Document = PrintDocument;

            PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing


           
                PrintDocument.Print();
                Print2();

            
           

            
            
        }

        public void Print2()
        {
            // Thread.Sleep(3000);
            PrintDialog PrintDialog = new PrintDialog();
            PrintDocument PrintDocument = new PrintDocument();
            PrintDialog.Document = PrintDocument;

            PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt2); //add an event handler that will do the printing

          

          
                PrintDocument.Print();

           
        }


        public void CreateReceipt2(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {




            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 7);

            float fontHeight = font.GetHeight();

            int startX = 1;
            int startY = 0;
            int offset = 0;




            foreach (string item in listBox2.Items)
            {
                string productDescription = item;

                string productLine = productDescription;

                //          Sale Receipt
                if (item == "  ")
                {
                    e.Graphics.DrawImage(pictureBox3.Image, 85, startY + offset);

                }
                if (item == "        Counter Slip")
                {


                    font = new Font("Garamond", 18, FontStyle.Bold);
                    graphic.DrawString(productLine, font, new SolidBrush(Color.Black), startX, startY + offset);


                }
                else if (item == "         Thank You for Coming       ")
                {
                    font = new Font("Arial", 12, FontStyle.Bold);
                    graphic.DrawString(productLine, font, new SolidBrush(Color.Black), startX, startY + offset);
                }
                else if (item == "                                        Sale Receipt")
                {
                    font = new Font("Calibri", 9, FontStyle.Bold);
                    graphic.DrawString(productLine, font, new SolidBrush(Color.Black), startX, startY + offset);




                }
                else if (item == "Product        Qty        Price        Discount        Total" || item == "*Only Exchange Within 3 Days of Purchase" || item == "*No Exchange Without Reciept" || item == "*No Cash Refund" || item == "Total             " + "materialLabel5.Text")
                {
                    font = new Font("Calibri", 9, FontStyle.Bold);
                    graphic.DrawString(productLine, font, new SolidBrush(Color.Black), startX, startY + offset);
                }

                else
                {
                    font = new Font("Calibri", 9);
                    graphic.DrawString(productLine, font, new SolidBrush(Color.Black), startX, startY + offset);
                    offset = offset + (int)fontHeight + 5; //make the spacing consistent
                }


            }

        }
        public void CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {




            Graphics graphic = e.Graphics;

            Font font = new Font("future font", 7);

            float fontHeight = font.GetHeight();

            int startX = 1;
            int startY = 0;
            int offset = 0;




            foreach (string item in listBox1.Items)
            {
                string productDescription = item;

                string productLine = productDescription;

                //          Sale Receipt
                if (item == "  ")
                {
                    e.Graphics.DrawImage(pictureBox3.Image, 85, startY + offset);

                }
                if (item == "        FYP RMS")
                {


                    font = new Font("Garamond", 18, FontStyle.Bold);
                    graphic.DrawString(productLine, font, new SolidBrush(Color.Black), startX, startY + offset);


                }
                else if (item == "         Thank You for Coming       ")
                {
                    font = new Font("Arial", 12, FontStyle.Bold);
                    graphic.DrawString(productLine, font, new SolidBrush(Color.Black), startX, startY + offset);
                }
                else if (item == "                                        Sale Receipt")
                {
                    font = new Font("Calibri", 9, FontStyle.Bold);
                    graphic.DrawString(productLine, font, new SolidBrush(Color.Black), startX, startY + offset);




                }
                else if (item == "Product        Qty        Price        Total" || item == "*Only Exchange Within 3 Days of Purchase" || item == "*No Exchange Without Reciept" || item == "*No Cash Refund" || item == "Total             " + "materialLabel5.Text")
                {
                    font = new Font("Calibri", 9, FontStyle.Bold);
                    graphic.DrawString(productLine, font, new SolidBrush(Color.Black), startX, startY + offset);
                }

            
             
                else
                {
                    font = new Font("Calibri", 9);
                    graphic.DrawString(productLine, font, new SolidBrush(Color.Black), startX, startY + offset);
                    offset = offset + (int)fontHeight + 5; //make the spacing consistent
                }

               
               
            }

        }
        public void btn_msg(object sender, EventArgs e)
        {
            //newButton2.Controls.Clear();
            //int xlocation1 = 5;

            //panel2.Controls.Clear();
            //Button btn = (Button)sender;



            //int n = 10;


            //string query = "SELECT Sub_Category FROM Items where Category='"+btn.Text+"'";
            //SqlCommand cmd3 = new SqlCommand(query, Connection.GetConnection());
            //SqlDataReader reader = cmd3.ExecuteReader();
            //newButton2.Controls.Clear();
            int xlocation1 = 5;

            panel3.Controls.Clear();
            Button btn = (Button)sender;



            int n = 10;


            string query = "SELECT Name,ID,isAvailable FROM Items where Category='" + btn.Text + "' And Store="+Program.shopid;
            SqlCommand cmd3 = new SqlCommand(query, Connection.GetConnection());
            SqlDataReader reader = cmd3.ExecuteReader();
            int o = 0;
            while (reader.Read())
            {
                //   id = (reader[0].ToString());

                o++;
                Button newButton2 = new Button();
                {


                    newButton2.Name = string.Format(reader[1].ToString());
                    newButton2.Text = string.Format(reader[0].ToString());
                    newButton2.Location = new System.Drawing.Point(xlocation1, n);
                    newButton2.Size = new System.Drawing.Size(125, 50);
                   
                    if (reader[2].ToString() == "No")
                    {
                        newButton2.BackColor = Color.Red;
                    }
                    else
                    {
                        newButton2.Click += ItemsAdd;
                    }
                    panel3.Controls.Add(newButton2);

                    if (o % 4 == 0)
                    {


                        n = n + 60;
                    }

                }
                xlocation1 = xlocation1 + 130;
                if (o % 4 == 0)
                {
                    xlocation1 = 3;
                }


            }
            reader.Close();


        }
        public void btn_msg2(object sender, EventArgs e)
        {
          
        }
        public void ItemsAdd(object sender, EventArgs e)
        {

            Button btn = (Button)sender;

            String Query = "Select ID,Name +' ' +Category,Price from Items where ID = " + btn.Name + " And Store ="+Program.shopid;
            SqlCommand cmd3 = new SqlCommand(Query, Connection.GetConnection());
            SqlDataReader reader = cmd3.ExecuteReader();
            if (reader.Read())
            {
               
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();

                //        MessageBox.Show(reader[0].ToString());


                //=========================
                //Duplicate Item
                bool flag = true;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (reader[0].ToString() == dataGridView1.Rows[i].Cells[0].Value.ToString())
                    {

                        int reserve = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) +1;
                        double r2= Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) + double.Parse(reader[2].ToString());
                        dataGridView1.Rows[i].Cells[4].Value = r2.ToString();
                        dataGridView1.Rows[i].Cells[2].Value = reserve.ToString();
                        flag = false;
                        break;
                      
                    }
                    
                }

                //============
                if (flag == true)
                {
                    row.Cells[0].Value = reader[0];
                    row.Cells[1].Value = reader[1];
                    row.Cells[2].Value = 1;
                    row.Cells[3].Value = Math.Round(double.Parse(reader[2].ToString()), 0);
                    row.Cells[4].Value = Math.Round(double.Parse(reader[2].ToString()), 0);
                    dataGridView1.Rows.Add(row);
                }
                flag = true;
            }
            reader.Close();

            label6.Text = total().ToString();
            label7.Text = QTY().ToString();


        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = textBox1.Text + 100;
            }
            else

            {
                int num = int.Parse(textBox1.Text) + 100;
                textBox1.Text = num.ToString();
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = textBox1.Text + 500;
            }
            else

            {
                int num = int.Parse(textBox1.Text) + 500;
                textBox1.Text = num.ToString();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = textBox1.Text + 1000;
            }
            else

            {
                int num = int.Parse(textBox1.Text) + 1000;
                textBox1.Text = num.ToString();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = textBox1.Text + 10;
            }
            else

            {
                int num = int.Parse(textBox1.Text) + 10;
                textBox1.Text = num.ToString();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = textBox1.Text + 20;
            }
            else

            {
                int num = int.Parse(textBox1.Text) + 20;
                textBox1.Text = num.ToString();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = textBox1.Text + 50;
            }
            else

            {
                int num = int.Parse(textBox1.Text) + 50;
                textBox1.Text = num.ToString();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {

                    dataGridView1.Rows.RemoveAt(item.Index);
                }
                label6.Text = total().ToString();
                label7.Text = QTY().ToString();
            }
            catch
            {

            }
        }
        bool customerdata = true;
        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            customerdata = true;
            try
            {
                if (metroTextBox1.Text == "")
                {
                    metroTextBox2.Text = "";
                    metroTextBox3.Text = "";
                }
                else

                {
                    metroTextBox2.Text = "";
                    metroTextBox3.Text = "";
                    string query = "SELECT Name,Address FROM Customer where Number =" + metroTextBox1.Text+" And Store ="+Program.shopid;

                    SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());

                    SqlDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        metroTextBox2.Text = read["Name"].ToString();
                        metroTextBox3.Text = read["Address"].ToString();
                        customerdata = false;


                    }
                    read.Close();

                }
            }
            catch
            { }
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // comboBox2.Visible = false;
            textBox3.Visible = false;
            label13.Visible = false;
            button19.Visible = false;
            metroTextBox1.Visible = true;
            metroTextBox2.Visible = true;
            metroTextBox2.Visible = true;
            metroTextBox3.Visible = true;
            comboBox1.Visible = true;
            label9.Visible = true;

            metroTextBox5.Visible = true;
            button20.Visible = true;

            groupBox1.Visible = true;
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            metroTextBox5.Visible = false;
            label9.Visible = false;
            metroTextBox1.Visible = false;
            metroTextBox2.Visible = false;
            metroTextBox3.Visible = false;
            textBox3.Visible = false;
            label13.Visible = false;

            button20.Visible = false;

           // comboBox2.Visible = false;
          
            button19.Visible = true;

            groupBox1.Visible = false;

            metroRadioButton5.Checked = true;
        }




        public void Bill()
        {
            listBox1.Items.Add("_______________________________________________________________");

            if (metroRadioButton2.Checked)
            {
                if (metroRadioButton5.Checked)
                {
                    if (textBox2.Text == "")
                    {
                        listBox1.Items.Add("                                                     " + "Net Amount  :   " + (Convert.ToDouble(label6.Text)));
                        listBox1.Items.Add("                                                     " + "Cash Paid   :   " + textBox1.Text);
                        double cashback = Convert.ToDouble(textBox1.Text) - Convert.ToDouble(label6.Text);
                        listBox1.Items.Add("                                                     " + "Cash Back   :   " + cashback.ToString());
                    }
                    else
                    {
                        listBox1.Items.Add("                                                     " + "Net Amount  :   " + (total().ToString()));
                        listBox1.Items.Add("                                                     " + "Discount    :   " + (Convert.ToDouble(textBox2.Text)));
                        listBox1.Items.Add("                                                     " + "Total       :   " + (Math.Round(total() - Convert.ToDouble(textBox2.Text))));
                        listBox1.Items.Add("                                                     " + "Cash Paid   :   " + textBox1.Text);
                        double cashback = Convert.ToDouble(textBox1.Text) - Convert.ToDouble(label6.Text);
                        listBox1.Items.Add("                                                     " + "Cash Back   :   " + cashback.ToString());
                    }
                }
                else if (metroRadioButton4.Checked)

                {

                    if (textBox2.Text == "")
                    {
                        listBox1.Items.Add("                                                     " + "Net Amount  :   " + (Convert.ToDouble(label6.Text)));
                        
                    }
                    else
                    {
                        listBox1.Items.Add("                                                     " + "Net Amount  :   " + (total().ToString()));
                        listBox1.Items.Add("                                                     " + "Discount    :   " + (Convert.ToDouble(textBox2.Text)));
                        listBox1.Items.Add("                                                     " + "Total       :   " + (Math.Round(total() - Convert.ToDouble(textBox2.Text))));
                       
                    }

                }

            }



            //==================================================================



            if (metroRadioButton3.Checked)
            {
                if (metroRadioButton5.Checked)
                {
                    if (textBox2.Text == "")
                    {
                        listBox1.Items.Add("                                                     " + "Net Amount  :   " + (Convert.ToDouble(label6.Text)));
                        listBox1.Items.Add("                                                     " + "Cash Paid   :   " + textBox1.Text);
                        double cashback = Convert.ToDouble(textBox1.Text) - Convert.ToDouble(label6.Text);
                        listBox1.Items.Add("                                                     " + "Cash Back   :   " + cashback.ToString());
                    }
                    else
                    {
                        listBox1.Items.Add("                                                     " + "Net Amount  :   " + (total().ToString()));
                        listBox1.Items.Add("                                                     " + "Discount    :   " + (Convert.ToDouble(textBox2.Text)));
                        listBox1.Items.Add("                                                     " + "Total       :   " + (Math.Round(total() - Convert.ToDouble(textBox2.Text))));
                        listBox1.Items.Add("                                                     " + "Cash Paid   :   " + textBox1.Text);
                        double cashback = Convert.ToDouble(textBox1.Text) - Convert.ToDouble(label6.Text);
                        listBox1.Items.Add("                                                     " + "Cash Back   :   " + cashback.ToString());
                    }
                }
                else if (metroRadioButton4.Checked)

                {

                    if (textBox2.Text == "")
                    {
                        listBox1.Items.Add("                                                     " + "Net Amount  :   " + (Convert.ToDouble(label6.Text)));
                        
                    }
                    else
                    {
                        listBox1.Items.Add("                                                     " + "Net Amount  :   " + (total().ToString()));
                        listBox1.Items.Add("                                                     " + "Discount    :   " + (Convert.ToDouble(textBox2.Text)));
                        listBox1.Items.Add("                                                     " + "Total       :   " + (Math.Round(total() - Convert.ToDouble(textBox2.Text))));
                       
                    }

                }

            }

            //==================================================================


            if (metroRadioButton1.Checked)
            {
                if (textBox2.Text == "")
                {
                    listBox1.Items.Add("                                              " + "Net Amount         :   " + (Convert.ToDouble(label6.Text)));
                    listBox1.Items.Add("                                              " + "Delivery Charges   :   " + metroTextBox5.Text);
                    double total = Convert.ToDouble(label6.Text) + Convert.ToDouble(metroTextBox5.Text);
                    listBox1.Items.Add("                                              " + "Total              :   " + Math.Round(total, 2));
                }
                else
                {


                    listBox1.Items.Add("                                                   " + "Net Amount  :   " + (total().ToString()));
                    listBox1.Items.Add("                                                   " + "Discount    :   " + (Convert.ToDouble(textBox2.Text)));
                    listBox1.Items.Add("                                                   " + "Delivery Charges   :   " + metroTextBox5.Text);

                    listBox1.Items.Add("                                                   " + "Total    :   " + ((total()+ Convert.ToDouble(metroTextBox5.Text)) - Convert.ToDouble(textBox2.Text)));
                  
                }

            }

      
           
            

          
        }
        private void button19_Click(object sender, EventArgs e)
        {
            
            if (metroRadioButton3.Checked)
            {
                if (metroRadioButton5.Checked)
                {

                    if (textBox1.Text != "" && int.Parse(textBox1.Text) >= int.Parse(label6.Text))
                    {
                        insertListData();
                        insertSales();
                        Bill();

                        DialogResult dr = MessageBox.Show("Print", "Do you Want to Print?", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            Print();

                        }
                        else
                        {

                        }
                        clear();
                        getToken();
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Cash Recieved ");
                    }

                }

                //...............
                if(metroRadioButton4.Checked)
                {
                insertListData();
                insertSales2p();
                Bill();

                DialogResult dr = MessageBox.Show("Print", "Do you Want to Print?", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Print();

                }
                else
                {

                }
                clear();
                    getToken();
                }
            }

             if (metroRadioButton2.Checked)
            {
                if (metroRadioButton5.Checked)
                {

                    if (textBox1.Text != "" && int.Parse(textBox1.Text) >= int.Parse(label6.Text))
                    {
                        insertListData();
                        insertSales();
                        Bill();

                        DialogResult dr = MessageBox.Show("Print", "Do you Want to Print?", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            Print();

                        }
                        else
                        {

                        }
                        clear();
                        getToken();
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Cash Recieved ");
                    }

                }

                //...............
                if(metroRadioButton4.Checked)
                {
                insertListData();
                insertSales2p();
                Bill();

                DialogResult dr = MessageBox.Show("Print", "Do you Want to Print?", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Print();

                }
                else
                {

                }
                clear();
                    getToken();
                }
            }
        }
        


        private void button20_Click(object sender, EventArgs e)
        {
            if (metroRadioButton4.Checked)
            {
                insertListData();
                insertSales();
                Bill();



                DialogResult dr = MessageBox.Show("Print", "Do you want to Print?", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Print();

                }
                else
                {

                }


                if (customerdata == true)
                {
                    s1.CustomerInsert(metroTextBox2.Text, metroTextBox1.Text, metroTextBox3.Text);
                    customerdata = false;
                }
                s1.DelSales(metroTextBox1.Text, int.Parse(ka.Text), Convert.ToInt32(metroTextBox5.Text));
                clear();
            }



            if (metroRadioButton5.Checked)
            {
                insertListData();
                insertSales2p();
                Bill();



                DialogResult dr = MessageBox.Show("Print", "Do you want to Print?", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Print();

                }
                else
                {

                }


                if (customerdata == true)
                {
                    s1.CustomerInsert(metroTextBox2.Text, metroTextBox1.Text, metroTextBox3.Text);
                    customerdata = false;
                }
                s1.DelSales(metroTextBox1.Text, int.Parse(ka.Text), Convert.ToInt32(metroTextBox5.Text));
                clear();
            }
        }

        public void clear()
        {

            dataGridView1.Rows.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            label6.Text = "0";
            label7.Text = "0";
            Select s = new Select();
            ka.Text = Convert.ToString(Convert.ToInt32(s.MaxOrderNum()) + 1);
            textBox1.Text = "";
            textBox2.Text = "";

        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               
                   
                    string query = "SELECT Charges FROM managedel where Area_Name = '" + comboBox1.Text+"' And Store="+Program.shopid;

                    SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());

                    SqlDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        
                        metroTextBox5.Text = read["Charges"].ToString();

                    }
                    read.Close();

                
            }
            catch
            { }
        }

       



        Sales s1 = new Sales();
        public void insertSales()
        {

            double discount = 0;
            if (textBox2.Text != "")
            {
                discount = Convert.ToDouble(textBox2.Text) / int.Parse(label7.Text);
            }
            else 
            {
                discount = 0;
            }
          
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[i].Clone();
                    double val = Convert.ToDouble(dataGridView1[2, i].Value);
                    val = System.Math.Round(val, 2);
                    double val1 = Convert.ToDouble(dataGridView1[3, i].Value);
                    val1 = System.Math.Round(val1, 2);

                
                    int qty_vl1 = Convert.ToInt32(dataGridView1[2, i].Value);
                   double val3 = (val - val1) * qty_vl1;

                listBox1.Items.Add((string)dataGridView1[1, i].Value);
                

                if (val1 > 9999)
                    {
                        listBox1.Items.Add("".PadRight(20) + String.Format("{0:0.00}", val).PadRight(12) + String.Format("{0:0.00}", val1).PadRight(12) + "  " + String.Format("{0:0.00}", Convert.ToDouble(dataGridView1[4, i].Value) ));

                    }
                    else if (val1 > 999)
                    {
                        listBox1.Items.Add("".PadRight(20) + String.Format("{0:0.00}", val).PadRight(12) + String.Format("{0:0.00}", val1).PadRight(12) + "  " + String.Format("{0:0.00}", Convert.ToDouble(dataGridView1[4, i].Value) ));

                    }
                    else if (val1 > 99)
                    {
                        listBox1.Items.Add("".PadRight(20) + String.Format("{0:0.00}", val).PadRight(12) + String.Format("{0:0.00}", val1).PadRight(11) + "  " + String.Format("{0:0.00}", Convert.ToDouble(dataGridView1[4, i].Value) ));

                    }
                    else if (val1 > 0 && val < 99)
                    {
                        listBox1.Items.Add("".PadRight(20) + String.Format("{0:0.0}", val).PadRight(13) + String.Format("{0:0.0}", val1).PadRight(13) + "  " + String.Format("{0:0.0}", Convert.ToDouble(dataGridView1[4, i].Value)));

                    }
                    else
                    {
                        listBox1.Items.Add("".PadRight(20) + String.Format("{0:0.0}", val).PadRight(12) + String.Format("{0:0.0}", val1).PadRight(12) + "  " + String.Format("{0:0.0}", Convert.ToDouble(dataGridView1[4, i].Value)));

                    }

                listBox2.Items.Add((string)dataGridView1[1, i].Value);

                listBox2.Items.Add("".PadRight(20) + String.Format("{0:0.00}", val).PadRight(12));


                if (metroRadioButton1.Checked)

                {
                    if (metroTextBox5.Text != "")
                    {
                        s1.Sale_Insert(int.Parse(ka.Text), Convert.ToInt32(dataGridView1[0, i].Value.ToString()), (string)dataGridView1[1, i].Value.ToString(), Convert.ToInt32(dataGridView1[2, i].Value.ToString()), Math.Round(Convert.ToDouble(dataGridView1[4, i].Value.ToString()), 2), "Delivery", dateTimePicker1.Value.Date.ToString("yyyyMMdd"), label12.Text,"Paid");
                       
                    }

                 }
                else if (metroRadioButton2.Checked)
                {
                    s1.Sale_Insert(int.Parse(ka.Text), Convert.ToInt32(dataGridView1[0, i].Value.ToString()), (string)dataGridView1[1, i].Value.ToString(), Convert.ToInt32(dataGridView1[2, i].Value.ToString()), Math.Round(Convert.ToDouble(dataGridView1[4, i].Value.ToString())-(discount* Convert.ToInt32(dataGridView1[2, i].Value.ToString())), 2), "TakeAway", dateTimePicker1.Value.Date.ToString("yyyyMMdd"), label12.Text,"Paid");

                }
                else if (metroRadioButton3.Checked)
                {
                    s1.Sale_Insert(int.Parse(ka.Text), Convert.ToInt32(dataGridView1[0, i].Value.ToString()), (string)dataGridView1[1, i].Value.ToString(), Convert.ToInt32(dataGridView1[2, i].Value.ToString()), Math.Round(Convert.ToDouble(dataGridView1[4, i].Value.ToString()) - (discount * Convert.ToInt32(dataGridView1[2, i].Value.ToString())), 2), "DineIn", dateTimePicker1.Value.Date.ToString("yyyyMMdd"), label12.Text, "Paid");

                }


            }

        }



        public void insertSales2p()
        {

            double discount = 0;
            if (textBox2.Text != "")
            {
                discount = Convert.ToDouble(textBox2.Text) / int.Parse(label7.Text);
            }
            else
            {
                discount = 0;
            }

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {

                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[i].Clone();
                double val = Convert.ToDouble(dataGridView1[2, i].Value);
                val = System.Math.Round(val, 2);
                double val1 = Convert.ToDouble(dataGridView1[3, i].Value);
                val1 = System.Math.Round(val1, 2);


                int qty_vl1 = Convert.ToInt32(dataGridView1[2, i].Value);
                double val3 = (val - val1) * qty_vl1;

                listBox1.Items.Add((string)dataGridView1[1, i].Value);


                if (val1 > 9999)
                {
                    listBox1.Items.Add("".PadRight(20) + String.Format("{0:0.00}", val).PadRight(12) + String.Format("{0:0.00}", val1).PadRight(12) + "  " + String.Format("{0:0.00}", Convert.ToDouble(dataGridView1[4, i].Value)));

                }
                else if (val1 > 999)
                {
                    listBox1.Items.Add("".PadRight(20) + String.Format("{0:0.00}", val).PadRight(12) + String.Format("{0:0.00}", val1).PadRight(12) + "  " + String.Format("{0:0.00}", Convert.ToDouble(dataGridView1[4, i].Value)));

                }
                else if (val1 > 99)
                {
                    listBox1.Items.Add("".PadRight(20) + String.Format("{0:0.00}", val).PadRight(12) + String.Format("{0:0.00}", val1).PadRight(11) + "  " + String.Format("{0:0.00}", Convert.ToDouble(dataGridView1[4, i].Value)));

                }
                else if (val1 > 0 && val < 99)
                {
                    listBox1.Items.Add("".PadRight(20) + String.Format("{0:0.0}", val).PadRight(13) + String.Format("{0:0.0}", val1).PadRight(13) + "  " + String.Format("{0:0.0}", Convert.ToDouble(dataGridView1[4, i].Value)));

                }
                else
                {
                    listBox1.Items.Add("".PadRight(20) + String.Format("{0:0.0}", val).PadRight(12) + String.Format("{0:0.0}", val1).PadRight(12) + "  " + String.Format("{0:0.0}", Convert.ToDouble(dataGridView1[4, i].Value)));

                }

                listBox2.Items.Add((string)dataGridView1[1, i].Value);

                listBox2.Items.Add("".PadRight(20) + String.Format("{0:0.00}", val).PadRight(12));


                if (metroRadioButton1.Checked)

                {
                    if (metroTextBox5.Text != "")
                    {
                        s1.Sale_Insert(int.Parse(ka.Text), Convert.ToInt32(dataGridView1[0, i].Value.ToString()), (string)dataGridView1[1, i].Value.ToString(), Convert.ToInt32(dataGridView1[2, i].Value.ToString()), Math.Round(Convert.ToDouble(dataGridView1[4, i].Value.ToString()), 2), "Delivery", dateTimePicker1.Value.Date.ToString("yyyyMMdd"), label12.Text,"Unpaid");

                    }

                }
                else if (metroRadioButton2.Checked)
                {
                    s1.Sale_Insert(int.Parse(ka.Text), Convert.ToInt32(dataGridView1[0, i].Value.ToString()), (string)dataGridView1[1, i].Value.ToString(), Convert.ToInt32(dataGridView1[2, i].Value.ToString()), Math.Round(Convert.ToDouble(dataGridView1[4, i].Value.ToString()) - (discount * Convert.ToInt32(dataGridView1[2, i].Value.ToString())), 2), "TakeAway", dateTimePicker1.Value.Date.ToString("yyyyMMdd"), label12.Text, "Unpaid");

                }
                else if (metroRadioButton3.Checked)
                {
                    s1.Sale_Insert(int.Parse(ka.Text), Convert.ToInt32(dataGridView1[0, i].Value.ToString()), (string)dataGridView1[1, i].Value.ToString(), Convert.ToInt32(dataGridView1[2, i].Value.ToString()), Math.Round(Convert.ToDouble(dataGridView1[4, i].Value.ToString()) - (discount * Convert.ToInt32(dataGridView1[2, i].Value.ToString())), 2), "DineIn", dateTimePicker1.Value.Date.ToString("yyyyMMdd"), label12.Text, "Unpaid");

                }


            }

        }
        private void button38_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 1;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 2;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 3;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 4;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 5;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 6;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 7;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 8;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 9;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                textBox2.Text = textBox2.Text + 0;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {

           
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void metroRadioButton3_CheckedChanged(object sender, EventArgs e)
        {

            comboBox1.Visible = false;
            metroTextBox5.Visible = false;
            label9.Visible = false;
            metroTextBox1.Visible = false;
            metroTextBox2.Visible = false;
            metroTextBox3.Visible = false;
            textBox3.Visible = true;
            label13.Visible = true;
                button19.Visible = true;
            button20.Visible = false;


            groupBox1.Visible = false;




            metroRadioButton5.Checked = true;
            //  metroRadioButton5.PerformClick();
            //   comboBox2.Visible = true;

        }

       

        private void button24_Click(object sender, EventArgs e)
        {
            if (Program.mart == "Owner")
            {

                dashboard d = new dashboard();
                d.Show();
                this.Hide();

            }


            else if (Program.mart == "Admin")
            {
                dashboard d = new dashboard();
                d.Show();
                this.Hide();




            }

            else if (Program.mart == "Cashier")
            {
                login d = new login();
                d.Show();
                this.Hide();




            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double val = total() - Convert.ToDouble(textBox2.Text);
                if (textBox2.Text != "")
                {
                    label6.Text = val.ToString();
                }
            }
            catch
            { }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
          
            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                label2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
            catch
            { }
            
        }

        private void button25_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (label2.Text == dataGridView1.Rows[i].Cells[0].Value.ToString())
                {
                    int val = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                    int reserve = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) + 1;
                    double r2 = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) + double.Parse(val.ToString());
                    dataGridView1.Rows[i].Cells[4].Value = r2.ToString();
                    dataGridView1.Rows[i].Cells[2].Value = reserve.ToString();
                   

                }

            }
            label6.Text = total().ToString();
            label7.Text = QTY().ToString();
        }

        private void button26_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (label2.Text == dataGridView1.Rows[i].Cells[0].Value.ToString())
                {
                    int val = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                    int qty = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);

                    if (qty > 1)
                    { int reserve = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) - 1;
                        double r2 = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) - double.Parse(val.ToString());
                        dataGridView1.Rows[i].Cells[4].Value = r2.ToString();
                        dataGridView1.Rows[i].Cells[2].Value = reserve.ToString(); }
                    else
                    {

                        MessageBox.Show("Please Press Remove Button");
                    }
                     


                }

            }
            label6.Text = total().ToString();
            label7.Text = QTY().ToString();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            CancelOrders co = new CancelOrders();
            co.Show();
            this.Hide();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Unpaid_Orders up = new Unpaid_Orders();
            up.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
