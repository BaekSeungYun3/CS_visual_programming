﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _020_DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime sDay = dateTimePicker1.Value;      //데이트타입 값으로 나옴

            txtdate.Text = today.Subtract(sDay).TotalDays.ToString("0");

        }
    }
}
