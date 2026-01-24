using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_square
{
    public partial class Form1 : Form
    {
        int width;
        int height;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "rectangle")
            {
                width = int.Parse(num1.Text);
                height = int.Parse(num2.Text);
                conclusion.Text = (height * width).ToString();

            }
            if(comboBox1.Text == "square")
            {
                width = int.Parse(num1.Text);
                conclusion.Text = (width * width).ToString();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "square")
            {
                button1.Text = "square";
                num1.Visible = true;
                num2.Visible = false;
            }
            if (comboBox1.Text == "rectangle")
            {
                button1.Text = "rectangle";
                num2.Visible = true;
                num1.Visible = true;
            }
        }
    }
}
