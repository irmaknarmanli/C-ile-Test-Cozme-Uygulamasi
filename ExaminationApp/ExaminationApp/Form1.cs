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
    public partial class TestChoiceForm : Form
    {
        public TestChoiceForm()
        {
            InitializeComponent();
            MathButton.BringToFront();
          
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MathButton_MouseHover(object sender, EventArgs e)
        {
            MathButton.Font = new Font("Ink Free", 14, FontStyle.Bold | FontStyle.Italic);
            MathButton.BackColor = Color.DarkSalmon;
        }

        private void MathButton_MouseLeave(object sender, EventArgs e)
        {
            MathButton.Font = new Font("Ink Free", 14, FontStyle.Italic);
            MathButton.BackColor = Color.Salmon;
        }

        private void EngButton_MouseLeave(object sender, EventArgs e)
        {
            EngButton.Font = new Font("Ink Free", 14,FontStyle.Italic);
            EngButton.BackColor = Color.Salmon;
        }

        private void EngButton_MouseHover(object sender, EventArgs e)
        {
            EngButton.Font = new Font("Ink Free", 14, FontStyle.Bold | FontStyle.Italic);
            EngButton.BackColor = Color.DarkSalmon;
        }

        private void BioButton_MouseHover(object sender, EventArgs e)
        {
            BioButton.Font = new Font("Ink Free", 14, FontStyle.Bold | FontStyle.Italic);
            BioButton.BackColor = Color.DarkSalmon;
        }

        private void BioButton_MouseLeave(object sender, EventArgs e)
        {
            BioButton.Font = new Font("Ink Free", 14, FontStyle.Italic);
            BioButton.BackColor = Color.Salmon;
        }

        private void MathButton_Click(object sender, EventArgs e)
        {
            TestScreenMath mathTests = new TestScreenMath();
            mathTests.Show();
            this.Hide();
        }
        private void EngButton_Click(object sender, EventArgs e)
        {
            Form3 EngTests = new Form3();
            EngTests.Show();
            this.Hide();
        }

        private void BioButton_Click(object sender, EventArgs e)
        {
            Form4 BioTests = new Form4();
            BioTests.Show();
            this.Hide();
        }

        private void myResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
            this.Hide();
        }
    }

    
}
