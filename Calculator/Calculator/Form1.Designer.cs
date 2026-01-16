namespace Calculator
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
            this.num1 = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Button();
            this.rovno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(141, 146);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(75, 23);
            this.num1.TabIndex = 0;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(141, 90);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 20);
            this.textBox.TabIndex = 1;
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(41, 146);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 23);
            this.plus.TabIndex = 2;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // rovno
            // 
            this.rovno.Location = new System.Drawing.Point(41, 190);
            this.rovno.Name = "rovno";
            this.rovno.Size = new System.Drawing.Size(75, 23);
            this.rovno.TabIndex = 3;
            this.rovno.Text = "=";
            this.rovno.UseVisualStyleBackColor = true;
            this.rovno.Click += new System.EventHandler(this.rovno_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rovno);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.num1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button rovno;
    }
}

