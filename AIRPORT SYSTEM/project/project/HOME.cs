﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Passengers_Click(object sender, EventArgs e)
        {
         
            Form Main= new nameverification();
            Main.Show();
           
        }

        private void Flight_Click(object sender, EventArgs e)
        {
            Form main = new ticket();
           main.Show();
        }
    }
}
