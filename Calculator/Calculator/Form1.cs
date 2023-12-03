using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        decimal x, y, z, w;
        bool a, b, c, d;
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

        private void button11_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            a = true;
            b = false;
            c = false;
            d = false;
            w = Convert.ToDecimal(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = ".";
            }
            else
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            a = false;
            b = true;
            c = false;
            d = false;
            x = Convert.ToDecimal(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (a == true)
            {
                decimal Y = Convert.ToDecimal(textBox1.Text);
                textBox1.Text = Convert.ToString((w + Y));
            }
            else if (b == true)
            {
                decimal Y = Convert.ToDecimal(textBox1.Text);
                textBox1.Text = Convert.ToString((x - Y));
            }
            else if (c == true)
            {
                decimal Y = Convert.ToDecimal(textBox1.Text);
                textBox1.Text = Convert.ToString((y * Y));
            }
            else if (d == true)
            {
                decimal Y = Convert.ToDecimal(textBox1.Text);
                textBox1.Text = (Y != 0) ? textBox1.Text = Convert.ToString(z / Y) : textBox1.Text = "ERROR";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a = false;
            b = false;
            c = true;
            d = false;
            y = Convert.ToDecimal(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            a = false;
            b = false;
            c = false;
            d = true;
            z = Convert.ToDecimal(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }
    }
}
