namespace ExaminationApp
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.myResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MathLabel = new System.Windows.Forms.Label();
            this.questionMLabel = new System.Windows.Forms.Label();
            this.CorrectMLabel = new System.Windows.Forms.Label();
            this.progressBarM = new System.Windows.Forms.ProgressBar();
            this.EngLabel = new System.Windows.Forms.Label();
            this.BioLabel = new System.Windows.Forms.Label();
            this.questionELabel = new System.Windows.Forms.Label();
            this.questionBLabel = new System.Windows.Forms.Label();
            this.CorrectELabel = new System.Windows.Forms.Label();
            this.CorrectBLabel = new System.Windows.Forms.Label();
            this.progressBarE = new System.Windows.Forms.ProgressBar();
            this.progressBarB = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 78);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rage Italic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Irmak\'s Examination App";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.Color.IndianRed;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(4, 4, 0, 5);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myResultsToolStripMenuItem,
            this.testsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(569, 11);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(237, 35);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // myResultsToolStripMenuItem
            // 
            this.myResultsToolStripMenuItem.Font = new System.Drawing.Font("Ink Free", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myResultsToolStripMenuItem.Name = "myResultsToolStripMenuItem";
            this.myResultsToolStripMenuItem.Size = new System.Drawing.Size(139, 31);
            this.myResultsToolStripMenuItem.Text = "My Results";
            // 
            // testsToolStripMenuItem
            // 
            this.testsToolStripMenuItem.Font = new System.Drawing.Font("Ink Free", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.testsToolStripMenuItem.Name = "testsToolStripMenuItem";
            this.testsToolStripMenuItem.Size = new System.Drawing.Size(88, 31);
            this.testsToolStripMenuItem.Text = "Tests";
            this.testsToolStripMenuItem.Click += new System.EventHandler(this.testsToolStripMenuItem_Click);
            // 
            // MathLabel
            // 
            this.MathLabel.AutoSize = true;
            this.MathLabel.Font = new System.Drawing.Font("Ink Free", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MathLabel.Location = new System.Drawing.Point(12, 91);
            this.MathLabel.Name = "MathLabel";
            this.MathLabel.Size = new System.Drawing.Size(94, 34);
            this.MathLabel.TabIndex = 3;
            this.MathLabel.Text = "Math:";
            // 
            // questionMLabel
            // 
            this.questionMLabel.AutoSize = true;
            this.questionMLabel.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.questionMLabel.Location = new System.Drawing.Point(12, 134);
            this.questionMLabel.Name = "questionMLabel";
            this.questionMLabel.Size = new System.Drawing.Size(153, 22);
            this.questionMLabel.TabIndex = 4;
            this.questionMLabel.Text = "Total Questions: 0";
            // 
            // CorrectMLabel
            // 
            this.CorrectMLabel.AutoSize = true;
            this.CorrectMLabel.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CorrectMLabel.Location = new System.Drawing.Point(14, 169);
            this.CorrectMLabel.Name = "CorrectMLabel";
            this.CorrectMLabel.Size = new System.Drawing.Size(202, 22);
            this.CorrectMLabel.TabIndex = 7;
            this.CorrectMLabel.Text = "Total Correct Answers: 0";
            // 
            // progressBarM
            // 
            this.progressBarM.Location = new System.Drawing.Point(292, 117);
            this.progressBarM.Name = "progressBarM";
            this.progressBarM.Size = new System.Drawing.Size(460, 65);
            this.progressBarM.TabIndex = 9;
            // 
            // EngLabel
            // 
            this.EngLabel.AutoSize = true;
            this.EngLabel.Font = new System.Drawing.Font("Ink Free", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EngLabel.Location = new System.Drawing.Point(10, 211);
            this.EngLabel.Name = "EngLabel";
            this.EngLabel.Size = new System.Drawing.Size(114, 34);
            this.EngLabel.TabIndex = 10;
            this.EngLabel.Text = "English:";
            // 
            // BioLabel
            // 
            this.BioLabel.AutoSize = true;
            this.BioLabel.Font = new System.Drawing.Font("Ink Free", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BioLabel.Location = new System.Drawing.Point(12, 327);
            this.BioLabel.Name = "BioLabel";
            this.BioLabel.Size = new System.Drawing.Size(111, 34);
            this.BioLabel.TabIndex = 11;
            this.BioLabel.Text = "Biology:";
            // 
            // questionELabel
            // 
            this.questionELabel.AutoSize = true;
            this.questionELabel.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.questionELabel.Location = new System.Drawing.Point(14, 256);
            this.questionELabel.Name = "questionELabel";
            this.questionELabel.Size = new System.Drawing.Size(153, 22);
            this.questionELabel.TabIndex = 12;
            this.questionELabel.Text = "Total Questions: 0";
            // 
            // questionBLabel
            // 
            this.questionBLabel.AutoSize = true;
            this.questionBLabel.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.questionBLabel.Location = new System.Drawing.Point(14, 370);
            this.questionBLabel.Name = "questionBLabel";
            this.questionBLabel.Size = new System.Drawing.Size(153, 22);
            this.questionBLabel.TabIndex = 13;
            this.questionBLabel.Text = "Total Questions: 0";
            // 
            // CorrectELabel
            // 
            this.CorrectELabel.AutoSize = true;
            this.CorrectELabel.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CorrectELabel.Location = new System.Drawing.Point(14, 288);
            this.CorrectELabel.Name = "CorrectELabel";
            this.CorrectELabel.Size = new System.Drawing.Size(202, 22);
            this.CorrectELabel.TabIndex = 14;
            this.CorrectELabel.Text = "Total Correct Answers: 0";
            // 
            // CorrectBLabel
            // 
            this.CorrectBLabel.AutoSize = true;
            this.CorrectBLabel.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CorrectBLabel.Location = new System.Drawing.Point(14, 403);
            this.CorrectBLabel.Name = "CorrectBLabel";
            this.CorrectBLabel.Size = new System.Drawing.Size(202, 22);
            this.CorrectBLabel.TabIndex = 15;
            this.CorrectBLabel.Text = "Total Correct Answers: 0";
            // 
            // progressBarE
            // 
            this.progressBarE.Location = new System.Drawing.Point(292, 245);
            this.progressBarE.Name = "progressBarE";
            this.progressBarE.Size = new System.Drawing.Size(460, 65);
            this.progressBarE.TabIndex = 16;
            // 
            // progressBarB
            // 
            this.progressBarB.Location = new System.Drawing.Point(292, 360);
            this.progressBarB.Name = "progressBarB";
            this.progressBarB.Size = new System.Drawing.Size(460, 65);
            this.progressBarB.TabIndex = 17;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBarB);
            this.Controls.Add(this.progressBarE);
            this.Controls.Add(this.CorrectBLabel);
            this.Controls.Add(this.CorrectELabel);
            this.Controls.Add(this.questionBLabel);
            this.Controls.Add(this.questionELabel);
            this.Controls.Add(this.BioLabel);
            this.Controls.Add(this.EngLabel);
            this.Controls.Add(this.progressBarM);
            this.Controls.Add(this.CorrectMLabel);
            this.Controls.Add(this.questionMLabel);
            this.Controls.Add(this.MathLabel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Examination App";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem myResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testsToolStripMenuItem;
        private System.Windows.Forms.Label MathLabel;
        private System.Windows.Forms.Label questionMLabel;
        private System.Windows.Forms.Label CorrectMLabel;
        private System.Windows.Forms.ProgressBar progressBarM;
        private System.Windows.Forms.Label EngLabel;
        private System.Windows.Forms.Label BioLabel;
        private System.Windows.Forms.Label questionELabel;
        private System.Windows.Forms.Label questionBLabel;
        private System.Windows.Forms.Label CorrectELabel;
        private System.Windows.Forms.Label CorrectBLabel;
        private System.Windows.Forms.ProgressBar progressBarE;
        private System.Windows.Forms.ProgressBar progressBarB;
    }
}