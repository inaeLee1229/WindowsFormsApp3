using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Text = "버튼\n,체크 상자\n, 라디오 버튼";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Text = "리스트 상자\n,콤보 상자\n,체크 리스트 상자";
        }
    }
}
