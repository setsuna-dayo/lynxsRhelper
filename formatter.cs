using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lynxsRhelper
{
    public partial class formatter : Form
    {
        public formatter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox2.Checked == true)
                textBox1.Text = Clipboard.GetText();

            if(checkBox3.Checked == true)
                textBox1.Text = textBox1.Text.Replace(",", "，").Replace(".", "。");
            if (checkBox4.Checked == true)
                textBox1.Text = textBox1.Text.Replace("，", ".").Replace("。", ".");

            if (checkBoxr.Checked == true)
                textBox1.Text = textBox1.Text.Replace("\n", "").Replace("\r", "");
            if(checkBoxspace.Checked == true)
                textBox1.Text = textBox1.Text.Replace(" ", "");
            if(checkBoxt.Checked == true)
                textBox1.Text = textBox1.Text.Replace("\t", "");

            if(checkBox1.Checked == true)
                Clipboard.SetText(textBox1.Text);
        }

        private void formatter_Load(object sender, EventArgs e)
        {

        }
    }
}
