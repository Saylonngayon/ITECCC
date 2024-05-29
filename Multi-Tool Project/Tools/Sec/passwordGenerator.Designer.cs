namespace Multi_Tool_Project.Tools.Sec
{
    partial class passwordGenerator
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(passwordGenerator));
            labelLength = new Label();
            numericUpDownLength = new NumericUpDown();
            checkBoxIncludeSymbols = new CheckBox();
            buttonGenerate = new Button();
            textBoxPassword = new TextBox();
            btnExit = new Button();
            btnReturn = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLength).BeginInit();
            SuspendLayout();
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.BackColor = Color.Transparent;
            labelLength.Font = new Font("Algerian", 13.8F, FontStyle.Bold);
            labelLength.ForeColor = Color.White;
            labelLength.Location = new Point(220, 143);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(235, 25);
            labelLength.TabIndex = 0;
            labelLength.Text = "Password Length";
            labelLength.Click += labelLength_Click;
            // 
            // numericUpDownLength
            // 
            numericUpDownLength.BackColor = SystemColors.Window;
            numericUpDownLength.BorderStyle = BorderStyle.None;
            numericUpDownLength.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDownLength.Location = new Point(145, 140);
            numericUpDownLength.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDownLength.Name = "numericUpDownLength";
            numericUpDownLength.Size = new Size(67, 30);
            numericUpDownLength.TabIndex = 1;
            numericUpDownLength.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // checkBoxIncludeSymbols
            // 
            checkBoxIncludeSymbols.AutoSize = true;
            checkBoxIncludeSymbols.BackColor = Color.Transparent;
            checkBoxIncludeSymbols.Font = new Font("Algerian", 13.8F, FontStyle.Bold);
            checkBoxIncludeSymbols.ForeColor = Color.White;
            checkBoxIncludeSymbols.Location = new Point(141, 216);
            checkBoxIncludeSymbols.Name = "checkBoxIncludeSymbols";
            checkBoxIncludeSymbols.Size = new Size(279, 29);
            checkBoxIncludeSymbols.TabIndex = 2;
            checkBoxIncludeSymbols.Text = "     Include Symbols";
            checkBoxIncludeSymbols.UseVisualStyleBackColor = false;
            // 
            // buttonGenerate
            // 
            buttonGenerate.BackColor = Color.Transparent;
            buttonGenerate.FlatAppearance.BorderSize = 0;
            buttonGenerate.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonGenerate.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonGenerate.FlatStyle = FlatStyle.Flat;
            buttonGenerate.Font = new Font("Algerian", 13.8F, FontStyle.Bold);
            buttonGenerate.ForeColor = Color.White;
            buttonGenerate.Location = new Point(153, 286);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(279, 59);
            buttonGenerate.TabIndex = 3;
            buttonGenerate.Text = "Generate Password";
            buttonGenerate.UseVisualStyleBackColor = false;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.White;
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.Location = new Point(130, 405);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.ReadOnly = true;
            textBoxPassword.Size = new Size(319, 40);
            textBoxPassword.TabIndex = 4;
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
            btnExit.Location = new Point(808, 539);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(97, 54);
            btnExit.TabIndex = 13;
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
            btnReturn.Location = new Point(666, 536);
            btnReturn.Margin = new Padding(3, 4, 3, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(115, 62);
            btnReturn.TabIndex = 12;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gill Sans Ultra Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(520, 55);
            label1.Name = "label1";
            label1.Size = new Size(419, 170);
            label1.TabIndex = 14;
            label1.Text = "Password \r\nGenerator\r\n";
            // 
            // passwordGenerator
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(982, 653);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnReturn);
            Controls.Add(textBoxPassword);
            Controls.Add(buttonGenerate);
            Controls.Add(checkBoxIncludeSymbols);
            Controls.Add(numericUpDownLength);
            Controls.Add(labelLength);
            Name = "passwordGenerator";
            Text = "Password Generator";
            Load += passwordGenerator_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownLength).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.NumericUpDown numericUpDownLength;
        private System.Windows.Forms.CheckBox checkBoxIncludeSymbols;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.TextBox textBoxPassword;
        private Button btnExit;
        private Button btnReturn;
        private Label label1;
    }
}