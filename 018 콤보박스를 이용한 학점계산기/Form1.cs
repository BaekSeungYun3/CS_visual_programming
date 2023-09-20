using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _018_콤보박스를_이용한_학점계산기
{
    public partial class Form1 : Form
    {
        TextBox[] titles;
        ComboBox[] crds;  //학점
        ComboBox[] grds;  //성적
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt1.Text = "인체구조와 기능1";
            txt2.Text = "일반수학";
            txt3.Text = "영어1";
            txt4.Text = "설계 및 프로젝트1";
            txt5.Text = "비주얼프로그래밍";
            txt6.Text = "기업가정신";
            txt7.Text = "영화와 과학";

            titles = new TextBox[] { txt1, txt2, txt3, txt4, txt5, txt6, txt7 };
            crds = new ComboBox[] {crd1,crd2, crd3, crd4, crd5, crd6, crd7};
            grds = new ComboBox[] { grd1, grd2, grd3, grd4, grd5, grd6, grd7 };

            int[] arrCredit = { 1, 2, 3, 4, 5 };
            List<string> lstGrade = new List<string>
            { "A+","A0","B+","B0","C+","C0","D+","D0","F"};

            foreach (var c in crds)
            { 
                foreach (var i in arrCredit)
                    c.Items.Add(i);
                c.SelectedItem = 3;
            }
            foreach(var g in grds)
                foreach (var c in lstGrade)
                    g.Items.Add(c);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double totalScore = 0;
            int totalCreadits = 0;

            for(int i = 0; i < grds.Length; i++)
            {
                if(grds[i].SelectedItem != null)  //성적이 선택(입력)이 된 과목들만 계산 = 빈칸이 아니다
                {
                    int crd = int.Parse(crds[i].SelectedItem.ToString());
                    totalCreadits += crd;
                    totalScore += crd * GetGrard(grds[i].SelectedItem.ToString());
                }
            }
            txtGrade.Text = (totalScore / totalCreadits).ToString("0.0");
        }

        // A+에서 F까지 학점에 해당하는 숫자를 가져오는 메소드
        private double GetGrard(string v) 
        { 
       
            double grade;
            if (v == "A+") grade = 4.5;
            else if (v == "A0") grade = 4.0;
            else if (v == "B+") grade = 3.5;
            else if (v == "B0") grade = 3.0;
            else if (v == "C+") grade = 2.5;
            else if (v == "C0") grade = 2.0;
            else if (v == "D+") grade = 1.5;
            else if (v == "D0") grade = 1.0;
            else grade = 0;
            return grade;
            
        }
    }
}
