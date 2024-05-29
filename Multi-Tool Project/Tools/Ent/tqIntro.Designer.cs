namespace Multi_Tool_Project.Tools.Ent
{
    partial class tqIntro
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
            btnStartQuiz = new Button();
            txtNumQuestions = new TextBox();
            lblEnterQuestions = new Label();
            btnExit = new Button();
            btnReturn = new Button();
            SuspendLayout();
            // 
            // btnStartQuiz
            // 
            btnStartQuiz.Location = new Point(69, 148);
            btnStartQuiz.Margin = new Padding(3, 4, 3, 4);
            btnStartQuiz.Name = "btnStartQuiz";
            btnStartQuiz.Size = new Size(517, 380);
            btnStartQuiz.TabIndex = 12;
            btnStartQuiz.Text = "Start";
            btnStartQuiz.UseVisualStyleBackColor = true;
            // 
            // txtNumQuestions
            // 
            txtNumQuestions.Location = new Point(69, 77);
            txtNumQuestions.Margin = new Padding(3, 4, 3, 4);
            txtNumQuestions.Name = "txtNumQuestions";
            txtNumQuestions.Size = new Size(545, 27);
            txtNumQuestions.TabIndex = 11;
            // 
            // lblEnterQuestions
            // 
            lblEnterQuestions.AutoSize = true;
            lblEnterQuestions.Location = new Point(69, 53);
            lblEnterQuestions.Name = "lblEnterQuestions";
            lblEnterQuestions.Size = new Size(211, 20);
            lblEnterQuestions.TabIndex = 10;
            lblEnterQuestions.Text = "Enter the number of questions:";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(850, 563);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(67, 37);
            btnExit.TabIndex = 25;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(850, 523);
            btnReturn.Margin = new Padding(3, 4, 3, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(67, 37);
            btnReturn.TabIndex = 24;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            // 
            // tqIntro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(btnExit);
            Controls.Add(btnReturn);
            Controls.Add(btnStartQuiz);
            Controls.Add(txtNumQuestions);
            Controls.Add(lblEnterQuestions);
            Name = "tqIntro";
            Text = "tqIntro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStartQuiz;
        private TextBox txtNumQuestions;
        private Label lblEnterQuestions;
        private Button btnExit;
        private Button btnReturn;
    }
}