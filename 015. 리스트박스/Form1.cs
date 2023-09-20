using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _015.리스트박스
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();    // 생성자 함수 - 없으면 실행 불가
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 리스트박스에 아이템 추가(두번째 방법) - .Items.Add
            listBox2.Items.Add("오클랜드(뉴질랜드)");
            listBox2.Items.Add("오사카(일본)");
            listBox2.Items.Add("아델레이드(호주)");
            listBox2.Items.Add("웰링턴(뉴질랜드)");
            listBox2.Items.Add("도쿄(일본)");
            listBox2.Items.Add("퍼스(호주)");
            listBox2.Items.Add("취리히(스위스)");
            listBox2.Items.Add("제네바(스위스)");
            listBox2.Items.Add("멜버른(호주)");
            listBox2.Items.Add("브리즈번(호주)");

            // 리스트박스에 아이템 추가(세번째 방법) - ListBox.DataSource 사용
            List<string> happiness = new List<string>()   //괄호X도 가능
            {
                "핀란드","덴마크","아이슬란드","스위스","네덜란드","룩셈브르크","스웨덴","노르웨이","이스라엘","뉴질랜드"
            };
            listBox3.DataSource = happiness;
        }

        //리스트 박스를 선택했을 때 이벤트 함수 - sender: 이벤트가 어디서 왔는지를 보내주는 변수(=리스트박스1)  + object: 상속해준 조상 중에 제일 처음 조상 - Tostring() 가장 많이씀
        // EventArgs e - 위치 같은 것을 알려줌
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)   
        {
            //ListBox l = (ListBox)sender;  //센더를 리스트 박스로 캐스팅
            ListBox l = sender as ListBox;  //위와 동일한 이야기 (가급적 이런식으로 작성) - as는 키워드

            txtSIndex1.Text = l.SelectedIndex.ToString();
            txtSItem1.Text = l.SelectedItem.ToString();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;  

            txtSIndex2.Text = l.SelectedIndex.ToString();
            txtSItem2.Text = l.SelectedItem.ToString();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;  

            txtSIndex3.Text = l.SelectedIndex.ToString();
            txtSItem3.Text = l.SelectedItem.ToString();
        }
    }
}
//아이템을 넣는 방법 3가지 - (리스트 박스 마우스 오른쪽 클릭)항목편집 or 속성창 아이템 
