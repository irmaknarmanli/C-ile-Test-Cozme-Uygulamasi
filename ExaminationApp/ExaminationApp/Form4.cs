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
    public partial class Form4 : Form
    {
        private string[] questionsB1 = {
        "Which one of the nucleotides\n isnt involved in DNA?",
        "Which one can do\n photosyntesis?",
        "Animals which eat both\n plants and other animals\n are known as what?",
    };
        private string[][] answersB1 = {
        new string[] { "A", "T", "U" },
        new string[] { "euglena", "fungus", "animals" },
        new string[] { "Carnivores", "Omnivores", "Herbivore" },
    };

        private string[] questionsB2 = {
        "A change of the DNA in an\n organism that results in a\n new trait is known as a?",
        "What is the\n smallest unit of life?",
        "How many hearts\n does an octopus have?",
    };
        private string[][] answersB2 = {
        new string[] { "Modification", "Mutation", "Variation" },
        new string[] { "Organ", "Cell", "Tissue" },
        new string[] { "1", "2", "3" },
    };

        int[] correctB1 = { 2, 0, 1 };
        int[] correctB2 = { 1, 1, 2 };

        Button[] answerButtons;
        int currentQuestionIndex = 0;
        string[] currentQuestions;
        string[][] currentAnswers;
        int[] currentCorrectAnswerIndexes;
        int correctAnswered = 0;
        Boolean testFinished;
        public static int totalBioCorrectAnswers = 0;
        public static int totalBioQuestionAmount = 0;


        private void LoadTest(string[] questions, string[][] answers, int[] correctIndexes)
        {
            currentQuestions = questions;
            currentAnswers = answers;
            currentCorrectAnswerIndexes = correctIndexes;

        }

        public static int testScoreBioA(int correctAnswerAmount)
        {
            totalBioCorrectAnswers += correctAnswerAmount;
            return totalBioCorrectAnswers;
        }

        public static int testScoreBioQ(int questionAmount)
        {
            totalBioQuestionAmount += questionAmount;
            return totalBioQuestionAmount;
        }

        private void LoadQuestion(int questionIndex)
        {
            QuestionLabel.Show();
            TestWillAppearPanel.Show();
            QuestionLabel.Text = currentQuestions[questionIndex];

            for (int i = 0; i < answerButtons.Length; i++)
            {
                answerButtons[i].Text = currentAnswers[questionIndex][i];
                QuestionNumber.Text = "Question " + (questionIndex + 1);
                answerButtons[i].BackColor = Color.Snow;
            }
        }
        private void AnswerButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int clickedButtonIndex = Array.IndexOf(answerButtons, clickedButton);

            if (clickedButtonIndex == currentCorrectAnswerIndexes[currentQuestionIndex])
            {
                clickedButton.BackColor = Color.Lime;
                MessageBox.Show("Your answer is correct!");
                correctAnswered++;
            }
            else
            {
                clickedButton.BackColor = Color.Red;
                MessageBox.Show("Your answer is wrong!");
            }
            currentQuestionIndex++;
            if (currentQuestionIndex < currentQuestions.Length)
            {
                LoadQuestion(currentQuestionIndex);
            }
            else
            {
                testFinished = true;
                timer1.Stop();
                testStop();
                MessageBox.Show("Test complete!");
                QuestionNumber.Text = "Test Completed";
                QuestionLabel.Text = "You have scored " + correctAnswered + "\n        out of " + currentQuestions.Length + "!";
                testScoreBioA(correctAnswered);
                testScoreBioQ(currentQuestions.Length);

            }
        }
        public Form4()
        {
            InitializeComponent();
            answerButtons = new Button[] { AnswerButton1, AnswerButton2, AnswerButton3 };
            TestWillAppearPanel.Show();
            QuestionPanel.Hide();
            BioTest1.Show();
            BioTest2.Show();
            AnswerButton1.Hide();
            AnswerButton2.Hide();
            AnswerButton3.Hide();
        }
        private void TestChosen()
        {
            TestWillAppearPanel.Hide();
            QuestionPanel.Show();
            SubTitle.Text = "Choices";
            BioTest1.Hide();
            BioTest2.Hide();
            AnswerButton1.Show();
            AnswerButton2.Show();
            AnswerButton3.Show();
        }
        int seconds = 60;

        private void BioTest1_Click(object sender, EventArgs e)
        {
            TestChosen();
            timer1.Start();
            LoadTest(questionsB1, answersB1, correctB1);
            LoadQuestion(0);
        }

        private void BioTest2_Click(object sender, EventArgs e)
        {
            TestChosen();
            timer1.Start();
            LoadTest(questionsB2, answersB2, correctB2);
            LoadQuestion(0);
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            TimeLabel.Text = (--seconds).ToString();
            if (seconds <= 0)
            {
                timer1.Stop();
                testStop();
                QuestionNumber.Text = "Test Completed";
                QuestionLabel.Text = "Your time is up!\n" + "You have scored " + correctAnswered + "\n        out of " + currentQuestions.Length + "!";
                testScoreBioA(correctAnswered);
                testScoreBioQ(currentQuestionIndex);
            }
        }
        private void testStop()
        {
            AnswerButton1.Enabled = false;
            AnswerButton2.Enabled = false;
            AnswerButton3.Enabled = false;
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
                TestChoiceForm form = new TestChoiceForm();

                if (timer1.Enabled && testFinished == false)
                {
                var result = MessageBox.Show("You are about to exit the test. Any progress made will not be saved.", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }
            }
            timer1.Stop();
            form.Show();
            this.Hide();

            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled && testFinished == false)
            {
                var result = MessageBox.Show("You are about to exit the test. Any progress made will not be saved.", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }
            }
            timer1.Stop();
            Form5 form = new Form5();
            form.Show();
            this.Close();
        }
    }
}
