namespace project
{
    partial class flightlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flightlist));
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.DataGridView();
            this.showall = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.ticketid = new System.Windows.Forms.TextBox();
            this.ticketid_lb = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker9 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.list)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(435, 265);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 27);
            this.label5.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(466, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flight List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // list
            // 
            this.list.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list.Location = new System.Drawing.Point(335, 69);
            this.list.Margin = new System.Windows.Forms.Padding(4);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(670, 417);
            this.list.TabIndex = 83;
            this.list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.list_CellContentClick);
            // 
            // showall
            // 
            this.showall.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.showall.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showall.ForeColor = System.Drawing.Color.White;
            this.showall.Location = new System.Drawing.Point(618, 527);
            this.showall.Margin = new System.Windows.Forms.Padding(4);
            this.showall.Name = "showall";
            this.showall.Size = new System.Drawing.Size(117, 34);
            this.showall.TabIndex = 105;
            this.showall.Text = "Show ALL";
            this.showall.UseVisualStyleBackColor = false;
            this.showall.Click += new System.EventHandler(this.Button1_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.delete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(38, 242);
            this.delete.Margin = new System.Windows.Forms.Padding(4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(117, 34);
            this.delete.TabIndex = 106;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ticketid
            // 
            this.ticketid.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ticketid.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketid.ForeColor = System.Drawing.Color.White;
            this.ticketid.Location = new System.Drawing.Point(38, 142);
            this.ticketid.Margin = new System.Windows.Forms.Padding(4);
            this.ticketid.Name = "ticketid";
            this.ticketid.Size = new System.Drawing.Size(116, 29);
            this.ticketid.TabIndex = 107;
            this.ticketid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ticketid.TextChanged += new System.EventHandler(this.Ticketid_TextChanged);
            // 
            // ticketid_lb
            // 
            this.ticketid_lb.AutoSize = true;
            this.ticketid_lb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketid_lb.ForeColor = System.Drawing.Color.Navy;
            this.ticketid_lb.Location = new System.Drawing.Point(54, 85);
            this.ticketid_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ticketid_lb.Name = "ticketid_lb";
            this.ticketid_lb.Size = new System.Drawing.Size(84, 22);
            this.ticketid_lb.TabIndex = 108;
            this.ticketid_lb.Text = "Ticket ID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(37, 400);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 34);
            this.button1.TabIndex = 109;
            this.button1.Text = "Modify Date-Time";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // dateTimePicker9
            // 
            this.dateTimePicker9.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateTimePicker9.CalendarMonthBackground = System.Drawing.SystemColors.ButtonFace;
            this.dateTimePicker9.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            this.dateTimePicker9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker9.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker9.Location = new System.Drawing.Point(38, 331);
            this.dateTimePicker9.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker9.Name = "dateTimePicker9";
            this.dateTimePicker9.Size = new System.Drawing.Size(215, 29);
            this.dateTimePicker9.TabIndex = 110;
            // 
            // flightlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 608);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ticketid_lb);
            this.Controls.Add(this.ticketid);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.showall);
            this.Controls.Add(this.list);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "flightlist";
            this.Text = "flightlist";
            ((System.ComponentModel.ISupportInitialize)(this.list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView list;
        private System.Windows.Forms.Button showall;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox ticketid;
        private System.Windows.Forms.Label ticketid_lb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker9;
    }
}