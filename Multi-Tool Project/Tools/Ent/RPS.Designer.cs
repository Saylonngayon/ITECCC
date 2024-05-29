namespace Multi_Tool_Project.Tools.Ent
{
    partial class RPS
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
            btnStart = new Button();
            pbPlayerChoice = new PictureBox();
            pbBotChoice = new PictureBox();
            lblPlayerScore = new Label();
            lblBotScore = new Label();
            ((System.ComponentModel.ISupportInitialize)pbPlayerChoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBotChoice).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(378, 201);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // pbPlayerChoice
            // 
            pbPlayerChoice.Image = Properties.Resources.question;
            pbPlayerChoice.Location = new Point(55, 42);
            pbPlayerChoice.Name = "pbPlayerChoice";
            pbPlayerChoice.Size = new Size(300, 300);
            pbPlayerChoice.TabIndex = 1;
            pbPlayerChoice.TabStop = false;
            pbPlayerChoice.Click += pbPlayerChoice_Click;
            // 
            // pbBotChoice
            // 
            pbBotChoice.Image = Properties.Resources.question;
            pbBotChoice.Location = new Point(488, 42);
            pbBotChoice.Name = "pbBotChoice";
            pbBotChoice.Size = new Size(300, 300);
            pbBotChoice.TabIndex = 2;
            pbBotChoice.TabStop = false;
            // 
            // lblPlayerScore
            // 
            lblPlayerScore.AutoSize = true;
            lblPlayerScore.Location = new Point(55, 345);
            lblPlayerScore.Name = "lblPlayerScore";
            lblPlayerScore.Size = new Size(38, 15);
            lblPlayerScore.TabIndex = 3;
            lblPlayerScore.Text = "label1";
            // 
            // lblBotScore
            // 
            lblBotScore.AutoSize = true;
            lblBotScore.Location = new Point(488, 345);
            lblBotScore.Name = "lblBotScore";
            lblBotScore.Size = new Size(38, 15);
            lblBotScore.TabIndex = 4;
            lblBotScore.Text = "label1";
            // 
            // RPS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblBotScore);
            Controls.Add(lblPlayerScore);
            Controls.Add(pbBotChoice);
            Controls.Add(pbPlayerChoice);
            Controls.Add(btnStart);
            Name = "RPS";
            Text = "RPS";
            Load += RPS_Load;
            ((System.ComponentModel.ISupportInitialize)pbPlayerChoice).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBotChoice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private PictureBox pbPlayerChoice;
        private PictureBox pbBotChoice;
        private Label lblPlayerScore;
        private Label lblBotScore;
    }
}