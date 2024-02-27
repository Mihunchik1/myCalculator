using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double num1 = 0;
        private double num2 = 0;
        private string action = "";

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                textBox1.Text = "Сначала введите число";
                
            }

            
            

            else
            {
                num1 = Double.Parse(textBox1.Text);
                action = ((Button)sender).Text;
                textBox1.Clear();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            num2 = Double.Parse(textBox1.Text);

            switch (action) 
            {
                case "+":
                    textBox1.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    textBox1.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    textBox1.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    textBox1.Text = (num1 / num2).ToString();
                    break;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
