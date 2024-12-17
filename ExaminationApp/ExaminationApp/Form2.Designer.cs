namespace ExaminationApp
{
    partial class TestScreenMath
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestScreenMath));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MathTest1 = new System.Windows.Forms.Button();
            this.SubTitle = new System.Windows.Forms.Label();
            this.QuestionNumber = new System.Windows.Forms.Label();
            this.MathTest2 = new System.Windows.Forms.Button();
            this.MathTest3 = new System.Windows.Forms.Button();
            this.AnswerButton1 = new System.Windows.Forms.Button();
            this.AnswerButton2 = new System.Windows.Forms.Button();
            this.AnswerButton3 = new System.Windows.Forms.Button();
            this.AnswerButton4 = new System.Windows.Forms.Button();
            this.TestWillAppearPanel = new System.Windows.Forms.Label();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.QuestionPanel = new System.Windows.Forms.Panel();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.QuestionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.menuStrip2);
            this.panel2.Location = new System.Drawing.Point(-2, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(806, 78);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rage Italic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(453, 54);
            this.label2.TabIndex = 0;
            this.label2.Text = "Irmak\'s Examination App";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip2.BackColor = System.Drawing.Color.IndianRed;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(4, 4, 0, 5);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip2.Location = new System.Drawing.Point(421, 11);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(385, 35);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Ink Free", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(139, 31);
            this.toolStripMenuItem1.Text = "My Results";
            this.toolStripMenuItem1.ToolTipText = "Shows Your Total Results ";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Ink Free", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(88, 31);
            this.toolStripMenuItem2.Text = "Tests";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // MathTest1
            // 
            this.MathTest1.BackColor = System.Drawing.Color.Snow;
            this.MathTest1.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MathTest1.Location = new System.Drawing.Point(68, 147);
            this.MathTest1.Name = "MathTest1";
            this.MathTest1.Size = new System.Drawing.Size(113, 35);
            this.MathTest1.TabIndex = 0;
            this.MathTest1.Text = "Test 1";
            this.MathTest1.UseVisualStyleBackColor = false;
            this.MathTest1.Click += new System.EventHandler(this.MathTest1_Click_1);
            // 
            // SubTitle
            // 
            this.SubTitle.AutoSize = true;
            this.SubTitle.Font = new System.Drawing.Font("Ink Free", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SubTitle.Location = new System.Drawing.Point(37, 97);
            this.SubTitle.Name = "SubTitle";
            this.SubTitle.Size = new System.Drawing.Size(172, 34);
            this.SubTitle.TabIndex = 7;
            this.SubTitle.Text = "Math Tests";
            // 
            // QuestionNumber
            // 
            this.QuestionNumber.AutoSize = true;
            this.QuestionNumber.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.QuestionNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.QuestionNumber.Location = new System.Drawing.Point(31, 58);
            this.QuestionNumber.Name = "QuestionNumber";
            this.QuestionNumber.Size = new System.Drawing.Size(120, 29);
            this.QuestionNumber.TabIndex = 0;
            this.QuestionNumber.Text = "Question 1:";
            // 
            // MathTest2
            // 
            this.MathTest2.BackColor = System.Drawing.Color.Snow;
            this.MathTest2.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MathTest2.Location = new System.Drawing.Point(68, 211);
            this.MathTest2.Name = "MathTest2";
            this.MathTest2.Size = new System.Drawing.Size(113, 35);
            this.MathTest2.TabIndex = 1;
            this.MathTest2.Text = "Test 2";
            this.MathTest2.UseVisualStyleBackColor = false;
            this.MathTest2.Click += new System.EventHandler(this.MathTest2_Click_1);
            // 
            // MathTest3
            // 
            this.MathTest3.BackColor = System.Drawing.Color.Snow;
            this.MathTest3.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MathTest3.Location = new System.Drawing.Point(68, 276);
            this.MathTest3.Name = "MathTest3";
            this.MathTest3.Size = new System.Drawing.Size(113, 35);
            this.MathTest3.TabIndex = 2;
            this.MathTest3.Text = "Test 3";
            this.MathTest3.UseVisualStyleBackColor = false;
            this.MathTest3.Click += new System.EventHandler(this.MathTest3_Click_1);
            // 
            // AnswerButton1
            // 
            this.AnswerButton1.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AnswerButton1.Location = new System.Drawing.Point(68, 147);
            this.AnswerButton1.Name = "AnswerButton1";
            this.AnswerButton1.Size = new System.Drawing.Size(172, 47);
            this.AnswerButton1.TabIndex = 9;
            this.AnswerButton1.Text = ".";
            this.AnswerButton1.UseVisualStyleBackColor = true;
            this.AnswerButton1.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // AnswerButton2
            // 
            this.AnswerButton2.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AnswerButton2.Location = new System.Drawing.Point(68, 211);
            this.AnswerButton2.Name = "AnswerButton2";
            this.AnswerButton2.Size = new System.Drawing.Size(172, 47);
            this.AnswerButton2.TabIndex = 10;
            this.AnswerButton2.Text = ".";
            this.AnswerButton2.UseVisualStyleBackColor = true;
            this.AnswerButton2.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // AnswerButton3
            // 
            this.AnswerButton3.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AnswerButton3.Location = new System.Drawing.Point(68, 276);
            this.AnswerButton3.Name = "AnswerButton3";
            this.AnswerButton3.Size = new System.Drawing.Size(172, 47);
            this.AnswerButton3.TabIndex = 11;
            this.AnswerButton3.Text = ".";
            this.AnswerButton3.UseVisualStyleBackColor = true;
            this.AnswerButton3.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // AnswerButton4
            // 
            this.AnswerButton4.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AnswerButton4.Location = new System.Drawing.Point(68, 338);
            this.AnswerButton4.Name = "AnswerButton4";
            this.AnswerButton4.Size = new System.Drawing.Size(172, 47);
            this.AnswerButton4.TabIndex = 12;
            this.AnswerButton4.Text = ".";
            this.AnswerButton4.UseVisualStyleBackColor = true;
            this.AnswerButton4.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // TestWillAppearPanel
            // 
            this.TestWillAppearPanel.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.TestWillAppearPanel.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TestWillAppearPanel.Location = new System.Drawing.Point(355, 107);
            this.TestWillAppearPanel.Margin = new System.Windows.Forms.Padding(3);
            this.TestWillAppearPanel.Name = "TestWillAppearPanel";
            this.TestWillAppearPanel.Size = new System.Drawing.Size(378, 289);
            this.TestWillAppearPanel.TabIndex = 0;
            this.TestWillAppearPanel.Text = "The test you\'ve chosen will appear here. You will have a minute to solve.";
            this.TestWillAppearPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TestWillAppearPanel.Visible = false;
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.QuestionLabel.Location = new System.Drawing.Point(81, 126);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(224, 34);
            this.QuestionLabel.TabIndex = 2;
            this.QuestionLabel.Text = "– 6 (2x – 3) – 11 ";
            // 
            // QuestionPanel
            // 
            this.QuestionPanel.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.QuestionPanel.Controls.Add(this.TimeLabel);
            this.QuestionPanel.Controls.Add(this.QuestionNumber);
            this.QuestionPanel.Controls.Add(this.QuestionLabel);
            this.QuestionPanel.Location = new System.Drawing.Point(355, 107);
            this.QuestionPanel.Name = "QuestionPanel";
            this.QuestionPanel.Size = new System.Drawing.Size(378, 289);
            this.QuestionPanel.TabIndex = 13;
            // 
            // TimeLabel
            // 
            this.TimeLabel.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TimeLabel.Location = new System.Drawing.Point(329, 12);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(49, 26);
            this.TimeLabel.TabIndex = 14;
            this.TimeLabel.Text = "60";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TestScreenMath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QuestionPanel);
            this.Controls.Add(this.AnswerButton4);
            this.Controls.Add(this.AnswerButton3);
            this.Controls.Add(this.AnswerButton2);
            this.Controls.Add(this.AnswerButton1);
            this.Controls.Add(this.MathTest3);
            this.Controls.Add(this.MathTest2);
            this.Controls.Add(this.SubTitle);
            this.Controls.Add(this.MathTest1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TestWillAppearPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TestScreenMath";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Examination App";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.QuestionPanel.ResumeLayout(false);
            this.QuestionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button MathTest1;
        private System.Windows.Forms.Label SubTitle;
        private System.Windows.Forms.Button MathTest2;
        private System.Windows.Forms.Button MathTest3;
        private System.Windows.Forms.Label QuestionNumber;
        private System.Windows.Forms.Button AnswerButton1;
        private System.Windows.Forms.Button AnswerButton2;
        private System.Windows.Forms.Button AnswerButton3;
        private System.Windows.Forms.Button AnswerButton4;
        private System.Windows.Forms.Label TestWillAppearPanel;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Panel QuestionPanel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer timer1;
    }
}