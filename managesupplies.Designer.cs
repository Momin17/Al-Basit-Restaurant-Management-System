namespace GDL
{
    partial class managesupplies
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(managesupplies));
            this.label2 = new System.Windows.Forms.Label();
            this.btninsert = new System.Windows.Forms.Button();
            this.mtdes = new MetroFramework.Controls.MetroTextBox();
            this.mtamount = new MetroFramework.Controls.MetroTextBox();
            this.mtname = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.mtsname = new MetroFramework.Controls.MetroTextBox();
            this.mtnic = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(83)))));
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(95, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 30);
            this.label2.TabIndex = 27;
            this.label2.Text = "Add Supplies";
            // 
            // btninsert
            // 
            this.btninsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(202)))));
            this.btninsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btninsert.BackgroundImage")));
            this.btninsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btninsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btninsert.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(83)))));
            this.btninsert.Location = new System.Drawing.Point(101, 457);
            this.btninsert.Margin = new System.Windows.Forms.Padding(2);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(138, 55);
            this.btninsert.TabIndex = 25;
            this.btninsert.Text = "Add";
            this.btninsert.UseVisualStyleBackColor = false;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // mtdes
            // 
            // 
            // 
            // 
            this.mtdes.CustomButton.Image = null;
            this.mtdes.CustomButton.Location = new System.Drawing.Point(238, 2);
            this.mtdes.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtdes.CustomButton.Name = "";
            this.mtdes.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtdes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtdes.CustomButton.TabIndex = 1;
            this.mtdes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtdes.CustomButton.UseSelectable = true;
            this.mtdes.CustomButton.Visible = false;
            this.mtdes.Lines = new string[0];
            this.mtdes.Location = new System.Drawing.Point(39, 363);
            this.mtdes.Margin = new System.Windows.Forms.Padding(2);
            this.mtdes.MaxLength = 32767;
            this.mtdes.Name = "mtdes";
            this.mtdes.PasswordChar = '\0';
            this.mtdes.PromptText = "Description";
            this.mtdes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtdes.SelectedText = "";
            this.mtdes.SelectionLength = 0;
            this.mtdes.SelectionStart = 0;
            this.mtdes.ShortcutsEnabled = true;
            this.mtdes.Size = new System.Drawing.Size(262, 26);
            this.mtdes.TabIndex = 22;
            this.mtdes.UseSelectable = true;
            this.mtdes.WaterMark = "Description";
            this.mtdes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtdes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtamount
            // 
            // 
            // 
            // 
            this.mtamount.CustomButton.Image = null;
            this.mtamount.CustomButton.Location = new System.Drawing.Point(238, 2);
            this.mtamount.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtamount.CustomButton.Name = "";
            this.mtamount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtamount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtamount.CustomButton.TabIndex = 1;
            this.mtamount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtamount.CustomButton.UseSelectable = true;
            this.mtamount.CustomButton.Visible = false;
            this.mtamount.Lines = new string[0];
            this.mtamount.Location = new System.Drawing.Point(39, 314);
            this.mtamount.Margin = new System.Windows.Forms.Padding(2);
            this.mtamount.MaxLength = 32767;
            this.mtamount.Name = "mtamount";
            this.mtamount.PasswordChar = '\0';
            this.mtamount.PromptText = "Amount";
            this.mtamount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtamount.SelectedText = "";
            this.mtamount.SelectionLength = 0;
            this.mtamount.SelectionStart = 0;
            this.mtamount.ShortcutsEnabled = true;
            this.mtamount.Size = new System.Drawing.Size(262, 26);
            this.mtamount.TabIndex = 21;
            this.mtamount.UseSelectable = true;
            this.mtamount.WaterMark = "Amount";
            this.mtamount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtamount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtamount_KeyPress);
            // 
            // mtname
            // 
            // 
            // 
            // 
            this.mtname.CustomButton.Image = null;
            this.mtname.CustomButton.Location = new System.Drawing.Point(238, 2);
            this.mtname.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtname.CustomButton.Name = "";
            this.mtname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtname.CustomButton.TabIndex = 1;
            this.mtname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtname.CustomButton.UseSelectable = true;
            this.mtname.CustomButton.Visible = false;
            this.mtname.Lines = new string[0];
            this.mtname.Location = new System.Drawing.Point(39, 190);
            this.mtname.Margin = new System.Windows.Forms.Padding(2);
            this.mtname.MaxLength = 32767;
            this.mtname.Name = "mtname";
            this.mtname.PasswordChar = '\0';
            this.mtname.PromptText = "Item Name";
            this.mtname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtname.SelectedText = "";
            this.mtname.SelectionLength = 0;
            this.mtname.SelectionStart = 0;
            this.mtname.ShortcutsEnabled = true;
            this.mtname.Size = new System.Drawing.Size(262, 26);
            this.mtname.TabIndex = 20;
            this.mtname.UseSelectable = true;
            this.mtname.WaterMark = "Item Name";
            this.mtname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtname_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(444, 234);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 257);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 21);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(602, 217);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(924, 503);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 50);
            this.button3.TabIndex = 46;
            this.button3.Text = "Paying Records";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(83)))));
            this.label12.Location = new System.Drawing.Point(1015, 157);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 26);
            this.label12.TabIndex = 45;
            this.label12.Text = "-- Rs";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(83)))));
            this.label13.Location = new System.Drawing.Point(899, 131);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 52);
            this.label13.TabIndex = 44;
            this.label13.Text = "Remaining\r\nAmount:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(83)))));
            this.label10.Location = new System.Drawing.Point(795, 157);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 26);
            this.label10.TabIndex = 43;
            this.label10.Text = "-- Rs";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(83)))));
            this.label11.Location = new System.Drawing.Point(683, 131);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 52);
            this.label11.TabIndex = 42;
            this.label11.Text = "Paid \r\nAmount:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(83)))));
            this.label9.Location = new System.Drawing.Point(682, 80);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 31);
            this.label9.TabIndex = 41;
            this.label9.Text = "-- ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(83)))));
            this.label8.Location = new System.Drawing.Point(481, 81);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 30);
            this.label8.TabIndex = 40;
            this.label8.Text = "Supplier Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 499);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(83)))));
            this.label6.Location = new System.Drawing.Point(579, 157);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 26);
            this.label6.TabIndex = 38;
            this.label6.Text = "-- Rs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(83)))));
            this.label5.Location = new System.Drawing.Point(481, 131);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 52);
            this.label5.TabIndex = 37;
            this.label5.Text = "Total \r\nAmount:";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(563, 2);
            this.metroTextBox1.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(6, 3);
            this.metroTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "Search By Item Name";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(589, 28);
            this.metroTextBox1.TabIndex = 35;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "Search By Item Name";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox1.TextChanged += new System.EventHandler(this.metroTextBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(474, 505);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 50);
            this.button2.TabIndex = 33;
            this.button2.Text = "Pay";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(701, 505);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 50);
            this.button1.TabIndex = 32;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 478);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.CustomFormat = "yyyy-MM-dd";
            this.metroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.metroDateTime1.Location = new System.Drawing.Point(39, 412);
            this.metroDateTime1.Margin = new System.Windows.Forms.Padding(2);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(263, 29);
            this.metroDateTime1.TabIndex = 30;
            this.metroDateTime1.ValueChanged += new System.EventHandler(this.metroDateTime1_ValueChanged);
            // 
            // mtsname
            // 
            // 
            // 
            // 
            this.mtsname.CustomButton.Image = null;
            this.mtsname.CustomButton.Location = new System.Drawing.Point(238, 2);
            this.mtsname.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtsname.CustomButton.Name = "";
            this.mtsname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtsname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtsname.CustomButton.TabIndex = 1;
            this.mtsname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtsname.CustomButton.UseSelectable = true;
            this.mtsname.CustomButton.Visible = false;
            this.mtsname.Enabled = false;
            this.mtsname.Lines = new string[0];
            this.mtsname.Location = new System.Drawing.Point(39, 229);
            this.mtsname.Margin = new System.Windows.Forms.Padding(2);
            this.mtsname.MaxLength = 32767;
            this.mtsname.Name = "mtsname";
            this.mtsname.PasswordChar = '\0';
            this.mtsname.PromptText = "Supplier Name";
            this.mtsname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtsname.SelectedText = "";
            this.mtsname.SelectionLength = 0;
            this.mtsname.SelectionStart = 0;
            this.mtsname.ShortcutsEnabled = true;
            this.mtsname.Size = new System.Drawing.Size(262, 26);
            this.mtsname.TabIndex = 34;
            this.mtsname.UseSelectable = true;
            this.mtsname.WaterMark = "Supplier Name";
            this.mtsname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtsname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtnic
            // 
            // 
            // 
            // 
            this.mtnic.CustomButton.Image = null;
            this.mtnic.CustomButton.Location = new System.Drawing.Point(238, 2);
            this.mtnic.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtnic.CustomButton.Name = "";
            this.mtnic.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtnic.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtnic.CustomButton.TabIndex = 1;
            this.mtnic.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtnic.CustomButton.UseSelectable = true;
            this.mtnic.CustomButton.Visible = false;
            this.mtnic.Enabled = false;
            this.mtnic.Lines = new string[0];
            this.mtnic.Location = new System.Drawing.Point(39, 270);
            this.mtnic.Margin = new System.Windows.Forms.Padding(2);
            this.mtnic.MaxLength = 32767;
            this.mtnic.Name = "mtnic";
            this.mtnic.PasswordChar = '\0';
            this.mtnic.PromptText = "Supplier NIC";
            this.mtnic.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtnic.SelectedText = "";
            this.mtnic.SelectionLength = 0;
            this.mtnic.SelectionStart = 0;
            this.mtnic.ShortcutsEnabled = true;
            this.mtnic.Size = new System.Drawing.Size(262, 26);
            this.mtnic.TabIndex = 35;
            this.mtnic.UseSelectable = true;
            this.mtnic.WaterMark = "Supplier NIC";
            this.mtnic.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtnic.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(83)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 38);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.metroTextBox1);
            this.panel2.Location = new System.Drawing.Point(474, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 35);
            this.panel2.TabIndex = 48;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(83)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(109, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(83)))));
            this.label3.Location = new System.Drawing.Point(649, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 30);
            this.label3.TabIndex = 50;
            this.label3.Text = "Supplier Information";
            // 
            // managesupplies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1116, 570);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.mtnic);
            this.Controls.Add(this.mtsname);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.mtdes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtamount);
            this.Controls.Add(this.mtname);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "managesupplies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "managesupplies";
            this.Load += new System.EventHandler(this.managesupplies_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btninsert;
        private MetroFramework.Controls.MetroTextBox mtdes;
        private MetroFramework.Controls.MetroTextBox mtamount;
        private MetroFramework.Controls.MetroTextBox mtname;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox mtsname;
        private MetroFramework.Controls.MetroTextBox mtnic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
    }
}