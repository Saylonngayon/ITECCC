namespace Multi_Tool_Project.Tools.Sec
{
    partial class Cryptography
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cryptography));
            textBoxInput = new TextBox();
            textBoxKey = new TextBox();
            buttonEncrypt = new Button();
            buttonDecrypt = new Button();
            textBoxOutput = new TextBox();
            labelInput = new Label();
            labelKey = new Label();
            labelOutput = new Label();
            btnExit = new Button();
            btnReturn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxInput
            // 
            textBoxInput.BackColor = Color.White;
            textBoxInput.BorderStyle = BorderStyle.None;
            textBoxInput.Location = new Point(94, 70);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(433, 124);
            textBoxInput.TabIndex = 0;
            // 
            // textBoxKey
            // 
            textBoxKey.BorderStyle = BorderStyle.None;
            textBoxKey.Font = new Font("Segoe UI", 14.2F);
            textBoxKey.Location = new Point(94, 289);
            textBoxKey.Name = "textBoxKey";
            textBoxKey.Size = new Size(433, 32);
            textBoxKey.TabIndex = 1;
            // 
            // buttonEncrypt
            // 
            buttonEncrypt.BackColor = Color.Transparent;
            buttonEncrypt.FlatAppearance.BorderSize = 0;
            buttonEncrypt.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonEncrypt.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonEncrypt.FlatStyle = FlatStyle.Flat;
            buttonEncrypt.Font = new Font("Algerian", 13.8F, FontStyle.Bold);
            buttonEncrypt.ForeColor = Color.White;
            buttonEncrypt.Location = new Point(118, 386);
            buttonEncrypt.Name = "buttonEncrypt";
            buttonEncrypt.Size = new Size(183, 44);
            buttonEncrypt.TabIndex = 2;
            buttonEncrypt.Text = "Encrypt";
            buttonEncrypt.UseVisualStyleBackColor = false;
            buttonEncrypt.Click += buttonEncrypt_Click;
            // 
            // buttonDecrypt
            // 
            buttonDecrypt.BackColor = Color.Transparent;
            buttonDecrypt.FlatAppearance.BorderSize = 0;
            buttonDecrypt.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonDecrypt.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonDecrypt.FlatStyle = FlatStyle.Flat;
            buttonDecrypt.Font = new Font("Algerian", 13.8F, FontStyle.Bold);
            buttonDecrypt.ForeColor = Color.White;
            buttonDecrypt.Location = new Point(331, 386);
            buttonDecrypt.Name = "buttonDecrypt";
            buttonDecrypt.Size = new Size(173, 44);
            buttonDecrypt.TabIndex = 3;
            buttonDecrypt.Text = "Decrypt";
            buttonDecrypt.UseVisualStyleBackColor = false;
            buttonDecrypt.Click += buttonDecrypt_Click;
            // 
            // textBoxOutput
            // 
            textBoxOutput.BackColor = Color.White;
            textBoxOutput.BorderStyle = BorderStyle.None;
            textBoxOutput.Location = new Point(94, 498);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.Size = new Size(433, 124);
            textBoxOutput.TabIndex = 4;
            // 
            // labelInput
            // 
            labelInput.AutoSize = true;
            labelInput.BackColor = Color.Transparent;
            labelInput.FlatStyle = FlatStyle.Flat;
            labelInput.Font = new Font("Algerian", 10.2F, FontStyle.Bold);
            labelInput.Location = new Point(94, 56);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(65, 19);
            labelInput.TabIndex = 5;
            labelInput.Text = "Input:";
            labelInput.Click += labelInput_Click;
            // 
            // labelKey
            // 
            labelKey.AutoSize = true;
            labelKey.BackColor = Color.Transparent;
            labelKey.FlatStyle = FlatStyle.Flat;
            labelKey.Font = new Font("Algerian", 10.2F, FontStyle.Bold);
            labelKey.Location = new Point(96, 271);
            labelKey.Name = "labelKey";
            labelKey.Size = new Size(52, 19);
            labelKey.TabIndex = 6;
            labelKey.Text = "Key:";
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.BackColor = Color.Transparent;
            labelOutput.FlatStyle = FlatStyle.Flat;
            labelOutput.Font = new Font("Algerian", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOutput.Location = new Point(94, 478);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(82, 19);
            labelOutput.TabIndex = 7;
            labelOutput.Text = "Output:";
            labelOutput.Click += labelOutput_Click;
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
            btnExit.Location = new Point(856, 578);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(97, 54);
            btnExit.TabIndex = 15;
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
            btnReturn.Location = new Point(847, 487);
            btnReturn.Margin = new Padding(3, 4, 3, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(115, 62);
            btnReturn.TabIndex = 14;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gill Sans Ultra Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(533, 56);
            label1.Name = "label1";
            label1.Size = new Size(457, 134);
            label1.TabIndex = 16;
            label1.Text = "Cryptography \r\n        App\r\n";
            // 
            // Cryptography
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(982, 653);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnReturn);
            Controls.Add(labelOutput);
            Controls.Add(labelKey);
            Controls.Add(labelInput);
            Controls.Add(textBoxOutput);
            Controls.Add(buttonDecrypt);
            Controls.Add(buttonEncrypt);
            Controls.Add(textBoxKey);
            Controls.Add(textBoxInput);
            Name = "Cryptography";
            Text = "Cryptography App";
            Load += Cryptography_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Label labelOutput;
        private Button btnExit;
        private Button btnReturn;
        private Label label1;
    }
}