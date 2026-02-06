namespace Cacul_noInternet
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rost = new System.Windows.Forms.Label();
            this.textBoxRost = new System.Windows.Forms.TextBox();
            this.ves = new System.Windows.Forms.Label();
            this.textBoxVes = new System.Windows.Forms.TextBox();
            this.buttonCalculator = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rost
            // 
            this.rost.AutoSize = true;
            this.rost.Location = new System.Drawing.Point(171, 48);
            this.rost.Name = "rost";
            this.rost.Size = new System.Drawing.Size(54, 13);
            this.rost.TabIndex = 0;
            this.rost.Text = "Рост (см)";
            // 
            // textBoxRost
            // 
            this.textBoxRost.Location = new System.Drawing.Point(174, 64);
            this.textBoxRost.Name = "textBoxRost";
            this.textBoxRost.Size = new System.Drawing.Size(100, 20);
            this.textBoxRost.TabIndex = 1;
            this.textBoxRost.TextChanged += new System.EventHandler(this.textBoxRost_TextChanged);
            // 
            // ves
            // 
            this.ves.AutoSize = true;
            this.ves.Location = new System.Drawing.Point(171, 87);
            this.ves.Name = "ves";
            this.ves.Size = new System.Drawing.Size(46, 13);
            this.ves.TabIndex = 2;
            this.ves.Text = "Вес (кг)";
            // 
            // textBoxVes
            // 
            this.textBoxVes.Location = new System.Drawing.Point(174, 103);
            this.textBoxVes.Name = "textBoxVes";
            this.textBoxVes.Size = new System.Drawing.Size(100, 20);
            this.textBoxVes.TabIndex = 3;
            this.textBoxVes.TextChanged += new System.EventHandler(this.textBoxVes_TextChanged);
            // 
            // buttonCalculator
            // 
            this.buttonCalculator.Location = new System.Drawing.Point(174, 140);
            this.buttonCalculator.Name = "buttonCalculator";
            this.buttonCalculator.Size = new System.Drawing.Size(109, 23);
            this.buttonCalculator.TabIndex = 4;
            this.buttonCalculator.Text = "Рассчитать ИМТ";
            this.buttonCalculator.UseVisualStyleBackColor = true;
            this.buttonCalculator.Click += new System.EventHandler(this.buttonCalculator_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(171, 183);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(59, 13);
            this.result.TabIndex = 5;
            this.result.Text = "Результат";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(302, 140);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.result);
            this.Controls.Add(this.buttonCalculator);
            this.Controls.Add(this.textBoxVes);
            this.Controls.Add(this.ves);
            this.Controls.Add(this.textBoxRost);
            this.Controls.Add(this.rost);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rost;
        private System.Windows.Forms.TextBox textBoxRost;
        private System.Windows.Forms.Label ves;
        private System.Windows.Forms.TextBox textBoxVes;
        private System.Windows.Forms.Button buttonCalculator;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button Clear;
    }
}

