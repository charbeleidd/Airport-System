namespace project
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Passengers = new System.Windows.Forms.Button();
            this.ticket = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Passengers
            // 
            this.Passengers.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passengers.Location = new System.Drawing.Point(160, 153);
            this.Passengers.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Passengers.Name = "Passengers";
            this.Passengers.Size = new System.Drawing.Size(456, 63);
            this.Passengers.TabIndex = 4;
            this.Passengers.Text = "Passenger";
            this.Passengers.UseVisualStyleBackColor = true;
            this.Passengers.Click += new System.EventHandler(this.Passengers_Click);
            // 
            // ticket
            // 
            this.ticket.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticket.Location = new System.Drawing.Point(160, 316);
            this.ticket.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ticket.Name = "ticket";
            this.ticket.Size = new System.Drawing.Size(456, 63);
            this.ticket.TabIndex = 5;
            this.ticket.Text = "TICKET REGISTRATION";
            this.ticket.UseVisualStyleBackColor = true;
            this.ticket.Click += new System.EventHandler(this.Flight_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(494, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "WELCOME ABORD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 617);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ticket);
            this.Controls.Add(this.Passengers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Main";
            this.Text = "HOME PAGE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Passengers;
        private System.Windows.Forms.Button ticket;
        private System.Windows.Forms.Label label1;
    }
}

