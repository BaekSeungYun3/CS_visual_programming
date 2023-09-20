using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _019_Timer_컨트롤을_이용한_디지털_시계
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lblTime.Font = new Font("맑은 고딕",30,FontStyle.Bold);
            lblTime.Text = "";
            timer1.Interval = 1000;   //1초에 한번씩
            timer1.Tick += Timer1_Tick;        //+= Tab: 이벤트 창(이벤트 함수)을 만들 수 있음
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)  //1초에 한번씩 틱 이벤트 발생
        {
            lblTime.Text = DateTime.Now.ToString();      //DateTime: 구조체 + NOW:데이트 타입  == (현재시간)
            
            lblTime.Location = new Point(                    //위치 조정
    ClientSize.Width / 2 - lblTime.Width / 2,
    ClientSize.Height / 2 - lblTime.Height / 2);            //lable의 왼쪽 끝이 위치의 기준
        }
    }
}
//interval = mm단위 = 0.1초에 한번씩