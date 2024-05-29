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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entertainment));
            btnRPS = new Button();
            btnTQ = new Button();
            btnExit = new Button();
            btnReturn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnRPS
            // 
            btnRPS.BackColor = Color.Transparent;
            btnRPS.FlatAppearance.BorderSize = 0;
            btnRPS.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnRPS.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnRPS.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnRPS.FlatStyle = FlatStyle.Flat;
            btnRPS.Font = new Font("Algerian", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRPS.ForeColor = Color.White;
            btnRPS.Location = new Point(393, 321);
            btnRPS.Margin = new Padding(3, 4, 3, 4);
            btnRPS.Name = "btnRPS";
            btnRPS.Size = new Size(213, 57);
            btnRPS.TabIndex = 0;
            btnRPS.Text = "RockPaperScissor";
            btnRPS.UseVisualStyleBackColor = false;
            btnRPS.Click += btnRPS_Click;
            // 
            // btnTQ
            // 
            btnTQ.BackColor = Color.Transparent;
            btnTQ.FlatAppearance.BorderSize = 0;
            btnTQ.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnTQ.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTQ.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnTQ.FlatStyle = FlatStyle.Flat;
            btnTQ.Font = new Font("Algerian", 13.8F, FontStyle.Bold);
            btnTQ.ForeColor = Color.White;
            btnTQ.Location = new Point(393, 230);
            btnTQ.Margin = new Padding(3, 4, 3, 4);
            btnTQ.Name = "btnTQ";
            btnTQ.Size = new Size(213, 52);
            btnTQ.TabIndex = 1;
            btnTQ.Text = "Trivia Quiz";
            btnTQ.UseVisualStyleBackColor = false;
            btnTQ.Click += btnTQ_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnExit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnExit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Algerian", 13.8F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(854, 555);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(97, 54);
            btnExit.TabIndex = 17;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click_1;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.Transparent;
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnReturn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnReturn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturn.ForeColor = Color.White;
            btnReturn.Location = new Point(843, 471);
            btnReturn.Margin = new Padding(3, 4, 3, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(115, 62);
            btnReturn.TabIndex = 16;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gill Sans Ultra Bold", 55.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(50, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(901, 129);
            label1.TabIndex = 18;
            label1.Text = "Entertainment\r\n";
            // 
            // Entertainment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(982, 653);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnReturn);
            Controls.Add(btnTQ);
            Controls.Add(btnRPS);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Entertainment";
            Text = "Entertainment";
            Load += Entertainment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRPS;
        private Button btnTQ;
        private Button btnExit;
        private Button btnReturn;
        private Label label1;
    }
}