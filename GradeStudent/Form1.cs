using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeStudent
{
    public partial class Form1 : Form
    {
        List<string> subject = new List<string>();
        List<List<int>> allGrades = new List<List<int>>();
        public Form1()
        {
            InitializeComponent();
            subject.Add("Математика");
            subject.Add("Русский");

            allGrades.Add(new List<int>()); //матем
            allGrades.Add(new List<int>()); //русс
            listBox1.Items.Clear();
            foreach(string s in subject)
            {
                listBox1.Items.Add(s);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string newSubject = textBoxNewSubject.Text.Trim();
            if(newSubject == "")
            {
                label1.Text = "Введите название предмета";
                return;
            }
            foreach (var s in subject)
            {
                if(s == newSubject)
                {
                    label1.Text = "Такой предмет уже есть";
                }
            }

            subject.Add(newSubject);

            allGrades.Add(new List<int>());

            listBox1.Items.Clear();
            foreach (var s in allGrades)
            {
                listBox1.Items.Add(s);
            }
            textBoxNewSubject.Clear();
            label1.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxGrades.SelectedIndex == -1) return;
            int index = listBoxGrades.SelectedIndex;
            listBox1.Items.Clear();
            foreach (int grade in allGrades[index])
            {
                listBox1.Items.Add(grade);
            }
        }
    }
}
