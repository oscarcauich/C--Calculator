using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCalculator
{
    public partial class Form1 : Form
    {
        private string input = string.Empty;
        private string operand1 = string.Empty;
        private string operand2 = string.Empty;
        private char operation;
        private double result = 0.0;
    
        public Form1()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void AC_Btn_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = String.Empty;
            this.operand2 = String.Empty;
        }

        private void Plus_Minus_Btn_Click(object sender, EventArgs e)
        {

        }

        private void Percentage_Btn_Click(object sender, EventArgs e)
        {

        }

        private void Division_Btn_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;

        }

        private void Seven_Btn_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void Eight_Btn_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void Multip_Btn_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void Four_Btn_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void Five_Btn_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void Six_Btn_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void Substrac_Btn_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void One_Btn_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
        }

        private void Two_Btn_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void Zero_Btn_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }

        private void Dot_Btn_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += ".";
            this.textBox1.Text += input;
        }

        private void Equal_Btn_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double number1, number2;
            double.TryParse(operand1, out number1);
            double.TryParse(operand2, out number2);

            // clears input and operands string for next operation.
            this.textBox1.Text = "";
            this.input = String.Empty;
            this.operand1 = String.Empty;
            this.operand2 = String.Empty;

            switch (operation)
            {
                case '+':
                    result = number1 + number2;
                    textBox1.Text = result.ToString("G");
                    break;
                case '-':
                    result = number1 - number2;
                    textBox1.Text = result.ToString("G");
                    break;
                case '/':
                    if (number2 != 0)
                    {
                        result = number1 / number2;
                        textBox1.Text = result.ToString("G");
                    }
                    else
                    {
                        textBox1.Text = "Not a number";
                    }
                    break;
                default:
                    result = number1 * number2;
                    textBox1.Text = result.ToString("G");
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
