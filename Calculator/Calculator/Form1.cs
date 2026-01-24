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
        bool dot_first = false;
        bool dot_second = false;
        int dot_click_first = 0;
        int dot_click_second = 0;

        private void numbers(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (new_num == false)
            {
                cur_num += btn.Text;
                first_num = first_num * 10 + int.Parse(btn.Text);
                if (dot_first == true)
                    dot_click_first++;
            }
            else
            {
                cur_num += btn.Text;
                second_num = second_num * 10 + int.Parse(btn.Text);
                if (dot_second == true)
                    dot_click_second++;
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
            dot_first = false;
            dot_second = false;
            dot_click_first = 0;
            dot_click_second = 0;
        }
        private void rovno_Click(object sender, EventArgs e)
        {
            // Dot
            if (dot_first == true)
                first_num /= (10 * dot_click_first);
            if (dot_second == true)
                second_num /= (10 * dot_click_second);



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

        private void dot_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            cur_num += btn.Text;

            if (new_num == false)
                dot_first = true;
            else dot_second = true;
            textBox.Text = cur_num;
        }


    }
}
