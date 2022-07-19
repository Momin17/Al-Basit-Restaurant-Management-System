using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Printing;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GDL
{
    public partial class DineIn : MetroFramework.Forms.MetroForm
    {
        public DineIn()
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

           

            


            listBox1.Items.Add("  ");
            listBox1.Items.Add("");
            listBox1.Items.Add("");
            listBox1.Items.Add("");
            listBox1.Items.Add("");
            listBox1.Items.Add("");

            listBox1.Items.Add("");
            listBox1.Items.Add("");

            listBox1.Items.Add("    C77, Gulshan e Hadeed Phase 1 , Near HillTop");


            listBox1.Items.Add("                                   021-34715481");


            listBox1.Items.Add("_______________________________________________________________");
            listBox1.Items.Add("                                        Sale Receipt");
            listBox1.Items.Add("_______________________________________________________________");

            ka.Text = Convert.ToString(Convert.ToInt32(s.MaxOrderNum()) + 1);
           
            listBox1.Items.Add("Order # " + comboBox3.Text + "        D/T : " + DateTime.Today.ToShortDateString() + "  " + dateTimePicker1.Value.ToLongTimeString().ToString());


            // listBox1.Items.Add("Date & Time: " + DateTime.Today.ToLongDateString() + "  " + dateTimePicker1.Value.ToLongTimeString().ToString());
          
               


            


          
            listBox1.Items.Add("Table : " + comboBox2.Text);
            

            listBox1.Items.Add("Cashier : " + label12.Text);

            listBox1.Items.Add("");
            listBox1.Items.Add("Product        Qty        Price        Total");
            listBox1.Items.Add("");
            listBox1.Items.Add("_______________________________________________________________");





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
                    listBox1.Items.Add("".PadRight(20) + String.Format("{0:0.00}", val).PadRight(12) + String.Format("{0:0.00}", val1).PadRight(12) + " " + String.Format("{0:0.00}", Convert.ToDouble(dataGridView1[4, i].Value) - discount * val).PadRight(12));

                }
                else if (val1 > 999)
                {
                    listBox1.Items.Add("".PadRight(20) + String.Format("{0:0.00}", val).PadRight(12) + String.Format("{0:0.00}", val1).PadRight(12) + "  "  + String.Format("{0:0.00}", Convert.ToDouble(dataGridView1[4, i].Value) - discount * val).PadRight(12));

                }
                else if (val1 > 99)
                {
                    listBox1.Items.Add("".PadRight(20) + String.Format("{0:0.00}", val).PadRight(12) + String.Format("{0:0.00}", val1).PadRight(12) + "   " + String.Format("{0:0.00}", Convert.ToDouble(dataGridView1[4, i].Value) - discount * val).PadRight(12));

                }
                else if (val1 > 0 && val < 99)
                {
                    listBox1.Items.Add("".PadRight(20) + String.Format("{0:0.0}", val).PadRight(12) + String.Format("{0:0.0}", val1).PadRight(13) + "    " + String.Format("{0:0.00}", discount * val).PadRight(12) + "  " + String.Format("{0:0.0}", Convert.ToDouble(dataGridView1[4, i].Value) - discount * val).PadRight(12));

                }
                else
                {
                    listBox1.Items.Add("".PadRight(20) + String.Format("{0:0.0}", val).PadRight(12) + String.Format("{0:0.0}", val1).PadRight(12) + String.Format("{0:0.0}", Convert.ToDouble(dataGridView1[4, i].Value) - discount * val).PadRight(12));

                }



              
               
                   s1.Sale_Insert(int.Parse(ka.Text), Convert.ToInt32(dataGridView1[0, i].Value.ToString()), (string)dataGridView1[1, i].Value.ToString(), Convert.ToInt32(dataGridView1[2, i].Value.ToString()), Math.Round(Convert.ToDouble(dataGridView1[4, i].Value.ToString()) - (discount * Convert.ToInt32(dataGridView1[2, i].Value.ToString())), 2), "DineIn", dateTimePicker1.Value.Date.ToString("yyyyMMdd"), label12.Text,"Unpaid");

               


            }

        }
        private void DineIn_Load(object sender, EventArgs e)
        {
            label12.Text = Program.username;
            Select s1 = new Select();

            ka.Text = Convert.ToString(Convert.ToInt32(s1.MaxOrderNum()) + 1);


            Select s2 = new Select();
            s2.search1("select TableNo from Tables where Store =" + Program.shopid);
            comboBox2.DisplayMember = "TableNo";

            comboBox2.DataSource = s2.ds.Tables[0];






            s1.search1("select TableNo from Tables where Store =" + Program.shopid);
            comboBox1.DisplayMember = "TableNo";

            comboBox1.DataSource = s2.ds.Tables[0];







            int n = 10;


            string query = "SELECT Distinct(Category) FROM Items where Store ="+Program.shopid;
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

                    if (i % 1 == 0)
                    {


                        n = n + 60;
                    }

                }
                xlocation = xlocation + 85;
                if (i % 1 == 0)
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
                if (item == "        Gola Da Limca")
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


                else if (item == "www.facebook.com/goladalimca" || item == "www.instagram.com/goladalimca")
                {
                    font = new Font("Calibri", 9);
                    graphic.DrawString(productLine, font, new SolidBrush(Color.Black), 30, startY + offset);
                    offset = offset + (int)fontHeight + 5; //make the spacing consistent
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
            int xlocation1 = 5;

            panel3.Controls.Clear();
            Button btn = (Button)sender;



            int n = 10;


            string query = "SELECT Name,ID,isAvailable FROM Items where Category='" + btn.Text + "' And Store ="+Program.shopid;
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

                    if (o % 3 == 0)
                    {


                        n = n + 60;
                    }

                }
                xlocation1 = xlocation1 + 130;
                if (o % 3 == 0)
                {
                    xlocation1 = 3;
                }


            }
            reader.Close();


        }
        public void btn_msg2(object sender, EventArgs e)
        {
            //newButton2.Controls.Clear();
        }
        public void ItemsAdd(object sender, EventArgs e)
        {

            Button btn = (Button)sender;

            String Query = "Select ID,Name,Price from Items where ID = " + btn.Name + " And Store = "+Program.shopid;
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

                        int reserve = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) + 1;
                        double r2 = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) + double.Parse(reader[2].ToString());
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
            textBox2.Text = textBox2.Text +0 ;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        public void Bill()
        {
            listBox1.Items.Add("_______________________________________________________________");

            if (metroRadioButton2.Checked)
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

                    listBox1.Items.Add("                                                     " + "Cash Paid   :   " + textBox1.Text);
                    double cashback = Convert.ToDouble(textBox1.Text) - Convert.ToDouble(label6.Text);
                    listBox1.Items.Add("                                                     " + "Cash Back   :   " + cashback.ToString());
                }

            }
       



        }

        public void KitchenReciept()
        {

            listBox2.Items.Add("        Counter Slip");
            listBox2.Items.Add("");
            listBox2.Items.Add("");
          
            if (metroRadioButton1.Checked)
            {
                listBox2.Items.Add("Table No : " + comboBox2.Text);
                listBox2.Items.Add("Order # " + ka.Text + "        D/T : " + DateTime.Today.ToShortDateString() + "  " + dateTimePicker1.Value.ToLongTimeString().ToString());
            }
            if (metroRadioButton2.Checked)
            {
                listBox2.Items.Add("Table No : " + comboBox1.Text);
                listBox2.Items.Add("Order # " + comboBox3.Text + "        D/T : " + DateTime.Today.ToShortDateString() + "  " + dateTimePicker1.Value.ToLongTimeString().ToString());

            }

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {

                listBox2.Items.Add((string)dataGridView1[1, i].Value);


                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[i].Clone();
                double val = Convert.ToDouble(dataGridView1[2, i].Value);
                val = System.Math.Round(val, 2);
                double val1 = Convert.ToDouble(dataGridView1[3, i].Value);
                val1 = System.Math.Round(val1, 2);
                listBox2.Items.Add("".PadRight(20) + String.Format("{0:0.00}", val).PadRight(12));
            }


           
                Print2();
            
          
            listBox2.Items.Clear();

        }
        Sales s = new Sales();
        TempClass t = new TempClass();
        private void button19_Click(object sender, EventArgs e)
        {
            
            Select s2 = new Select();
           
            if (metroRadioButton2.Checked)
            {

                t.Delete(comboBox1.Text, int.Parse(comboBox3.Text));

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
               
                   
                  ka.Text=  Convert.ToString(Convert.ToInt32(s2.MaxOrderNum()) + 1);
                  t.addTemp(comboBox1.Text, comboBox3.Text, dataGridView1[0, i].Value.ToString(), dataGridView1[2, i].Value.ToString());
                

                }


            }
            else if (metroRadioButton1.Checked)
            {

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    t.addTemp(comboBox2.Text, ka.Text, dataGridView1[0, i].Value.ToString(), dataGridView1[2, i].Value.ToString());
                   
                }
                s.Sale_Insert(int.Parse(ka.Text), 0, "-", 0, 0, comboBox2.Text, dateTimePicker1.Value.Date.ToString("yyyyMMdd"), "Dine","Paid");


            }

            DialogResult dr = MessageBox.Show("Print", "Do You want to Print Kitchen Reciept?", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                KitchenReciept();
            }
            else if (dr == DialogResult.No)
            {

            }


            
        }

       
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            comboBox3.Items.Clear();
            string query = "select Distinct(OrderNo) from [temprory table] where TableNo = "+comboBox1.Text +" And Store ="+Program.shopid;

            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());

            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                //metroTextBox2.Text = read["Name"].ToString();
                //metroTextBox3.Text = read["Address"].ToString();

                comboBox3.Items.Add(read[0]);
               
               

            }
            read.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string query = "select t.Item,i.Name,t.qty,i.Price,(t.qty * i.Price) as Total from [Temprory table] t join Items i on i.ID=t.Item where t.Tableno="+comboBox1.Text +" AND t.OrderNO="+comboBox3.Text +" And t.Store="+Program.shopid;

            SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());

            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                //metroTextBox2.Text = read["Name"].ToString();
                //metroTextBox3.Text = read["Address"].ToString();

                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = read[0];
                row.Cells[1].Value = read[1];
                row.Cells[2].Value = read[2];
                row.Cells[3].Value = read[3];
                row.Cells[4].Value = read[4];
                dataGridView1.Rows.Add(row);
               label6.Text= total().ToString();
                label7.Text = QTY().ToString();
            }
            read.Close();

          
        }

        private void button23_Click(object sender, EventArgs e)
        {
            InvoiceForm f = new InvoiceForm();
            f.Show();
            this.Hide();

        }

     
        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Visible = true;
            label9.Visible = true;
            label13.Visible = false;
            label14.Visible = false;
            comboBox1.Visible = false;
            comboBox3.Visible = false;
            button20.Visible = false;
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button20.Visible = true;
            comboBox2.Visible = false;
            label9.Visible = false;
            label13.Visible = true;
            label14.Visible = true;
            comboBox1.Visible = true;
            comboBox3.Visible = true;
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
        private void button20_Click(object sender, EventArgs e)
        {
            
           

            if (textBox1.Text != "" && int.Parse(textBox1.Text) >= int.Parse(label6.Text))
            {
                t.Delete(comboBox1.Text, int.Parse(comboBox3.Text));
                // delete from Sales where Sales.username = 'Dine' And Sale_Type = And Invoice_NO =
                t.DeleteSales(int.Parse(comboBox1.Text), int.Parse(comboBox3.Text));

                insertListData();
                insertSalesDineIn();
                Bill();

                DialogResult dr = MessageBox.Show("Print", "Do You want to Print?", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Print();
                }
                else if (dr == DialogResult.No)
                {

                }
                clear();

            }
            else
            {
                MessageBox.Show("Please Enter Cash Recieved ");
            }

           
            

        }

        

        public void insertSalesDineIn()
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





                s1.Sale_Insert(int.Parse(comboBox3.Text), Convert.ToInt32(dataGridView1[0, i].Value.ToString()), (string)dataGridView1[1, i].Value.ToString(), Convert.ToInt32(dataGridView1[2, i].Value.ToString()), Math.Round(Convert.ToDouble(dataGridView1[4, i].Value.ToString()) - (discount * Convert.ToInt32(dataGridView1[2, i].Value.ToString())), 2), "DineIn", dateTimePicker1.Value.Date.ToString("yyyyMMdd"), label12.Text,"Paid");

                


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
    }
}
