using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public string D;
        public string num1;
        public bool num2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            double dn1, dn2, result;
            result = 0;
            dn1 = Convert.ToDouble(num1);
            dn2 = Convert.ToDouble(textBox1.Text);

            if (D == "+")
            {
                result = dn1 + dn2;
            }
            if (D == "-")
            {
                result = dn1 - dn2;
            }
            if (D == "*")
            {
                result = dn1 * dn2;
            }
            if (D == "/")
            {
                result = dn1 / dn2;
            }
            D = "=";
            num2 = true;
            textBox1.Text = result.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if(!textBox1.Text.Contains(","))
                textBox1.Text = textBox1.Text + ",";
        }

        private void number0_Click(object sender, EventArgs e)
        {
            if(num2 == true)
            {
                num2 = false;
                textBox1.Text = "0";
            }
            Button B = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = B.Text;
            else
                textBox1.Text = textBox1.Text + B.Text;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            num1 = textBox1.Text;
            num2 = true;
        }

        private void procent_Click(object sender, EventArgs e)
        {
            double dn, result;

            dn = Convert.ToDouble(textBox1.Text);
            result = Math.Sqrt(dn);
            textBox1.Text = result.ToString();
        }

        private void skobka1_Click(object sender, EventArgs e)
        {
            double dn, result;

            dn = Convert.ToDouble(textBox1.Text);
            result = Math.Pow(dn,2);
            textBox1.Text = result.ToString();
        }

        private void skobka2_Click(object sender, EventArgs e)
        {
            double dn, result;

            dn = Convert.ToDouble(textBox1.Text);
            result = 1/dn;
            textBox1.Text = result.ToString();
        }
    }
}
