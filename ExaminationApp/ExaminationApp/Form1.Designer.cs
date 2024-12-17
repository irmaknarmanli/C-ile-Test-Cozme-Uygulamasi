namespace ExaminationApp
{
    partial class TestChoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestChoiceForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.myResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.MathButton = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.EngButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BioButton = new System.Windows.Forms.Button();
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mathPic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathPic)).BeginInit();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 78);
            this.panel1.TabIndex = 1;
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
            this.menuStrip1.Location = new System.Drawing.Point(421, 11);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(385, 35);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // myResultsToolStripMenuItem
            // 
            this.myResultsToolStripMenuItem.Font = new System.Drawing.Font("Ink Free", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myResultsToolStripMenuItem.Name = "myResultsToolStripMenuItem";
            this.myResultsToolStripMenuItem.Size = new System.Drawing.Size(139, 31);
            this.myResultsToolStripMenuItem.Text = "My Results";
            this.myResultsToolStripMenuItem.Click += new System.EventHandler(this.myResultsToolStripMenuItem_Click);
            // 
            // testsToolStripMenuItem
            // 
            this.testsToolStripMenuItem.Font = new System.Drawing.Font("Ink Free", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.testsToolStripMenuItem.Name = "testsToolStripMenuItem";
            this.testsToolStripMenuItem.Size = new System.Drawing.Size(88, 31);
            this.testsToolStripMenuItem.Text = "Tests";
            // 
            // MathButton
            // 
            this.MathButton.BackColor = System.Drawing.Color.Salmon;
            this.MathButton.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MathButton.Location = new System.Drawing.Point(73, 272);
            this.MathButton.Name = "MathButton";
            this.MathButton.Size = new System.Drawing.Size(167, 51);
            this.MathButton.TabIndex = 0;
            this.MathButton.Text = "Maths";
            this.MathButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolTip1.SetToolTip(this.MathButton, "Shows the available math tests");
            this.MathButton.UseVisualStyleBackColor = false;
            this.MathButton.Click += new System.EventHandler(this.MathButton_Click);
            this.MathButton.MouseLeave += new System.EventHandler(this.MathButton_MouseLeave);
            this.MathButton.MouseHover += new System.EventHandler(this.MathButton_MouseHover);
            // 
            // EngButton
            // 
            this.EngButton.BackColor = System.Drawing.Color.Salmon;
            this.EngButton.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EngButton.Location = new System.Drawing.Point(320, 274);
            this.EngButton.Name = "EngButton";
            this.EngButton.Size = new System.Drawing.Size(167, 51);
            this.EngButton.TabIndex = 1;
            this.EngButton.Text = "English";
            this.EngButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolTip2.SetToolTip(this.EngButton, "Shows the available English tests");
            this.EngButton.UseVisualStyleBackColor = false;
            this.EngButton.Click += new System.EventHandler(this.EngButton_Click);
            this.EngButton.MouseLeave += new System.EventHandler(this.EngButton_MouseLeave);
            this.EngButton.MouseHover += new System.EventHandler(this.EngButton_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categories";
            // 
            // BioButton
            // 
            this.BioButton.BackColor = System.Drawing.Color.Salmon;
            this.BioButton.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BioButton.Location = new System.Drawing.Point(558, 274);
            this.BioButton.Name = "BioButton";
            this.BioButton.Size = new System.Drawing.Size(167, 51);
            this.BioButton.TabIndex = 2;
            this.BioButton.Text = "Biology";
            this.BioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolTip3.SetToolTip(this.BioButton, "Shows the available biology tests");
            this.BioButton.UseVisualStyleBackColor = false;
            this.BioButton.Click += new System.EventHandler(this.BioButton_Click);
            this.BioButton.MouseLeave += new System.EventHandler(this.BioButton_MouseLeave);
            this.BioButton.MouseHover += new System.EventHandler(this.BioButton_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.PeachPuff;
            this.pictureBox2.Image = global::ExaminationApp.Properties.Resources.bioSym;
            this.pictureBox2.Location = new System.Drawing.Point(569, 133);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 135);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExaminationApp.Properties.Resources.mathSym2;
            this.pictureBox1.Location = new System.Drawing.Point(83, 133);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // mathPic
            // 
            this.mathPic.BackColor = System.Drawing.Color.PeachPuff;
            this.mathPic.Image = global::ExaminationApp.Properties.Resources.engSym;
            this.mathPic.Location = new System.Drawing.Point(330, 133);
            this.mathPic.Name = "mathPic";
            this.mathPic.Size = new System.Drawing.Size(147, 135);
            this.mathPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mathPic.TabIndex = 3;
            this.mathPic.TabStop = false;
            // 
            // TestChoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BioButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.EngButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MathButton);
            this.Controls.Add(this.mathPic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "TestChoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Examination App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem myResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testsToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox mathPic;
        private System.Windows.Forms.Button MathButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button EngButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BioButton;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}

