using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationApp
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            int correctBio = Form4.totalBioCorrectAnswers;
            int questionBio = Form4.totalBioQuestionAmount;

            int correctEng = Form3.totalEngCorrectAnswers;
            int questionEng = Form3.totalEngQuestionAmount;

            int correctMath = TestScreenMath.totalMathCorrectAnswers;
            int questionMath = TestScreenMath.totalMathQuestionAmount;

            progressBarM.Maximum = questionMath > 0 ? questionMath : 1;
            progressBarM.Value = correctMath;
            CorrectMLabel.Text = "Total Correct Answers: " + correctMath;
            questionMLabel.Text = "Total Questions: " + questionMath;

            progressBarE.Maximum = questionEng > 0 ? questionEng : 1;
            progressBarE.Value = correctEng;
            CorrectELabel.Text = "Total Correct Answers: " + correctEng;
            questionELabel.Text = "Total Questions: " + questionEng;

            progressBarB.Maximum = questionBio > 0 ? questionBio : 1;
            progressBarB.Value = correctBio;
            CorrectBLabel.Text = "Total Correct Answers: " + correctBio;
            questionBLabel.Text = "Total Questions: " + questionBio;

        }

        private void Form5_Load(object sender, EventArgs e)
        {
           
        }

        private void testsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestChoiceForm form = new TestChoiceForm();
            form.Show();
            this.Hide();

        }

      
    }
}
