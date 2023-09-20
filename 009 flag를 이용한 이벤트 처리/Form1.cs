using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _009_flag를_이용한_이벤트_처리
{
    public partial class Form1 : Form
    {
        private bool flag;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == false) { 
                label1.Text = "Hello world!";
                flag = true;
            }
            else
            {
                label1.Text = "";
                flag = false;
            }

        }
    }
}
