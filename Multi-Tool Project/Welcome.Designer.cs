namespace Multi_Tool_Project
{
    partial class Welcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            btnProceed = new Button();
            label1 = new Label();
            btnCredits = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnProceed
            // 
            btnProceed.BackColor = Color.Transparent;
            btnProceed.FlatAppearance.BorderSize = 0;
            btnProceed.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnProceed.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnProceed.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnProceed.FlatStyle = FlatStyle.Flat;
            btnProceed.Font = new Font("Algerian", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProceed.ForeColor = Color.Transparent;
            btnProceed.Location = new Point(172, 277);
            btnProceed.Margin = new Padding(4);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(287, 71);
            btnProceed.TabIndex = 0;
            btnProceed.Text = "Proceed";
            btnProceed.UseVisualStyleBackColor = false;
            btnProceed.Click += btnProceed_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gill Sans Ultra Bold", 55.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(92, 53);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(787, 129);
            label1.TabIndex = 1;
            label1.Text = "TOOLGETHER";
            label1.Click += label1_Click;
            // 
            // btnCredits
            // 
            btnCredits.BackColor = Color.Transparent;
            btnCredits.FlatAppearance.BorderSize = 0;
            btnCredits.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnCredits.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCredits.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCredits.FlatStyle = FlatStyle.Flat;
            btnCredits.Font = new Font("Algerian", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCredits.ForeColor = Color.Transparent;
            btnCredits.Location = new Point(172, 391);
            btnCredits.Margin = new Padding(4);
            btnCredits.Name = "btnCredits";
            btnCredits.Size = new Size(287, 72);
            btnCredits.TabIndex = 2;
            btnCredits.Text = "Credits";
            btnCredits.UseVisualStyleBackColor = false;
            btnCredits.Click += btnCredits_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnExit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnExit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Algerian", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Transparent;
            btnExit.Location = new Point(172, 509);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(287, 70);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(4, 4, 4);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(982, 653);
            Controls.Add(btnExit);
            Controls.Add(btnCredits);
            Controls.Add(label1);
            Controls.Add(btnProceed);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Welcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TOOLGETHER";
            Load += Welcome_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProceed;
        private Label label1;
        private Button btnCredits;
        private Button btnExit;
    }
}
