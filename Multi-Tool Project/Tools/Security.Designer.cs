namespace Multi_Tool_Project.Tools
{
    partial class Security
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
            button1 = new Button();
            buttonCrpytography = new Button();
            btnExit = new Button();
            btnReturn = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(229, 72);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "PG";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonCrpytography
            // 
            buttonCrpytography.Location = new Point(229, 101);
            buttonCrpytography.Name = "buttonCrpytography";
            buttonCrpytography.Size = new Size(75, 23);
            buttonCrpytography.TabIndex = 1;
            buttonCrpytography.Text = "Cryptography";
            buttonCrpytography.UseVisualStyleBackColor = true;
            buttonCrpytography.Click += buttonCrpytography_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(139, 97);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(59, 28);
            btnExit.TabIndex = 15;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(139, 67);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(59, 28);
            btnReturn.TabIndex = 14;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // Security
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 202);
            Controls.Add(btnExit);
            Controls.Add(btnReturn);
            Controls.Add(buttonCrpytography);
            Controls.Add(button1);
            Name = "Security";
            Text = "Security";
            Load += Security_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button buttonCrpytography;
        private Button btnExit;
        private Button btnReturn;
    }
}