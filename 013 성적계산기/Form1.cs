﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _013_성적계산기
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double sum = Convert.ToDouble(txtKor.Text)
                + Convert.ToDouble(txtmath.Text) + Convert.ToDouble(txteng.Text);

            double avg = sum / 3;

            txtsum.Text = sum.ToString();
            txtavg.Text = avg.ToString("0.0");
        }
    }
}
