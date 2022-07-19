namespace GDL
{
    partial class updatesupplies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updatesupplies));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btninsert = new System.Windows.Forms.Button();
            this.mtnic = new MetroFramework.Controls.MetroTextBox();
            this.mtsname = new MetroFramework.Controls.MetroTextBox();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.mtdes = new MetroFramework.Controls.MetroTextBox();
            this.mtname = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dg2 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 535);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(83)))));
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 30);
            this.label2.TabIndex = 39;
            this.label2.Text = "Update Supplies";
            // 
            // btninsert
            // 
            this.btninsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(202)))));
            this.btninsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btninsert.BackgroundImage")));
            this.btninsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btninsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btninsert.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(83)))));
            this.btninsert.Location = new System.Drawing.Point(81, 406);
            this.btninsert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(117, 41);
            this.btninsert.TabIndex = 38;
            this.btninsert.Text = "Update";
            this.btninsert.UseVisualStyleBackColor = false;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // mtnic
            // 
            // 
            // 
            // 
            this.mtnic.CustomButton.Image = null;
            this.mtnic.CustomButton.Location = new System.Drawing.Point(206, 2);
            this.mtnic.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtnic.CustomButton.Name = "";
            this.mtnic.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtnic.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtnic.CustomButton.TabIndex = 1;
            this.mtnic.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtnic.CustomButton.UseSelectable = true;
            this.mtnic.CustomButton.Visible = false;
            this.mtnic.Enabled = false;
            this.mtnic.Lines = new string[0];
            this.mtnic.Location = new System.Drawing.Point(27, 253);
            this.mtnic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtnic.MaxLength = 32767;
            this.mtnic.Name = "mtnic";
            this.mtnic.PasswordChar = '\0';
            this.mtnic.PromptText = "Supplier NIC";
            this.mtnic.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtnic.SelectedText = "";
            this.mtnic.SelectionLength = 0;
            this.mtnic.SelectionStart = 0;
            this.mtnic.ShortcutsEnabled = true;
            this.mtnic.Size = new System.Drawing.Size(230, 26);
            this.mtnic.TabIndex = 50;
            this.mtnic.UseSelectable = true;
            this.mtnic.WaterMark = "Supplier NIC";
            this.mtnic.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtnic.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtsname
            // 
            // 
            // 
            // 
            this.mtsname.CustomButton.Image = null;
            this.mtsname.CustomButton.Location = new System.Drawing.Point(206, 2);
            this.mtsname.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtsname.CustomButton.Name = "";
            this.mtsname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtsname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtsname.CustomButton.TabIndex = 1;
            this.mtsname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtsname.CustomButton.UseSelectable = true;
            this.mtsname.CustomButton.Visible = false;
            this.mtsname.Enabled = false;
            this.mtsname.Lines = new string[0];
            this.mtsname.Location = new System.Drawing.Point(27, 197);
            this.mtsname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtsname.MaxLength = 32767;
            this.mtsname.Name = "mtsname";
            this.mtsname.PasswordChar = '\0';
            this.mtsname.PromptText = "Supplier Name";
            this.mtsname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtsname.SelectedText = "";
            this.mtsname.SelectionLength = 0;
            this.mtsname.SelectionStart = 0;
            this.mtsname.ShortcutsEnabled = true;
            this.mtsname.Size = new System.Drawing.Size(230, 26);
            this.mtsname.TabIndex = 49;
            this.mtsname.UseSelectable = true;
            this.mtsname.WaterMark = "Supplier Name";
            this.mtsname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtsname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.CustomFormat = "yyyy-MM-dd";
            this.metroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.metroDateTime1.Location = new System.Drawing.Point(26, 368);
            this.metroDateTime1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(231, 29);
            this.metroDateTime1.TabIndex = 47;
            this.metroDateTime1.ValueChanged += new System.EventHandler(this.metroDateTime1_ValueChanged);
            // 
            // mtdes
            // 
            // 
            // 
            // 
            this.mtdes.CustomButton.Image = null;
            this.mtdes.CustomButton.Location = new System.Drawing.Point(206, 2);
            this.mtdes.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtdes.CustomButton.Name = "";
            this.mtdes.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtdes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtdes.CustomButton.TabIndex = 1;
            this.mtdes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtdes.CustomButton.UseSelectable = true;
            this.mtdes.CustomButton.Visible = false;
            this.mtdes.Lines = new string[0];
            this.mtdes.Location = new System.Drawing.Point(27, 313);
            this.mtdes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtdes.MaxLength = 32767;
            this.mtdes.Name = "mtdes";
            this.mtdes.PasswordChar = '\0';
            this.mtdes.PromptText = "Description";
            this.mtdes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtdes.SelectedText = "";
            this.mtdes.SelectionLength = 0;
            this.mtdes.SelectionStart = 0;
            this.mtdes.ShortcutsEnabled = true;
            this.mtdes.Size = new System.Drawing.Size(230, 26);
            this.mtdes.TabIndex = 44;
            this.mtdes.UseSelectable = true;
            this.mtdes.WaterMark = "Description";
            this.mtdes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtdes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtdes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtdes_KeyPress);
            // 
            // mtname
            // 
            // 
            // 
            // 
            this.mtname.CustomButton.Image = null;
            this.mtname.CustomButton.Location = new System.Drawing.Point(206, 2);
            this.mtname.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtname.CustomButton.Name = "";
            this.mtname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtname.CustomButton.TabIndex = 1;
            this.mtname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtname.CustomButton.UseSelectable = true;
            this.mtname.CustomButton.Visible = false;
            this.mtname.Lines = new string[0];
            this.mtname.Location = new System.Drawing.Point(27, 137);
            this.mtname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtname.MaxLength = 32767;
            this.mtname.Name = "mtname";
            this.mtname.PasswordChar = '\0';
            this.mtname.PromptText = "Item Name";
            this.mtname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtname.SelectedText = "";
            this.mtname.SelectionLength = 0;
            this.mtname.SelectionStart = 0;
            this.mtname.ShortcutsEnabled = true;
            this.mtname.Size = new System.Drawing.Size(230, 26);
            this.mtname.TabIndex = 42;
            this.mtname.UseSelectable = true;
            this.mtname.WaterMark = "Item Name";
            this.mtname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtname_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(83)))));
            this.label3.Location = new System.Drawing.Point(411, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 36);
            this.label3.TabIndex = 52;
            this.label3.Text = "Suppliers Informations";
            // 
            // dg2
            // 
            this.dg2.AllowUserToAddRows = false;
            this.dg2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg2.Location = new System.Drawing.Point(28, 26);
            this.dg2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dg2.Name = "dg2";
            this.dg2.RowTemplate.Height = 24;
            this.dg2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg2.Size = new System.Drawing.Size(427, 260);
            this.dg2.TabIndex = 51;
            this.dg2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg2_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(83)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 41);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(83)))));
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 53;
            this.label4.Text = "Item Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(83)))));
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 176);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 19);
            this.label5.TabIndex = 54;
            this.label5.Text = "Supplier name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(83)))));
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 232);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 19);
            this.label6.TabIndex = 55;
            this.label6.Text = "Supplier NIC";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(83)))));
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(27, 293);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 19);
            this.label8.TabIndex = 57;
            this.label8.Text = "Description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(83)))));
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(23, 347);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 19);
            this.label10.TabIndex = 59;
            this.label10.Text = "Date";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.dg2);
            this.panel1.Location = new System.Drawing.Point(328, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 303);
            this.panel1.TabIndex = 60;
            // 
            // updatesupplies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 489);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtnic);
            this.Controls.Add(this.mtsname);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.mtdes);
            this.Controls.Add(this.mtname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "updatesupplies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "updatesupplies";
            this.Load += new System.EventHandler(this.updatesupplies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox mtnic;
        private MetroFramework.Controls.MetroTextBox mtsname;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroTextBox mtdes;
        private MetroFramework.Controls.MetroTextBox mtname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dg2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
    }
}