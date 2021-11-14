using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lynxsRhelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 释放resx里面的普通类型文件
        /// </summary>
        /// <param name="resource">resx里面的资源</param>
        /// <param name="path">释放到的路径</param>
        private void ExtractNormalFileInResx(byte[] resource, String path)
        {
            FileStream file = new FileStream(path, FileMode.Create);
            file.Write(resource, 0, resource.Length);
            file.Flush();
            file.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=" + textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://cn.bing.com/search?q=" + textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.math.pku.edu.cn/teachers/lidf/docs/Rbook/html/_Rbook/index.html");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ExtractNormalFileInResx(Properties.Resources.Rbook, "D:\\Rbook.pdf");
            MessageBox.Show("已导出至D盘根目录下！");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://bookdown.org/xiao/RAnalysisBook/");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://style.tidyverse.org/index.html");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/results?search_query=" + textBox1.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/c/joshstarmer/search?query=" + textBox1.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://cran.r-project.org/web/packages/available_packages_by_name.html");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.rdocumentation.org/search?q=" + textBox1.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://hbiostat.org/data/");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://danzhuibing.github.io/r_home.html");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://r4ds.had.co.nz/index.html");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://book.ucdrs.superlib.net/search?Field=all&channel=search&sw=" + textBox1.Text);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://sci-hub.se/");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://s.wanfangdata.com.cn/paper?q=" + textBox1.Text);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/" + textBox1.Text);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/search?q=" + textBox1.Text);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.termonline.cn/search?k=" + textBox1.Text);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://search.dxy.cn/?words=" + textBox1.Text);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://ss.chaoxing.com/search?sw=" + textBox1.Text);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://pubmed.ncbi.nlm.nih.gov/advanced/");
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.SelectAll();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://cran.r-project.org/web/packages/" + textBox1.Text);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://training.seer.cancer.gov/index.html" );
        }

        private void button27_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://qw.duxiu.com/getPage?sw=q" + textBox1.Text);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://training.seer.cancer.gov/search?q=" + textBox1.Text);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Form newformatter = new formatter();
            newformatter.Show();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://cse.google.com/cse?cx=005359090438081006639%3Apaz69t-s8ua&ie=UTF-8&q=" + textBox1.Text);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/TheAlgorithms/R");
        }
    }
}
