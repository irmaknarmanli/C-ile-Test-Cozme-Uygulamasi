using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExaminationApp
{
    public partial class TestScreenMath : Form
    {
        private string[] questionsM1 = {
        "– 6 (2x – 3) – 11",
        "If 3X – 4 = 11,\n what is X?",
        "        -(-3)^3",
    };
        private string[][] answersM1 = {
        new string[] { "12x − 7", "7 − 12x", "−12x − 29 ", "7 + 12x" },
        new string[] { "2.5", "4", "5", "8" },
        new string[] { "-9", "27", "9", "-27" },
    };

        private string[] questionsM2 = {
        "(3a - 5b)(3a + 5b)",
        "         24/6",
        "      5 x 13 + 6 ",
    };
        private string[][] answersM2 = {
        new string[] { "9a - 25b", "9a + 25b", "9a^2 + 25b^2", "9a^2 - 25b^2" },
        new string[] { "4", "5", "6", "7" },
        new string[] { "76", "71", "65", "59" },
    };

        private string[] questionsM3 = {
        "    2037 + 3605",
        "     5.4 – 2.9",
        "     4 x 15 / 3",
    };
        private string[][] answersM3 = {
        new string[] { "5532", "5542", "5642", "5632" },
        new string[] { "2.3", "3.2", "3.5", "2.5" },
        new string[] { "10", "15", "20", "25" },
    };

        int[] correctM1 = { 1, 2, 1 };
        int[] correctM2 = { 3, 0, 1 };
        int[] correctM3 = { 2, 3, 2 };

        Button[] answerButtons;
        int currentQuestionIndex = 0;
        string[] currentQuestions;
        string[][] currentAnswers;
        int[] currentCorrectAnswerIndexes;
        int correctAnswered = 0;
        Boolean testFinished;
        public static int totalMathCorrectAnswers = 0;
        public static int totalMathQuestionAmount = 0;

        private void LoadTest(string[] questions, string[][] answers, int[] correctIndexes)
        {
            currentQuestions = questions;
            currentAnswers = answers;
            currentCorrectAnswerIndexes = correctIndexes;
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
                testStop();
                timer1.Stop();
                MessageBox.Show("Test complete!");
                QuestionNumber.Text = "Test Completed";
                QuestionLabel.Text = "You have scored " + correctAnswered +"\n        out of " + currentQuestions.Length + "!";
                testScoreMathA(correctAnswered);
                testScoreMathQ(currentQuestions.Length);

            }
        }


        public TestScreenMath()
        {
            InitializeComponent();
            answerButtons = new Button[] { AnswerButton1, AnswerButton2, AnswerButton3, AnswerButton4 };
            TestWillAppearPanel.Show();
            QuestionPanel.Hide();
            MathTest1.Show();
            MathTest2.Show();
            MathTest3.Show();
            AnswerButton1.Hide();
            AnswerButton2.Hide();
            AnswerButton3.Hide();
            AnswerButton4.Hide();


        }

        private void TestChosen()
        {
            TestWillAppearPanel.Hide();
            QuestionPanel.Show();
            SubTitle.Text = "Choices";
            MathTest1.Hide();
            MathTest2.Hide();
            MathTest3.Hide();
            AnswerButton1.Show();
            AnswerButton2.Show();
            AnswerButton3.Show();
            AnswerButton4.Show();
        }
       
        private void MathTest1_Click_1(object sender, EventArgs e)
        {
            TestChosen();
            timer1.Start();
            LoadTest(questionsM1, answersM1, correctM1);
            LoadQuestion(0);
            
        }
        
        private void MathTest2_Click_1(object sender, EventArgs e)
        {
            TestChosen();
            timer1.Start();
            LoadTest(questionsM2, answersM2, correctM2);
            LoadQuestion(0);
        }

        private void MathTest3_Click_1(object sender, EventArgs e)
        {
            TestChosen();
            timer1.Start();
            LoadTest(questionsM3, answersM3, correctM3);
            LoadQuestion(0);
        }
         int seconds = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = (--seconds).ToString();
            if (seconds <= 0)
            {
                timer1.Stop();
                testStop();
                QuestionNumber.Text = "Test Completed";
                QuestionLabel.Text = "Your time is up!\n" + "You have scored " + correctAnswered + "\n        out of " + currentQuestions.Length + "!";
                testScoreMathA(correctAnswered);
                testScoreMathQ(currentQuestionIndex);

            }
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

        private void testStop()
        {
            AnswerButton1.Enabled = false;
            AnswerButton2.Enabled = false;
            AnswerButton3.Enabled = false;  
            AnswerButton4.Enabled = false;
        }

        public static int testScoreMathA(int correctAnswerAmount)
        {
            totalMathCorrectAnswers += correctAnswerAmount;
            return totalMathCorrectAnswers;
        }

        public static int testScoreMathQ(int questionAmount)
        {
            totalMathQuestionAmount += questionAmount;
            return totalMathQuestionAmount;
        }

      
    }
}