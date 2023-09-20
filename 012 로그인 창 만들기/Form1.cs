using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _012_로그인_창_만들기
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "abcd" && txtpassword.Text == "1234")
                txtResult.Text = "로그인 성공";
            else 
                txtResult.Text = "로그인 실패";
        }
    }
}
