﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _005_두_개의_폼
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            this.ClientSize = new System.Drawing.Size(500,500);
            button1.Location = new System.Drawing.Point(
                500 / 2 - button1.Width / 2, 500 / 2 - button1.Height / 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            this.AddOwnedForm(f2);
            f2.Show();
        }
    }
}
