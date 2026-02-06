using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cacul_noInternet
{
    public partial class Form1 : Form
    {
        int age;
        bool man; 
        double num_ves;
        double num_rost;
        double num_result;
        string[] str_result = { "Недостаточный вес", "Нормальный вес", "Избыточный вес", "Ожирение" };
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculator_Click(object sender, EventArgs e)
        {

            if (textBoxRost.Text != "")
                num_rost = int.Parse(textBoxRost.Text) / 100;

            if (textBoxRost.Text != "")
                num_ves = int.Parse(textBoxVes.Text);

            num_result = num_ves / (num_rost * num_rost);

            if(ageNum.Value >= 18 && ageNum.Value <= 65 && man == false)
            {
            if (num_result < 18.5) result.Text = $"{num_result.ToString()}\n{str_result[0]}";
            if (num_result >= 18.5 && num_result <= 24.9) result.Text = $"{num_result.ToString()}\n{str_result[1]}";
            if (num_result >= 25 && num_result < 29.9) result.Text = $"{num_result.ToString()}\n{str_result[2]}";
            if (num_result > 30) result.Text = $"{num_result.ToString()}\n{str_result[3]}";
            }

            if (ageNum.Value >= 18 && ageNum.Value <= 65 && man == true)
            {
                if (num_result < 18.5) result.Text = $"{num_result.ToString()}\n{str_result[0]}";
                if (num_result >= 18.5 && num_result <= 23.9) result.Text = $"{num_result.ToString()}\n{str_result[1]}";
                if (num_result >= 25 && num_result < 28.9) result.Text = $"{num_result.ToString()}\n{str_result[2]}";
                if (num_result > 29) result.Text = $"{num_result.ToString()}\n{str_result[3]}";
            }

            if (ageNum.Value >= 66)
            {
                if (num_result < 20) result.Text = $"{num_result.ToString()}\n{str_result[0]}";
                if (num_result >= 20 && num_result <= 26.4) result.Text = $"{num_result.ToString()}\n{str_result[1]}";
                if (num_result >= 26.5 && num_result < 31.4) result.Text = $"{num_result.ToString()}\n{str_result[2]}";
                if (num_result > 31.5) result.Text = $"{num_result.ToString()}\n{str_result[3]}";
            }

            result.Text = num_result.ToString();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            num_result = 0;
            num_rost = 0;
            num_ves = 0;
            textBoxRost.Clear();
            textBoxVes.Clear();
            result.Text = "";

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            man = true;
        }

        private void radBtnWo_CheckedChanged(object sender, EventArgs e)
        {
            man = false;
        }
    }
}
