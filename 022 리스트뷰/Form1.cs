using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _022_리스트뷰
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myListView.GridLines = true;
            myListView.FullRowSelect = true;

            myListView.Columns.Add("제품명", 150);
            myListView.Columns.Add("단가",100,HorizontalAlignment.Right);
            myListView.Columns.Add("수량", 70, HorizontalAlignment.Right);
            myListView.Columns.Add("금액", 100, HorizontalAlignment.Right);

            ListViewItem item1 = new ListViewItem("Access", 0);
            ListViewItem item1 = new ListViewItem("Access", 0);
            ListViewItem item1 = new ListViewItem("Access", 0);
            ListViewItem item1 = new ListViewItem("Access", 0);

        }
    }
}
