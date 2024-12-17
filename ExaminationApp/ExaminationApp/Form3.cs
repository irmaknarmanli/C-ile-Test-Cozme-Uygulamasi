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
    public partial class Form3 : Form
    {
        private string[] questionsE1 = {
        "A: Are you a teacher?\n B: Yes, I ... ",
        "A: ... your name\n Marcus?\n  B: Yes, it ...",
        "A: Are your children\n here?\n B: No, they ... ",
    };
        private string[][] answersE1 = {
        new string[] { "am", "is", "are" },
        new string[] { "am", "is", "are" },
        new string[] { "am not", "isn't", "aren't" },
    };

        private string[] questionsE2 = {
        "The milk isn't ... the\n fridge.",
        "Are you ... home?",
        "Call me when you\n are ... the bus.",
    };
        private string[][] answersE2 = {
        new string[] { "in", "on", "at" },
        new string[] { "at the", "at", "in the" },
        new string[] { "in", "on", "at" }
    };

        int[] correctE1 = { 0, 1, 2 };
        int[] correctE2 = { 0, 1, 1 };

        Button[] answerButtons;
        int currentQuestionIndex = 0;
        string[] currentQuestions;
        string[][] currentAnswers;
        int[] currentCorrectAnswerIndexes;
        int correctAnswered = 0;
        Boolean testFinished;
        public static int totalEngCorrectAnswers = 0;
        public static int totalEngQuestionAmount = 0;
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
                timer1.Stop();
                testStop();
                MessageBox.Show("Test complete!");
                QuestionNumber.Text = "Test Completed";
                QuestionLabel.Text = "You have scored " + correctAnswered + "\n        out of " + currentQuestions.Length + "!";
                testScoreEngA(correctAnswered);
                testScoreEngQ(currentQuestions.Length);
            }
        }
            public Form3()
            {
            InitializeComponent();
            answerButtons = new Button[] { AnswerButton1, AnswerButton2, AnswerButton3 };
            TestWillAppearPanel.Show();
            QuestionPanel.Hide();
            EngTest1.Show();
            EngTest2.Show();
            AnswerButton1.Hide();
            AnswerButton2.Hide();
            AnswerButton3.Hide();

        }

        private void TestChosen()
        {
            TestWillAppearPanel.Hide();
            QuestionPanel.Show();
            SubTitle.Text = "Choices";
            EngTest1.Hide();
            EngTest2.Hide();
            AnswerButton1.Show();
            AnswerButton2.Show();
            AnswerButton3.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
            {

            }
        int seconds = 60;
        private void EngTest1_Click(object sender, EventArgs e)
        {
            TestChosen();
            timer1.Start();
            LoadTest(questionsE1, answersE1, correctE1);
            LoadQuestion(0);
        }

        private void EngTest2_Click(object sender, EventArgs e)
        {
            TestChosen();
            timer1.Start();
            LoadTest(questionsE2, answersE2, correctE2);
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
                testScoreEngA(correctAnswered);
                testScoreEngQ(currentQuestionIndex);
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
        }

        public static int testScoreEngA(int correctAnswerAmount)
        {
            totalEngCorrectAnswers += correctAnswerAmount;
            return totalEngCorrectAnswers;
        }

        public static int testScoreEngQ(int questionAmount)
        {
            totalEngQuestionAmount += questionAmount;
            return totalEngQuestionAmount;
        }
    }
    }

