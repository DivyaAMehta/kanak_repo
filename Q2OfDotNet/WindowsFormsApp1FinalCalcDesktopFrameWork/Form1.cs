using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1FinalCalc
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        String operationPerformed = "";
        bool isOpPerform=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || (isOpPerform))
                textBox1.Clear();
            Button button = (Button)sender;
            isOpPerform = false;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void button_math_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            isOpPerform = true;
            operationPerformed = button.Text;
            resultValue=Double.Parse(textBox1.Text);
        }

        private void button_clear(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultValue = 0;
        }

        private void button_Click_equalsTo(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox1.Text = (resultValue + Double.Parse(textBox1.Text)).ToString();
                    break;

                case "-":
                    textBox1.Text = (resultValue - Double.Parse(textBox1.Text)).ToString();
                    break;

                case "*":
                    textBox1.Text = (resultValue * Double.Parse(textBox1.Text)).ToString();
                    break;

                case "/":
                    textBox1.Text = (resultValue / Double.Parse(textBox1.Text)).ToString();
                    break;

                default:
                    break;
            }
        }

        private void Lable_op(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
