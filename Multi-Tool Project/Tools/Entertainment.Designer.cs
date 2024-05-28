namespace Multi_Tool_Project.Tools
{
    partial class Entertainment
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
            btnRPS = new Button();
            btnTQ = new Button();
            SuspendLayout();
            // 
            // btnRPS
            // 
            btnRPS.Location = new Point(367, 136);
            btnRPS.Name = "btnRPS";
            btnRPS.Size = new Size(75, 23);
            btnRPS.TabIndex = 0;
            btnRPS.Text = "RockPaperScissor";
            btnRPS.UseVisualStyleBackColor = true;
            btnRPS.Click += btnRPS_Click;
            // 
            // btnTQ
            // 
            btnTQ.Location = new Point(625, 132);
            btnTQ.Name = "btnTQ";
            btnTQ.Size = new Size(75, 23);
            btnTQ.TabIndex = 1;
            btnTQ.Text = "Trivia Quiz";
            btnTQ.UseVisualStyleBackColor = true;
            btnTQ.Click += btnTQ_Click;
            // 
            // Entertainment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTQ);
            Controls.Add(btnRPS);
            Name = "Entertainment";
            Text = "Entertainment";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRPS;
        private Button btnTQ;
    }
}