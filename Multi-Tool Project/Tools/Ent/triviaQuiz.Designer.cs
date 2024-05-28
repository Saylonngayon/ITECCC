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
            rbOption1 = new RadioButton();
            rbOption2 = new RadioButton();
            rbOption3 = new RadioButton();
            rbOption4 = new RadioButton();
            btnSubmit = new Button();
            lblScore = new Label();
            lblQuestion = new Label();
            lblEnterQuestions = new Label();
            txtNumQuestions = new TextBox();
            btnStartQuiz = new Button();
            btnRestart = new Button();
            btnEndQuiz = new Button();
            SuspendLayout();
            // 
            // rbOption1
            // 
            rbOption1.AutoSize = true;
            rbOption1.Location = new Point(395, 73);
            rbOption1.Name = "rbOption1";
            rbOption1.Size = new Size(94, 19);
            rbOption1.TabIndex = 0;
            rbOption1.TabStop = true;
            rbOption1.Text = "radioButton1";
            rbOption1.UseVisualStyleBackColor = true;
            // 
            // rbOption2
            // 
            rbOption2.AutoSize = true;
            rbOption2.Location = new Point(495, 73);
            rbOption2.Name = "rbOption2";
            rbOption2.Size = new Size(94, 19);
            rbOption2.TabIndex = 1;
            rbOption2.TabStop = true;
            rbOption2.Text = "radioButton2";
            rbOption2.UseVisualStyleBackColor = true;
            // 
            // rbOption3
            // 
            rbOption3.AutoSize = true;
            rbOption3.Location = new Point(395, 98);
            rbOption3.Name = "rbOption3";
            rbOption3.Size = new Size(94, 19);
            rbOption3.TabIndex = 2;
            rbOption3.TabStop = true;
            rbOption3.Text = "radioButton3";
            rbOption3.UseVisualStyleBackColor = true;
            // 
            // rbOption4
            // 
            rbOption4.AutoSize = true;
            rbOption4.Location = new Point(495, 98);
            rbOption4.Name = "rbOption4";
            rbOption4.Size = new Size(94, 19);
            rbOption4.TabIndex = 3;
            rbOption4.TabStop = true;
            rbOption4.Text = "radioButton4";
            rbOption4.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(645, 214);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(740, 25);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(48, 15);
            lblScore.TabIndex = 5;
            lblScore.Text = "Score: 0";
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(291, 133);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(38, 15);
            lblQuestion.TabIndex = 6;
            lblQuestion.Text = "label1";
            // 
            // lblEnterQuestions
            // 
            lblEnterQuestions.AutoSize = true;
            lblEnterQuestions.Location = new Point(63, 89);
            lblEnterQuestions.Name = "lblEnterQuestions";
            lblEnterQuestions.Size = new Size(170, 15);
            lblEnterQuestions.TabIndex = 7;
            lblEnterQuestions.Text = "Enter the number of questions:";
            // 
            // txtNumQuestions
            // 
            txtNumQuestions.Location = new Point(63, 107);
            txtNumQuestions.Name = "txtNumQuestions";
            txtNumQuestions.Size = new Size(100, 23);
            txtNumQuestions.TabIndex = 8;
            // 
            // btnStartQuiz
            // 
            btnStartQuiz.Location = new Point(257, 258);
            btnStartQuiz.Name = "btnStartQuiz";
            btnStartQuiz.Size = new Size(75, 23);
            btnStartQuiz.TabIndex = 9;
            btnStartQuiz.Text = "Start";
            btnStartQuiz.UseVisualStyleBackColor = true;
            btnStartQuiz.Click += btnStartQuiz_Click;
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(346, 201);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(75, 23);
            btnRestart.TabIndex = 10;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Visible = false;
            btnRestart.Click += btnRestart_Click;
            // 
            // btnEndQuiz
            // 
            btnEndQuiz.Location = new Point(529, 313);
            btnEndQuiz.Name = "btnEndQuiz";
            btnEndQuiz.Size = new Size(75, 23);
            btnEndQuiz.TabIndex = 11;
            btnEndQuiz.Text = "End";
            btnEndQuiz.UseVisualStyleBackColor = true;
            btnEndQuiz.Visible = false;
            btnEndQuiz.Click += btnEndQuiz_Click;
            // 
            // triviaQuiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEndQuiz);
            Controls.Add(btnRestart);
            Controls.Add(btnStartQuiz);
            Controls.Add(txtNumQuestions);
            Controls.Add(lblEnterQuestions);
            Controls.Add(lblQuestion);
            Controls.Add(lblScore);
            Controls.Add(btnSubmit);
            Controls.Add(rbOption4);
            Controls.Add(rbOption3);
            Controls.Add(rbOption2);
            Controls.Add(rbOption1);
            Name = "triviaQuiz";
            Text = "triviaQuiz";
            Load += triviaQuiz_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbOption1;
        private RadioButton rbOption2;
        private RadioButton rbOption3;
        private RadioButton rbOption4;
        private Button btnSubmit;
        private Label lblScore;
        private Label lblQuestion;
        private Label lblEnterQuestions;
        private TextBox txtNumQuestions;
        private Button btnStartQuiz;
        private Button btnRestart;
        private Button btnEndQuiz;
    }
}