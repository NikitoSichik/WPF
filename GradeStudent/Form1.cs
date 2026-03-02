using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GradeStudent
{
    public partial class Form1 : Form
    {
        List<string> subjects = new List<string>();
        List<List<int>> allGrades = new List<List<int>>();

        public Form1()
        {
            InitializeComponent();

            subjects.Add("Математика");
            subjects.Add("Русский");
            allGrades.Add(new List<int>()); // Оценки по математике
            allGrades.Add(new List<int>()); // Оценки по русскому

            UpdateSubjectsList();
        }

        private void UpdateSubjectsList()
        {
            listBox1.Items.Clear();
            foreach (string s in subjects)
            {
                listBox1.Items.Add(s);
            }
        }

        private void UpdateGradesList()
        {
            listBoxGrades.Items.Clear();
            if (listBox1.SelectedIndex != -1)
            {
                int index = listBox1.SelectedIndex;
                foreach (int grade in allGrades[index])
                {
                    listBoxGrades.Items.Add(grade);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGradesList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string newSubject = textBoxNewSubject.Text.Trim();
            if (newSubject == "")
            {
                label1.Text = "Введите название предмета";
                return;
            }

            foreach (var s in subjects)
            {
                if (s == newSubject)
                {
                    label1.Text = "Такой предмет уже есть";
                    return; 
                }
            }

            subjects.Add(newSubject);
            allGrades.Add(new List<int>());

            UpdateSubjectsList();

            textBoxNewSubject.Clear();
            label1.Text = "";
        }

        private void buttonAddOcenka_Click(object sender, EventArgs e)
        {
            double sum = 0, count = 0;
            if (listBox1.SelectedIndex == -1)
            {
                label1.Text = "Предмет не выбран!";
                return;
            }

            if (!int.TryParse(textBoxOcenka.Text, out int ocenka))
            {
                label1.Text = "Введите число!";
                return;
            }

            if (ocenka >= 2 && ocenka <= 5)
            {
                int subjectIndex = listBox1.SelectedIndex;
                allGrades[subjectIndex].Add(ocenka);

                UpdateGradesList();

                textBoxOcenka.Clear();
                label1.Text = "";
            }
            else
            {
                label1.Text = "Оценка должна быть от 2 до 5";
            }
        }
    }
}