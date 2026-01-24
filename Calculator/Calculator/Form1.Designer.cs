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
            this.num8 = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Button();
            this.rovno = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.degree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num8
            // 
            this.num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num8.Location = new System.Drawing.Point(59, 49);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(37, 35);
            this.num8.TabIndex = 0;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.numbers);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(16, 12);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(209, 20);
            this.textBox.TabIndex = 1;
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plus.Location = new System.Drawing.Point(145, 49);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(37, 35);
            this.plus.TabIndex = 2;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.znaki);
            // 
            // rovno
            // 
            this.rovno.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rovno.Location = new System.Drawing.Point(102, 172);
            this.rovno.Name = "rovno";
            this.rovno.Size = new System.Drawing.Size(37, 35);
            this.rovno.TabIndex = 3;
            this.rovno.Text = "=";
            this.rovno.UseVisualStyleBackColor = true;
            this.rovno.Click += new System.EventHandler(this.rovno_Click);
            // 
            // num7
            // 
            this.num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num7.Location = new System.Drawing.Point(16, 49);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(37, 35);
            this.num7.TabIndex = 4;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.numbers);
            // 
            // num9
            // 
            this.num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num9.Location = new System.Drawing.Point(102, 49);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(37, 35);
            this.num9.TabIndex = 5;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.numbers);
            // 
            // num6
            // 
            this.num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num6.Location = new System.Drawing.Point(102, 90);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(37, 35);
            this.num6.TabIndex = 8;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.numbers);
            // 
            // num4
            // 
            this.num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num4.Location = new System.Drawing.Point(16, 90);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(37, 35);
            this.num4.TabIndex = 7;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.numbers);
            // 
            // num5
            // 
            this.num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num5.Location = new System.Drawing.Point(59, 90);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(37, 35);
            this.num5.TabIndex = 6;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.numbers);
            // 
            // num3
            // 
            this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num3.Location = new System.Drawing.Point(102, 131);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(37, 35);
            this.num3.TabIndex = 11;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.numbers);
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num1.Location = new System.Drawing.Point(16, 131);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(37, 35);
            this.num1.TabIndex = 10;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.numbers);
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num2.Location = new System.Drawing.Point(59, 131);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(37, 35);
            this.num2.TabIndex = 9;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.numbers);
            // 
            // num0
            // 
            this.num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num0.Location = new System.Drawing.Point(59, 172);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(37, 35);
            this.num0.TabIndex = 12;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.numbers);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minus.Location = new System.Drawing.Point(145, 90);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(37, 35);
            this.minus.TabIndex = 13;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.znaki);
            // 
            // multiply
            // 
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiply.Location = new System.Drawing.Point(145, 131);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(37, 35);
            this.multiply.TabIndex = 14;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.znaki);
            // 
            // division
            // 
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.division.Location = new System.Drawing.Point(145, 172);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(37, 35);
            this.division.TabIndex = 15;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.znaki);
            // 
            // C
            // 
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C.Location = new System.Drawing.Point(16, 172);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(37, 35);
            this.C.TabIndex = 16;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // degree
            // 
            this.degree.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.degree.Location = new System.Drawing.Point(188, 49);
            this.degree.Name = "degree";
            this.degree.Size = new System.Drawing.Size(37, 35);
            this.degree.TabIndex = 17;
            this.degree.Text = "^";
            this.degree.UseVisualStyleBackColor = true;
            this.degree.Click += new System.EventHandler(this.znaki);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(236, 222);
            this.Controls.Add(this.degree);
            this.Controls.Add(this.C);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.rovno);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.num8);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button rovno;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button degree;
    }
}

