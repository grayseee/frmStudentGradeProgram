using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentGradeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label8_Click(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double engli = Convert.ToDouble(EnglishB.Text);
            double math = Convert.ToDouble(MathB.Text);
            double science = Convert.ToDouble(Science.Text);
            double fil = Convert.ToDouble(Filipino.Text);
            double hist = Convert.ToDouble(History.Text);

            double average = engli + math + science + fil + hist;
            double totalaverage = average / 5;
            GeneralAverage.Text = totalaverage >= 75 ? Name = "The Student Passed your Average is:" + totalaverage:
                                                       Name = "The Student Failed your Average is:" + totalaverage;

        }
    }
}
