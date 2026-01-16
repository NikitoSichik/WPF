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
        public Form1()
        {
            InitializeComponent();
            textBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
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
                second_num = first_num * 10 + int.Parse(btn.Text);
            }
            textBox.Text = cur_num;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (new_num == false)
            {
                Button btn = (Button)sender;
                operation = btn.Text;
                cur_num += btn.Text;
                new_num = true;
            }

        }

        private void rovno_Click(object sender, EventArgs e)
        {
            
        }
    }
}
