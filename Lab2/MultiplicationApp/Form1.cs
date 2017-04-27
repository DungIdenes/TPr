using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplicationApp
{
    public partial class Form1 : Form
    {
        public double a, b, c;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox3.Text);
            textBox2.Text = (a*b).ToString();
        }
    }
}
