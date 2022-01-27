using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            double sum; // double datatype to get value in point(like 2.29)
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            sum = b + a ;
            textBox3.Text =sum.ToString(); 
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int a, b;
            double sub;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            sub = b - a;
            textBox3.Text = sub.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int a, b;
            double  mul;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            mul = b * a;
            textBox3.Text = mul.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a, b;
            double div ;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            div = b / a;
            textBox3.Text = div.ToString();
        }
    }
}
