namespace WindowsFormsApp1
{
    partial class StudentGPACalculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StudentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.finalGPA = new System.Windows.Forms.Label();
            this.EnglishGrade = new System.Windows.Forms.TextBox();
            this.BiologyGrade = new System.Windows.Forms.TextBox();
            this.AlgebraGrade = new System.Windows.Forms.TextBox();
            this.ComputerScienceGrade = new System.Windows.Forms.TextBox();
            this.PsychologyGrade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate GPA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // StudentName
            // 
            this.StudentName.Location = new System.Drawing.Point(118, 45);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(239, 22);
            this.StudentName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "English 101";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Computer Science I";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Psychology I";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Biology 101";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Algebra 101";
            // 
            // finalGPA
            // 
            this.finalGPA.AutoSize = true;
            this.finalGPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalGPA.Location = new System.Drawing.Point(270, 365);
            this.finalGPA.Name = "finalGPA";
            this.finalGPA.Size = new System.Drawing.Size(57, 25);
            this.finalGPA.TabIndex = 15;
            this.finalGPA.Text = "GPA";
            this.finalGPA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnglishGrade
            // 
            this.EnglishGrade.Location = new System.Drawing.Point(203, 106);
            this.EnglishGrade.Name = "EnglishGrade";
            this.EnglishGrade.Size = new System.Drawing.Size(124, 22);
            this.EnglishGrade.TabIndex = 16;
            this.EnglishGrade.Tag = "Enter your Grade";
            this.EnglishGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BiologyGrade
            // 
            this.BiologyGrade.Location = new System.Drawing.Point(203, 197);
            this.BiologyGrade.Name = "BiologyGrade";
            this.BiologyGrade.Size = new System.Drawing.Size(124, 22);
            this.BiologyGrade.TabIndex = 17;
            this.BiologyGrade.Tag = "Enter your Grade";
            this.BiologyGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AlgebraGrade
            // 
            this.AlgebraGrade.Location = new System.Drawing.Point(203, 151);
            this.AlgebraGrade.Name = "AlgebraGrade";
            this.AlgebraGrade.Size = new System.Drawing.Size(124, 22);
            this.AlgebraGrade.TabIndex = 18;
            this.AlgebraGrade.Tag = "Enter your Grade";
            this.AlgebraGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ComputerScienceGrade
            // 
            this.ComputerScienceGrade.Location = new System.Drawing.Point(203, 240);
            this.ComputerScienceGrade.Name = "ComputerScienceGrade";
            this.ComputerScienceGrade.Size = new System.Drawing.Size(124, 22);
            this.ComputerScienceGrade.TabIndex = 19;
            this.ComputerScienceGrade.Tag = "Enter your Grade";
            this.ComputerScienceGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PsychologyGrade
            // 
            this.PsychologyGrade.Location = new System.Drawing.Point(203, 279);
            this.PsychologyGrade.Name = "PsychologyGrade";
            this.PsychologyGrade.Size = new System.Drawing.Size(124, 22);
            this.PsychologyGrade.TabIndex = 20;
            this.PsychologyGrade.Tag = "Enter your Grade";
            this.PsychologyGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Grade Reference";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(413, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "A = 4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(413, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "B = 3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(412, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "D = 1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(413, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "C = 2";
            // 
            // StudentGPACalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PsychologyGrade);
            this.Controls.Add(this.ComputerScienceGrade);
            this.Controls.Add(this.AlgebraGrade);
            this.Controls.Add(this.BiologyGrade);
            this.Controls.Add(this.EnglishGrade);
            this.Controls.Add(this.finalGPA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "StudentGPACalculator";
            this.Text = "StudentGPACalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StudentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label finalGPA;
        private System.Windows.Forms.TextBox EnglishGrade;
        private System.Windows.Forms.TextBox BiologyGrade;
        private System.Windows.Forms.TextBox AlgebraGrade;
        private System.Windows.Forms.TextBox ComputerScienceGrade;
        private System.Windows.Forms.TextBox PsychologyGrade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

