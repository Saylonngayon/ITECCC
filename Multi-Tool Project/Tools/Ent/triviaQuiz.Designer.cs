namespace Multi_Tool_Project.Tools.Ent
{
    partial class triviaQuiz
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
            lblQuestion = new Label();
            rbOption1 = new RadioButton();
            rbOption2 = new RadioButton();
            rbOption3 = new RadioButton();
            rbOption4 = new RadioButton();
            btnSubmit = new Button();
            lblScore = new Label();
            btnRestart = new Button();
            btnEndQuiz = new Button();
            btnExit = new Button();
            btnReturn = new Button();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(555, 101);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(38, 15);
            lblQuestion.TabIndex = 24;
            lblQuestion.Text = "label1";
            // 
            // rbOption1
            // 
            rbOption1.AutoSize = true;
            rbOption1.Location = new Point(403, 173);
            rbOption1.Name = "rbOption1";
            rbOption1.Size = new Size(94, 19);
            rbOption1.TabIndex = 25;
            rbOption1.TabStop = true;
            rbOption1.Text = "radioButton1";
            rbOption1.UseVisualStyleBackColor = true;
            // 
            // rbOption2
            // 
            rbOption2.AutoSize = true;
            rbOption2.Location = new Point(403, 198);
            rbOption2.Name = "rbOption2";
            rbOption2.Size = new Size(94, 19);
            rbOption2.TabIndex = 26;
            rbOption2.TabStop = true;
            rbOption2.Text = "radioButton1";
            rbOption2.UseVisualStyleBackColor = true;
            // 
            // rbOption3
            // 
            rbOption3.AutoSize = true;
            rbOption3.Location = new Point(621, 181);
            rbOption3.Name = "rbOption3";
            rbOption3.Size = new Size(94, 19);
            rbOption3.TabIndex = 27;
            rbOption3.TabStop = true;
            rbOption3.Text = "radioButton1";
            rbOption3.UseVisualStyleBackColor = true;
            // 
            // rbOption4
            // 
            rbOption4.AutoSize = true;
            rbOption4.Location = new Point(621, 213);
            rbOption4.Name = "rbOption4";
            rbOption4.Size = new Size(94, 19);
            rbOption4.TabIndex = 28;
            rbOption4.TabStop = true;
            rbOption4.Text = "radioButton1";
            rbOption4.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(341, 101);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 29;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(399, 62);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(38, 15);
            lblScore.TabIndex = 30;
            lblScore.Text = "label1";
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(281, 160);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(75, 23);
            btnRestart.TabIndex = 31;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            // 
            // btnEndQuiz
            // 
            btnEndQuiz.Location = new Point(240, 74);
            btnEndQuiz.Name = "btnEndQuiz";
            btnEndQuiz.Size = new Size(75, 23);
            btnEndQuiz.TabIndex = 32;
            btnEndQuiz.Text = "End";
            btnEndQuiz.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(238, 233);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 33;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(238, 274);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(75, 23);
            btnReturn.TabIndex = 34;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // triviaQuiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 490);
            Controls.Add(btnReturn);
            Controls.Add(btnExit);
            Controls.Add(btnEndQuiz);
            Controls.Add(btnRestart);
            Controls.Add(lblScore);
            Controls.Add(btnSubmit);
            Controls.Add(rbOption4);
            Controls.Add(rbOption3);
            Controls.Add(rbOption2);
            Controls.Add(rbOption1);
            Controls.Add(lblQuestion);
            Name = "triviaQuiz";
            Text = "triviaQuiz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblQuestion;
        private RadioButton rbOption1;
        private RadioButton rbOption2;
        private RadioButton rbOption3;
        private RadioButton rbOption4;
        private Button btnSubmit;
        private Label lblScore;
        private Button btnRestart;
        private Button btnEndQuiz;
        private Button btnExit;
        private Button btnReturn;
    }
}