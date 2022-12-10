using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Font=new Font(Label.DefaultFont, FontStyle.Bold);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Font=new Font(Label.DefaultFont, FontStyle.Underline);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label3.Font = new Font(Label.DefaultFont, FontStyle.Italic);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.TextAlign = (ContentAlignment)HorizontalAlignment.Left;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.TextAlign = (ContentAlignment)HorizontalAlignment.Center;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.TextAlign = (ContentAlignment)HorizontalAlignment.Right;
        }
    }
}
