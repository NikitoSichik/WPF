using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testiki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listBox1.Items.Add("1 - что");
            listBox1.Items.Add("2 - нет");
            listBox1.Items.Add("3 - да");

            comboBox1.Items.Add("что нет");
            comboBox1.Items.Add("Рахат           лукум");
            comboBox1.Items.Add("тут выше пробелы ьтипа б . . .  . . .  . . . . . .  . . . . . . . . . . .");

            comboBox1.SelectedIndex = 0;

            checkedListBox1.Items.Add("Ну и кри   н   ж");
            checkedListBox1.Items.Add("нормик тут так-то");
            checkedListBox1.Items.Add("я тут ваще по приколу");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string newCity = textBox1.Text;

            if (newCity != "")
            {
                listBox1.Items.Add(newCity);

                textBox1.Clear();

                label1.Text = "Добавлен";
            }
            else label1.Text = "Введите город";
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
                label1.Text = listBox1.SelectedItem.ToString();
            else label1.Text = "Ничего";

            if (comboBox1.SelectedIndex != -1)
                label1.Text = comboBox1.SelectedItem.ToString();
            else label1.Text = "Ничего";
        }

        private void button_marks_Click(object sender, EventArgs e)
        {
            string result = "Отмечено: \n";
            for (int i = 0; i < listBox1.Items.Count; i++) {
                if (checkedListBox1.GetItemChecked(i) == true) {
                    result += checkedListBox1.Items[i].ToString() + '\n';
                }
            }
            label1.Text = result;
        }

        private void listBox1_SelectIndexChanged(object sender, EventArgs e) { 
            if(listBox1.SelectedIndex !=1)
                label1.Text = "кликнул на " + listBox1.SelectedItem.ToString();
        }
    }
}
