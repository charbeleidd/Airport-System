namespace project
{
    partial class nameverification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nameverification));
            this.lastname3 = new System.Windows.Forms.TextBox();
            this.firstname3 = new System.Windows.Forms.TextBox();
            this.lastname3_lb = new System.Windows.Forms.Label();
            this.firstname3_lb = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.allpass = new System.Windows.Forms.DataGridView();
            this.showall = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.passengerid_lb = new System.Windows.Forms.Label();
            this.passengerid = new System.Windows.Forms.TextBox();
            this.click = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.allpass)).BeginInit();
            this.SuspendLayout();
            // 
            // lastname3
            // 
            this.lastname3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lastname3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname3.ForeColor = System.Drawing.Color.White;
            this.lastname3.Location = new System.Drawing.Point(188, 148);
            this.lastname3.Margin = new System.Windows.Forms.Padding(4);
            this.lastname3.Name = "lastname3";
            this.lastname3.Size = new System.Drawing.Size(169, 29);
            this.lastname3.TabIndex = 40;
            // 
            // firstname3
            // 
            this.firstname3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.firstname3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname3.ForeColor = System.Drawing.Color.White;
            this.firstname3.Location = new System.Drawing.Point(188, 82);
            this.firstname3.Margin = new System.Windows.Forms.Padding(4);
            this.firstname3.Name = "firstname3";
            this.firstname3.Size = new System.Drawing.Size(169, 29);
            this.firstname3.TabIndex = 38;
            // 
            // lastname3_lb
            // 
            this.lastname3_lb.AutoSize = true;
            this.lastname3_lb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname3_lb.ForeColor = System.Drawing.Color.Navy;
            this.lastname3_lb.Location = new System.Drawing.Point(39, 148);
            this.lastname3_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastname3_lb.Name = "lastname3_lb";
            this.lastname3_lb.Size = new System.Drawing.Size(94, 22);
            this.lastname3_lb.TabIndex = 37;
            this.lastname3_lb.Text = "Last Name";
            // 
            // firstname3_lb
            // 
            this.firstname3_lb.AutoSize = true;
            this.firstname3_lb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname3_lb.ForeColor = System.Drawing.Color.Navy;
            this.firstname3_lb.Location = new System.Drawing.Point(39, 84);
            this.firstname3_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstname3_lb.Name = "firstname3_lb";
            this.firstname3_lb.Size = new System.Drawing.Size(98, 22);
            this.firstname3_lb.TabIndex = 35;
            this.firstname3_lb.Text = "First Name";
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.SystemColors.Control;
            this.add.Location = new System.Drawing.Point(47, 240);
            this.add.Margin = new System.Windows.Forms.Padding(4);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(117, 34);
            this.add.TabIndex = 44;
            this.add.Text = "REGISTER";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.Add_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.back.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.Control;
            this.back.Location = new System.Drawing.Point(855, 575);
            this.back.Margin = new System.Windows.Forms.Padding(4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(117, 34);
            this.back.TabIndex = 45;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // allpass
            // 
            this.allpass.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.allpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allpass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allpass.Location = new System.Drawing.Point(504, 69);
            this.allpass.Margin = new System.Windows.Forms.Padding(4);
            this.allpass.Name = "allpass";
            this.allpass.Size = new System.Drawing.Size(517, 416);
            this.allpass.TabIndex = 47;
            this.allpass.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allpass_CellContentClick);
            // 
            // showall
            // 
            this.showall.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.showall.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showall.ForeColor = System.Drawing.SystemColors.Control;
            this.showall.Location = new System.Drawing.Point(525, 21);
            this.showall.Margin = new System.Windows.Forms.Padding(4);
            this.showall.Name = "showall";
            this.showall.Size = new System.Drawing.Size(117, 34);
            this.showall.TabIndex = 48;
            this.showall.Text = "LIST";
            this.showall.UseVisualStyleBackColor = false;
            this.showall.Click += new System.EventHandler(this.Showall_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHECK/ADD PASSENGER";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.delete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.SystemColors.Control;
            this.delete.Location = new System.Drawing.Point(72, 415);
            this.delete.Margin = new System.Windows.Forms.Padding(4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(215, 34);
            this.delete.TabIndex = 66;
            this.delete.Text = "Delete PASSENGER";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // passengerid_lb
            // 
            this.passengerid_lb.AutoSize = true;
            this.passengerid_lb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengerid_lb.ForeColor = System.Drawing.Color.Navy;
            this.passengerid_lb.Location = new System.Drawing.Point(33, 336);
            this.passengerid_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passengerid_lb.Name = "passengerid_lb";
            this.passengerid_lb.Size = new System.Drawing.Size(119, 22);
            this.passengerid_lb.TabIndex = 67;
            this.passengerid_lb.Text = "Passenger_ID";
            // 
            // passengerid
            // 
            this.passengerid.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.passengerid.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengerid.ForeColor = System.Drawing.Color.White;
            this.passengerid.Location = new System.Drawing.Point(219, 334);
            this.passengerid.Margin = new System.Windows.Forms.Padding(4);
            this.passengerid.Name = "passengerid";
            this.passengerid.Size = new System.Drawing.Size(63, 29);
            this.passengerid.TabIndex = 68;
            this.passengerid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // click
            // 
            this.click.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.click.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.click.ForeColor = System.Drawing.SystemColors.Control;
            this.click.Location = new System.Drawing.Point(72, 494);
            this.click.Margin = new System.Windows.Forms.Padding(4);
            this.click.Name = "click";
            this.click.Size = new System.Drawing.Size(223, 34);
            this.click.TabIndex = 46;
            this.click.Text = "UPDATE PASSENGER";
            this.click.UseVisualStyleBackColor = false;
            this.click.Click += new System.EventHandler(this.Modify_Click);
            // 
            // nameverification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 622);
            this.Controls.Add(this.click);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passengerid);
            this.Controls.Add(this.passengerid_lb);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.showall);
            this.Controls.Add(this.allpass);
            this.Controls.Add(this.back);
            this.Controls.Add(this.add);
            this.Controls.Add(this.lastname3);
            this.Controls.Add(this.firstname3);
            this.Controls.Add(this.lastname3_lb);
            this.Controls.Add(this.firstname3_lb);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "nameverification";
            this.Text = "nameverification";
            this.Load += new System.EventHandler(this.Nameverification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allpass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastname3;
        private System.Windows.Forms.TextBox firstname3;
        private System.Windows.Forms.Label lastname3_lb;
        private System.Windows.Forms.Label firstname3_lb;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridView allpass;
        private System.Windows.Forms.Button showall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label passengerid_lb;
        private System.Windows.Forms.TextBox passengerid;
        private System.Windows.Forms.Button click;
    }
}