namespace GDL
{
    partial class updatecustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updatecustomer));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btninsert = new System.Windows.Forms.Button();
            this.address = new MetroFramework.Controls.MetroTextBox();
            this.name = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(83)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 40);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(83)))));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(249, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "(For Delivery)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(83)))));
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 30);
            this.label2.TabIndex = 37;
            this.label2.Text = "Update Customer";
            // 
            // btninsert
            // 
            this.btninsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(202)))));
            this.btninsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btninsert.BackgroundImage")));
            this.btninsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btninsert.FlatAppearance.BorderSize = 0;
            this.btninsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninsert.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btninsert.Location = new System.Drawing.Point(98, 382);
            this.btninsert.Margin = new System.Windows.Forms.Padding(2);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(140, 41);
            this.btninsert.TabIndex = 36;
            this.btninsert.Text = "Update";
            this.btninsert.UseVisualStyleBackColor = false;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // address
            // 
            // 
            // 
            // 
            this.address.CustomButton.Image = null;
            this.address.CustomButton.Location = new System.Drawing.Point(253, 2);
            this.address.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.address.CustomButton.Name = "";
            this.address.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.address.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.address.CustomButton.TabIndex = 1;
            this.address.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.address.CustomButton.UseSelectable = true;
            this.address.CustomButton.Visible = false;
            this.address.Icon = global::GDL.Properties.Resources.price;
            this.address.Lines = new string[0];
            this.address.Location = new System.Drawing.Point(27, 322);
            this.address.Margin = new System.Windows.Forms.Padding(2);
            this.address.MaxLength = 32767;
            this.address.Name = "address";
            this.address.PasswordChar = '\0';
            this.address.PromptText = "Address";
            this.address.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.address.SelectedText = "";
            this.address.SelectionLength = 0;
            this.address.SelectionStart = 0;
            this.address.ShortcutsEnabled = true;
            this.address.Size = new System.Drawing.Size(291, 40);
            this.address.TabIndex = 35;
            this.address.UseSelectable = true;
            this.address.WaterMark = "Address";
            this.address.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.address.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // name
            // 
            // 
            // 
            // 
            this.name.CustomButton.Image = null;
            this.name.CustomButton.Location = new System.Drawing.Point(253, 2);
            this.name.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.name.CustomButton.Name = "";
            this.name.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.name.CustomButton.TabIndex = 1;
            this.name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.name.CustomButton.UseSelectable = true;
            this.name.CustomButton.Visible = false;
            this.name.Icon = global::GDL.Properties.Resources.tomato;
            this.name.Lines = new string[0];
            this.name.Location = new System.Drawing.Point(27, 268);
            this.name.Margin = new System.Windows.Forms.Padding(2);
            this.name.MaxLength = 32767;
            this.name.Name = "name";
            this.name.PasswordChar = '\0';
            this.name.PromptText = "Name";
            this.name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.name.SelectedText = "";
            this.name.SelectionLength = 0;
            this.name.SelectionStart = 0;
            this.name.ShortcutsEnabled = true;
            this.name.Size = new System.Drawing.Size(291, 40);
            this.name.TabIndex = 33;
            this.name.UseSelectable = true;
            this.name.WaterMark = "Name";
            this.name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // updatecustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(358, 475);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.address);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "updatecustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "updatecustomer";
            this.Load += new System.EventHandler(this.updatecustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btninsert;
        private MetroFramework.Controls.MetroTextBox address;
        private MetroFramework.Controls.MetroTextBox name;
        private System.Windows.Forms.Label label1;
    }
}