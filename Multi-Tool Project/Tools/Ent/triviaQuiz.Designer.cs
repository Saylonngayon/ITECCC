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
            lblEnterQuestions = new Label();
            txtNumQuestions = new TextBox();
            btnStartQuiz = new Button();
            btnRestart = new Button();
            btnExit = new Button();
            btnReturn = new Button();
            lblQuestion = new Label();
            SuspendLayout();
            // 
            // rbOption1
            // 
            rbOption1.AutoSize = true;
            rbOption1.Location = new Point(25, 141);
            rbOption1.Margin = new Padding(3, 4, 3, 4);
            rbOption1.Name = "rbOption1";
            rbOption1.Size = new Size(117, 24);
            rbOption1.TabIndex = 0;
            rbOption1.TabStop = true;
            rbOption1.Text = "radioButton1";
            rbOption1.UseVisualStyleBackColor = true;
            // 
            // rbOption2
            // 
            rbOption2.AutoSize = true;
            rbOption2.Location = new Point(204, 141);
            rbOption2.Margin = new Padding(3, 4, 3, 4);
            rbOption2.Name = "rbOption2";
            rbOption2.Size = new Size(117, 24);
            rbOption2.TabIndex = 1;
            rbOption2.TabStop = true;
            rbOption2.Text = "radioButton2";
            rbOption2.UseVisualStyleBackColor = true;
            // 
            // rbOption3
            // 
            rbOption3.AutoSize = true;
            rbOption3.Location = new Point(25, 194);
            rbOption3.Margin = new Padding(3, 4, 3, 4);
            rbOption3.Name = "rbOption3";
            rbOption3.Size = new Size(117, 24);
            rbOption3.TabIndex = 2;
            rbOption3.TabStop = true;
            rbOption3.Text = "radioButton3";
            rbOption3.UseVisualStyleBackColor = true;
            // 
            // rbOption4
            // 
            rbOption4.AutoSize = true;
            rbOption4.Location = new Point(204, 194);
            rbOption4.Margin = new Padding(3, 4, 3, 4);
            rbOption4.Name = "rbOption4";
            rbOption4.Size = new Size(117, 24);
            rbOption4.TabIndex = 3;
            rbOption4.TabStop = true;
            rbOption4.Text = "radioButton4";
            rbOption4.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(235, 271);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(86, 31);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(260, 36);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(61, 20);
            lblScore.TabIndex = 5;
            lblScore.Text = "Score: 0";
            // 
            // lblEnterQuestions
            // 
            lblEnterQuestions.AutoSize = true;
            lblEnterQuestions.Location = new Point(32, 97);
            lblEnterQuestions.Name = "lblEnterQuestions";
            lblEnterQuestions.Size = new Size(211, 20);
            lblEnterQuestions.TabIndex = 7;
            lblEnterQuestions.Text = "Enter the number of questions:";
            // 
            // txtNumQuestions
            // 
            txtNumQuestions.Location = new Point(32, 121);
            txtNumQuestions.Margin = new Padding(3, 4, 3, 4);
            txtNumQuestions.Name = "txtNumQuestions";
            txtNumQuestions.Size = new Size(114, 27);
            txtNumQuestions.TabIndex = 8;
            // 
            // btnStartQuiz
            // 
            btnStartQuiz.Location = new Point(32, 192);
            btnStartQuiz.Margin = new Padding(3, 4, 3, 4);
            btnStartQuiz.Name = "btnStartQuiz";
            btnStartQuiz.Size = new Size(86, 31);
            btnStartQuiz.TabIndex = 9;
            btnStartQuiz.Text = "Start";
            btnStartQuiz.UseVisualStyleBackColor = true;
            btnStartQuiz.Click += btnStartQuiz_Click;
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(143, 403);
            btnRestart.Margin = new Padding(3, 4, 3, 4);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(86, 31);
            btnRestart.TabIndex = 10;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Visible = false;
            btnRestart.Click += btnRestart_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(795, 530);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(67, 37);
            btnExit.TabIndex = 23;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(795, 490);
            btnReturn.Margin = new Padding(3, 4, 3, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(67, 37);
            btnReturn.TabIndex = 22;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(25, 64);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(50, 20);
            lblQuestion.TabIndex = 6;
            lblQuestion.Text = "label1";
            // 
            // triviaQuiz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(btnExit);
            Controls.Add(btnReturn);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private Label lblEnterQuestions;
        private TextBox txtNumQuestions;
        private Button btnStartQuiz;
        private Button btnRestart;
        private Button btnExit;
        private Button btnReturn;
        private Label lblQuestion;
    }
}