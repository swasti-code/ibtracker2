using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ibtracker2
{
    public partial class calculations : Form
    {
        public calculations()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Group1, Group2, Group3, Group4, Group5, Group6, corePoints, totalPoints;
            string tokGrade, eeGrade;

            Group1 = int.Parse(txtGroup1.Text);
            Group2 = int.Parse(txtGroup2.Text);
            Group3 = int.Parse(txtGroup3.Text);
            Group4 = int.Parse(txtGroup4.Text);
            Group5 = int.Parse(txtGroup5.Text);
            Group6 = int.Parse(txtGroup6.Text);

            tokGrade = txtTOK.Text.ToString();
            eeGrade = txtEE.Text.ToString();

            corePoints = CalculateCorePoints(tokGrade, eeGrade);
            totalPoints = Group1 + Group2 + Group3 + Group4 + Group5 + Group6 + corePoints;
            txtTotalPoints.Text = $"Total Points: {totalPoints}";

            if(numericUpDown1.Value+ numericUpDown2.Value == 0)
            {
                MessageBox.Show("Please enter the number of HL & SL subjects");
            }

            if(Group1 >7 || Group2 > 7 || Group3 > 7 || Group4 > 7 || Group5 > 7 || Group6 > 7 )
            {
                MessageBox.Show("Please enter a values for Group Subjects less than or equal to 7");
            }



            if (corePoints >= 0)
            {
                string letterGrade = GetLetterGrade(corePoints);
                txtCorePoints.Text = $"Total Core Points: {corePoints}, Letter Grade: {letterGrade}";
                txtCorePoints.Show();


                if (totalPoints > 24)
                {
                    txtDipolma.Text = "Passed";
                    txtDipolma.Show();
                }
                else
                {
                    txtDipolma.Text = "Failed";
                    txtDipolma.Show();
                }
            }
        }

        public static string GetLetterGrade(int corePoints)
        {
            if (corePoints >= 3) return "A";
            if (corePoints == 2) return "B";
            if (corePoints == 1) return "C";
            return "D";
        }

        public static int CalculateCorePoints(string tokGrade, string eeGrade)
        {
            int[,] pointMatrix = new int[5, 5] {
                    { 3, 2, 2, 2, 2 },
                    { 2, 2, 2, 1, 1 },
                    { 2, 2, 1, 0, 0 },
                    { 2, 1, 1, 0, 0 },
                    { 0, 0, 0, 0, 0 }
                    };

            int tokIndex = GetGradeIndex(tokGrade);
            int eeIndex = GetGradeIndex(eeGrade);

           
            if (tokIndex == -1 || eeIndex == -1)
            {
                Console.WriteLine("Invalid grade input. Please use A, B, C, D, or E.");
                return -1;  
            }
            if (tokGrade == "E" || eeGrade == "E")
            {
                Console.WriteLine("Failing condition: One of the grades is 'E'. No core points.");
                return 0; 
            }

            
            return pointMatrix[tokIndex, eeIndex];
        }

        public static int GetGradeIndex(string grade)
        {
            switch (grade.ToUpper())
            {
                case "A": return 0;
                case "B": return 1;
                case "C": return 2;
                case "D": return 3;
                case "E": return 4;
                default: return -1;  
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalPoints_TextChanged(object sender, EventArgs e)
        {
         

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtTotalPoints.Text = "";
            txtCorePoints.Text = "";
            txtDipolma.Text = "";
            txtGroup1.Text = "";
            txtGroup2.Text = "";
            txtGroup3.Text = "";
            txtGroup4.Text = "";
            txtGroup5.Text = "";
            txtGroup6.Text = "";
            txtTOK.Text = "";
            txtEE.Text = "";
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}