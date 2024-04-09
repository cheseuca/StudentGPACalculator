using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StudentGPACalculator : Form
    {
        private int course1Credit = 3;
        private int course2Credit = 3;
        private int course3Credit = 4;
        private int course4Credit = 4;
        private int course5Credit = 3;

        private int englishGrade;
        private int algebraGrade;
        private int biologyGrade;
        private int computerScienceGrade;
        private int psychologyGrade;

        private int totalGradePoints = 0;
        private int totalCreditHours = 0;
        public StudentGPACalculator()
        {
            InitializeComponent();

            EnglishGrade.KeyPress += GradeTextBox_KeyPress;
            AlgebraGrade.KeyPress += GradeTextBox_KeyPress;
            BiologyGrade.KeyPress += GradeTextBox_KeyPress;
            ComputerScienceGrade.KeyPress += GradeTextBox_KeyPress;
            PsychologyGrade.KeyPress += GradeTextBox_KeyPress;
        }

        private void calculateTotalGrade()
        {
            int englishGrade = GetGradePoint(EnglishGrade.Text);
            int algebraGrade = GetGradePoint(AlgebraGrade.Text);
            int biologyGrade = GetGradePoint(BiologyGrade.Text);
            int computerScienceGrade = GetGradePoint(ComputerScienceGrade.Text);
            int psychologyGrade = GetGradePoint(PsychologyGrade.Text);

            
            totalGradePoints += course1Credit * englishGrade;
            totalGradePoints += course2Credit * algebraGrade;
            totalGradePoints += course3Credit * biologyGrade;
            totalGradePoints += course4Credit * computerScienceGrade;
            totalGradePoints += course5Credit * psychologyGrade;

            totalCreditHours += course1Credit;
            totalCreditHours += course2Credit;
            totalCreditHours += course3Credit;
            totalCreditHours += course4Credit;
            totalCreditHours += course5Credit;

        }
        private int GetGradePoint(string grade)
        {
            switch (grade.ToUpper())
            {
                case "A":
                    return 4;
                case "B":
                    return 3;
                case "C":
                    return 2;
                case "D":
                    return 1;
                default:
                    return 0; // Default to 0 for unknown grades
            }
        }

        private void GradeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Allow only A, B, C, and D
            if (!(e.KeyChar == 'A' || e.KeyChar == 'B' || e.KeyChar == 'C' || e.KeyChar == 'D' ||
                  e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete))
            {
                e.Handled = true; // Ignore the key press
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            calculateTotalGrade();
            
            decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;
            int leadingDigit = (int)gradePointAverage;
            int firstDigit = (int)(gradePointAverage * 10) % 10;
            int secondDigit = (int)(gradePointAverage * 100) % 10;

            string gpaText = string.Format("{0}.{1}{2}", leadingDigit, firstDigit, secondDigit);

            finalGPA.Text = gpaText;
        }
    }
}
