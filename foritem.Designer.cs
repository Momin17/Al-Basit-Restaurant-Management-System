namespace GDL
{
    partial class foritem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(foritem));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dg = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.avail = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btninsert = new System.Windows.Forms.Button();
            this.mtcost = new MetroFramework.Controls.MetroTextBox();
            this.mtprice = new MetroFramework.Controls.MetroTextBox();
            this.mtcategory = new MetroFramework.Controls.MetroTextBox();
            this.mtname = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(83)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(27, 26);
            this.dg.Margin = new System.Windows.Forms.Padding(2);
            this.dg.Name = "dg";
            this.dg.RowTemplate.Height = 24;
            this.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg.Size = new System.Drawing.Size(590, 284);
            this.dg.TabIndex = 6;
            this.dg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellClick);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(201)))));
            this.btndelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndelete.BackgroundImage")));
            this.btndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndelete.Location = new System.Drawing.Point(829, 518);
            this.btndelete.Margin = new System.Windows.Forms.Padding(2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(143, 44);
            this.btndelete.TabIndex = 5;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(201)))));
            this.btnupdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnupdate.BackgroundImage")));
            this.btnupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnupdate.Location = new System.Drawing.Point(640, 518);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(143, 44);
            this.btnupdate.TabIndex = 4;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 496);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.metroTextBox2.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(12, 9);
            this.metroTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.PromptText = "Search By Category";
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(217, 19);
            this.metroTextBox2.TabIndex = 2;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMark = "Search By Category";
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox2.TextChanged += new System.EventHandler(this.metroTextBox2_TextChanged);
            this.metroTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox2_KeyPress);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(223, 1);
            this.metroTextBox1.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(10, 9);
            this.metroTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "Search By Name";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(241, 19);
            this.metroTextBox1.TabIndex = 1;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "Search By Name";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox1.TextChanged += new System.EventHandler(this.metroTextBox1_TextChanged);
            this.metroTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(83)))));
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(43, 389);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Isavailable";
            // 
            // avail
            // 
            this.avail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.avail.FormattingEnabled = true;
            this.avail.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.avail.Location = new System.Drawing.Point(41, 412);
            this.avail.Margin = new System.Windows.Forms.Padding(2);
            this.avail.Name = "avail";
            this.avail.Size = new System.Drawing.Size(291, 21);
            this.avail.TabIndex = 28;
            this.avail.Text = "Yes ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(83)))));
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(110, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 30);
            this.label2.TabIndex = 27;
            this.label2.Text = "Add Items";
            // 
            // btninsert
            // 
            this.btninsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(202)))));
            this.btninsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btninsert.BackgroundImage")));
            this.btninsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btninsert.FlatAppearance.BorderSize = 0;
            this.btninsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninsert.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(83)))));
            this.btninsert.Location = new System.Drawing.Point(89, 452);
            this.btninsert.Margin = new System.Windows.Forms.Padding(2);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(172, 45);
            this.btninsert.TabIndex = 26;
            this.btninsert.Text = "Add";
            this.btninsert.UseVisualStyleBackColor = false;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click_1);
            // 
            // mtcost
            // 
            // 
            // 
            // 
            this.mtcost.CustomButton.Image = null;
            this.mtcost.CustomButton.Location = new System.Drawing.Point(265, 2);
            this.mtcost.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtcost.CustomButton.Name = "";
            this.mtcost.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtcost.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtcost.CustomButton.TabIndex = 1;
            this.mtcost.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtcost.CustomButton.UseSelectable = true;
            this.mtcost.CustomButton.Visible = false;
            this.mtcost.Icon = global::GDL.Properties.Resources.calculator;
            this.mtcost.Lines = new string[0];
            this.mtcost.Location = new System.Drawing.Point(40, 347);
            this.mtcost.Margin = new System.Windows.Forms.Padding(2);
            this.mtcost.MaxLength = 32767;
            this.mtcost.Name = "mtcost";
            this.mtcost.PasswordChar = '\0';
            this.mtcost.PromptText = "Cost";
            this.mtcost.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtcost.SelectedText = "";
            this.mtcost.SelectionLength = 0;
            this.mtcost.SelectionStart = 0;
            this.mtcost.ShortcutsEnabled = true;
            this.mtcost.Size = new System.Drawing.Size(291, 28);
            this.mtcost.TabIndex = 25;
            this.mtcost.UseSelectable = true;
            this.mtcost.WaterMark = "Cost";
            this.mtcost.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtcost.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtprice
            // 
            // 
            // 
            // 
            this.mtprice.CustomButton.Image = null;
            this.mtprice.CustomButton.Location = new System.Drawing.Point(265, 2);
            this.mtprice.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtprice.CustomButton.Name = "";
            this.mtprice.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtprice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtprice.CustomButton.TabIndex = 1;
            this.mtprice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtprice.CustomButton.UseSelectable = true;
            this.mtprice.CustomButton.Visible = false;
            this.mtprice.Icon = global::GDL.Properties.Resources.price;
            this.mtprice.Lines = new string[0];
            this.mtprice.Location = new System.Drawing.Point(40, 303);
            this.mtprice.Margin = new System.Windows.Forms.Padding(2);
            this.mtprice.MaxLength = 32767;
            this.mtprice.Name = "mtprice";
            this.mtprice.PasswordChar = '\0';
            this.mtprice.PromptText = "Price";
            this.mtprice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtprice.SelectedText = "";
            this.mtprice.SelectionLength = 0;
            this.mtprice.SelectionStart = 0;
            this.mtprice.ShortcutsEnabled = true;
            this.mtprice.Size = new System.Drawing.Size(291, 28);
            this.mtprice.TabIndex = 24;
            this.mtprice.UseSelectable = true;
            this.mtprice.WaterMark = "Price";
            this.mtprice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtprice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtcategory
            // 
            this.mtcategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.mtcategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.mtcategory.CustomButton.Image = null;
            this.mtcategory.CustomButton.Location = new System.Drawing.Point(265, 2);
            this.mtcategory.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtcategory.CustomButton.Name = "";
            this.mtcategory.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtcategory.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtcategory.CustomButton.TabIndex = 1;
            this.mtcategory.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtcategory.CustomButton.UseSelectable = true;
            this.mtcategory.CustomButton.Visible = false;
            this.mtcategory.Icon = global::GDL.Properties.Resources.category;
            this.mtcategory.Lines = new string[0];
            this.mtcategory.Location = new System.Drawing.Point(40, 263);
            this.mtcategory.Margin = new System.Windows.Forms.Padding(2);
            this.mtcategory.MaxLength = 32767;
            this.mtcategory.Name = "mtcategory";
            this.mtcategory.PasswordChar = '\0';
            this.mtcategory.PromptText = "Category";
            this.mtcategory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtcategory.SelectedText = "";
            this.mtcategory.SelectionLength = 0;
            this.mtcategory.SelectionStart = 0;
            this.mtcategory.ShortcutsEnabled = true;
            this.mtcategory.Size = new System.Drawing.Size(291, 28);
            this.mtcategory.TabIndex = 23;
            this.mtcategory.UseSelectable = true;
            this.mtcategory.WaterMark = "Category";
            this.mtcategory.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtcategory.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtname
            // 
            // 
            // 
            // 
            this.mtname.CustomButton.Image = null;
            this.mtname.CustomButton.Location = new System.Drawing.Point(265, 2);
            this.mtname.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtname.CustomButton.Name = "";
            this.mtname.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtname.CustomButton.TabIndex = 1;
            this.mtname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtname.CustomButton.UseSelectable = true;
            this.mtname.CustomButton.Visible = false;
            this.mtname.Icon = global::GDL.Properties.Resources.tomato;
            this.mtname.Lines = new string[0];
            this.mtname.Location = new System.Drawing.Point(40, 224);
            this.mtname.Margin = new System.Windows.Forms.Padding(2);
            this.mtname.MaxLength = 32767;
            this.mtname.Name = "mtname";
            this.mtname.PasswordChar = '\0';
            this.mtname.PromptText = "Name";
            this.mtname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtname.SelectedText = "";
            this.mtname.SelectionLength = 0;
            this.mtname.SelectionStart = 0;
            this.mtname.ShortcutsEnabled = true;
            this.mtname.Size = new System.Drawing.Size(291, 28);
            this.mtname.TabIndex = 22;
            this.mtname.UseSelectable = true;
            this.mtname.WaterMark = "Name";
            this.mtname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(83)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(115, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.dg);
            this.panel1.Location = new System.Drawing.Point(462, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 332);
            this.panel1.TabIndex = 46;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.metroTextBox1);
            this.panel2.Location = new System.Drawing.Point(464, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 37);
            this.panel2.TabIndex = 47;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.metroTextBox2);
            this.panel3.Location = new System.Drawing.Point(867, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 37);
            this.panel3.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(83)))));
            this.label4.Location = new System.Drawing.Point(686, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 30);
            this.label4.TabIndex = 48;
            this.label4.Text = "Items Information";
            // 
            // foritem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1132, 580);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.avail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.mtcost);
            this.Controls.Add(this.mtprice);
            this.Controls.Add(this.mtcategory);
            this.Controls.Add(this.mtname);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "foritem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "foritem";
            this.Load += new System.EventHandler(this.foritem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox avail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btninsert;
        private MetroFramework.Controls.MetroTextBox mtcost;
        private MetroFramework.Controls.MetroTextBox mtprice;
        private MetroFramework.Controls.MetroTextBox mtcategory;
        private MetroFramework.Controls.MetroTextBox mtname;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
    }
}