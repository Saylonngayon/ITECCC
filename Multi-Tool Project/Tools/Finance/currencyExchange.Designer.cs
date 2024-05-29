namespace Multi_Tool_Project.Tools.Finance
{
    partial class currencyExchange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(currencyExchange));
            btnConvert = new Button();
            cmbTargetCurrency = new ComboBox();
            cmbBaseCurrency = new ComboBox();
            txtAmount = new TextBox();
            lblResult = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnExit = new Button();
            btnReturn = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnConvert
            // 
            btnConvert.BackColor = Color.Transparent;
            btnConvert.FlatAppearance.BorderSize = 0;
            btnConvert.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnConvert.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnConvert.FlatStyle = FlatStyle.Flat;
            btnConvert.Font = new Font("Algerian", 13.8F, FontStyle.Bold);
            btnConvert.ForeColor = Color.White;
            btnConvert.Location = new Point(463, 352);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(206, 52);
            btnConvert.TabIndex = 0;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = false;
            btnConvert.Click += btnConvert_Click;
            // 
            // cmbTargetCurrency
            // 
            cmbTargetCurrency.FlatStyle = FlatStyle.Flat;
            cmbTargetCurrency.FormattingEnabled = true;
            cmbTargetCurrency.Location = new Point(408, 276);
            cmbTargetCurrency.Name = "cmbTargetCurrency";
            cmbTargetCurrency.Size = new Size(226, 28);
            cmbTargetCurrency.TabIndex = 1;
            // 
            // cmbBaseCurrency
            // 
            cmbBaseCurrency.FlatStyle = FlatStyle.Flat;
            cmbBaseCurrency.FormattingEnabled = true;
            cmbBaseCurrency.Location = new Point(114, 276);
            cmbBaseCurrency.Name = "cmbBaseCurrency";
            cmbBaseCurrency.Size = new Size(226, 28);
            cmbBaseCurrency.TabIndex = 2;
            // 
            // txtAmount
            // 
            txtAmount.BorderStyle = BorderStyle.None;
            txtAmount.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAmount.Location = new Point(114, 164);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(424, 36);
            txtAmount.TabIndex = 3;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.Transparent;
            lblResult.FlatStyle = FlatStyle.Flat;
            lblResult.Font = new Font("Algerian", 13.8F, FontStyle.Bold);
            lblResult.Location = new Point(114, 368);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(94, 25);
            lblResult.TabIndex = 4;
            lblResult.Text = "Total:";
            lblResult.Click += lblResult_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Algerian", 13.8F, FontStyle.Bold);
            label1.Location = new Point(114, 251);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 5;
            label1.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Algerian", 13.8F, FontStyle.Bold);
            label2.Location = new Point(408, 251);
            label2.Name = "label2";
            label2.Size = new Size(41, 25);
            label2.TabIndex = 6;
            label2.Text = "To";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Algerian", 13.8F, FontStyle.Bold);
            label3.Location = new Point(114, 141);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 7;
            label3.Text = "Amount";
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
            btnExit.Location = new Point(203, 551);
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
            btnReturn.Location = new Point(63, 547);
            btnReturn.Margin = new Padding(3, 4, 3, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(115, 62);
            btnReturn.TabIndex = 14;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Gill Sans Ultra Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(73, 29);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(764, 85);
            label4.TabIndex = 16;
            label4.Text = "Currency Exchange";
            // 
            // currencyExchange
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(982, 653);
            Controls.Add(label4);
            Controls.Add(btnExit);
            Controls.Add(btnReturn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblResult);
            Controls.Add(txtAmount);
            Controls.Add(cmbBaseCurrency);
            Controls.Add(cmbTargetCurrency);
            Controls.Add(btnConvert);
            MaximizeBox = false;
            Name = "currencyExchange";
            Text = "Currency Exchange";
            Load += currencyExchange_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConvert;
        private ComboBox cmbTargetCurrency;
        private ComboBox cmbBaseCurrency;
        private TextBox txtAmount;
        private Label lblResult;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnExit;
        private Button btnReturn;
        private Label label4;
    }
}