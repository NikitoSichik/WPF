namespace GradeStudent
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxGrades = new System.Windows.Forms.ListBox();
            this.textBoxNewSubject = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelAVG = new System.Windows.Forms.Label();
            this.textBoxOcenka = new System.Windows.Forms.TextBox();
            this.buttonAddOcenka = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxGrades
            // 
            this.listBoxGrades.FormattingEnabled = true;
            this.listBoxGrades.Location = new System.Drawing.Point(12, 12);
            this.listBoxGrades.Name = "listBoxGrades";
            this.listBoxGrades.Size = new System.Drawing.Size(120, 95);
            this.listBoxGrades.TabIndex = 0;
            this.listBoxGrades.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBoxNewSubject
            // 
            this.textBoxNewSubject.Location = new System.Drawing.Point(12, 113);
            this.textBoxNewSubject.Name = "textBoxNewSubject";
            this.textBoxNewSubject.Size = new System.Drawing.Size(120, 20);
            this.textBoxNewSubject.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 139);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(147, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // labelAVG
            // 
            this.labelAVG.AutoSize = true;
            this.labelAVG.Location = new System.Drawing.Point(147, 119);
            this.labelAVG.Name = "labelAVG";
            this.labelAVG.Size = new System.Drawing.Size(35, 13);
            this.labelAVG.TabIndex = 3;
            this.labelAVG.Text = "label1";
            // 
            // textBoxOcenka
            // 
            this.textBoxOcenka.Location = new System.Drawing.Point(147, 135);
            this.textBoxOcenka.Name = "textBoxOcenka";
            this.textBoxOcenka.Size = new System.Drawing.Size(100, 20);
            this.textBoxOcenka.TabIndex = 4;
            // 
            // buttonAddOcenka
            // 
            this.buttonAddOcenka.Location = new System.Drawing.Point(147, 161);
            this.buttonAddOcenka.Name = "buttonAddOcenka";
            this.buttonAddOcenka.Size = new System.Drawing.Size(75, 23);
            this.buttonAddOcenka.TabIndex = 5;
            this.buttonAddOcenka.Text = "add";
            this.buttonAddOcenka.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 299);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddOcenka);
            this.Controls.Add(this.textBoxOcenka);
            this.Controls.Add(this.labelAVG);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxNewSubject);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listBoxGrades);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxGrades;
        private System.Windows.Forms.TextBox textBoxNewSubject;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelAVG;
        private System.Windows.Forms.TextBox textBoxOcenka;
        private System.Windows.Forms.Button buttonAddOcenka;
        private System.Windows.Forms.Label label1;
    }
}

