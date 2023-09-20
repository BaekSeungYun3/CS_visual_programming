using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _004_Hello_world
{
    public partial class Form1 : Form       // 파셜클래스 form을 상속받은 클래스  / Form을 스크롤 하고 F1을 누르면 상세설명 볼 수 있음
    {
        public Form1()          //생성자 메소드(객체가 만들어질때 자동 생성)
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)         //sender EventArgs - 이게 있으면 이벤트 핸들러
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello windows Forms Application!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   //C#은 포인터가 없어 .을 사용해서 선택 가능
        }

        private void label1_Click(object sender, EventArgs e)         
        {

        }
    }
}
//스페너: 속성 = 변수(기능 추가)
// 정육면체(보라색) : 메소드
// 번개: 이벤트(버튼 클릭 등)