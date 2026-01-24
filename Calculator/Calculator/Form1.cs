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
        string cur_num = "";
        string operation = "";
        double first_num = 0;
        double second_num = 0;
        bool new_num = false;

        private void numbers(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (new_num == false)
            {
                cur_num += btn.Text;
                first_num = first_num * 10 + int.Parse(btn.Text);
            }
            else
            {
                cur_num += btn.Text;
                second_num = second_num * 10 + int.Parse(btn.Text);
            }
            textBox.Text = cur_num;
        }

        private void znaki(object sender, EventArgs e)
        {
            if (new_num == false)
            {
                Button btn = (Button)sender;
                operation = btn.Text;
                cur_num += btn.Text;
                new_num = true;
                textBox.Text = cur_num;
            }
        }

        public Form1()
        {
            InitializeComponent();
            textBox.Text = "";
        }
        private void C_Click(object sender, EventArgs e)
        {
            cur_num = "";
            operation = "";
            first_num = 0;
            second_num = 0;
            new_num = false;
            textBox.Text = cur_num;
        }
        private void rovno_Click(object sender, EventArgs e)
        {
            if(operation == "+")
            {
                double result = first_num + second_num;
                cur_num = "" + result;
                textBox.Text = cur_num;
            }
            if (operation == "-")
            {
                double result = first_num - second_num;
                cur_num = "" + result;
                textBox.Text = cur_num;
            }
            if (operation == "*") {
                double result = first_num * second_num;
                cur_num = "" + result;
                textBox.Text = cur_num;
            }
            if (operation == "/")
            {
                double result = first_num / second_num;
                cur_num = "" + result;
                textBox.Text = cur_num;
            }
            if(operation == "^")
            {
                double result = Math.Pow(first_num, second_num);
                cur_num = "" + result;
                textBox.Text = cur_num;
            }
        }




    }
}
