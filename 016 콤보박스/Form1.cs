using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _016_콤보박스
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            lbrestaurant.Text = "모임 장소: " + comboBox.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text != "") 
            { 
                comboBox1.Items.Add(comboBox1.Text);
                lbrestaurant.Text = comboBox1.Text + "Added!";
     
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex >= 0)
            {
                lbrestaurant.Text = comboBox1.SelectedItem.ToString() + "Deleted";
                comboBox1.Items.Remove(comboBox1.SelectedItem);
                
            }
        }
    }
}
