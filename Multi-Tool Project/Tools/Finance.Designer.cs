namespace Multi_Tool_Project.Tools
{
    partial class FinanceTool
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
            btnsimpleInterest = new Button();
            btninvestmentReturns = new Button();
            btncurrencyExchange = new Button();
            btnExit = new Button();
            btnReturn = new Button();
            SuspendLayout();
            // 
            // btnsimpleInterest
            // 
            btnsimpleInterest.Location = new Point(31, 98);
            btnsimpleInterest.Name = "btnsimpleInterest";
            btnsimpleInterest.Size = new Size(75, 23);
            btnsimpleInterest.TabIndex = 0;
            btnsimpleInterest.Text = "Simple Interest";
            btnsimpleInterest.UseVisualStyleBackColor = true;
            btnsimpleInterest.Click += btnsimpleInterest_Click;
            // 
            // btninvestmentReturns
            // 
            btninvestmentReturns.Location = new Point(31, 156);
            btninvestmentReturns.Name = "btninvestmentReturns";
            btninvestmentReturns.Size = new Size(75, 23);
            btninvestmentReturns.TabIndex = 2;
            btninvestmentReturns.Text = "Investment Returns";
            btninvestmentReturns.UseVisualStyleBackColor = true;
            btninvestmentReturns.Click += btninvestmentReturns_Click;
            // 
            // btncurrencyExchange
            // 
            btncurrencyExchange.Location = new Point(31, 185);
            btncurrencyExchange.Name = "btncurrencyExchange";
            btncurrencyExchange.Size = new Size(75, 23);
            btncurrencyExchange.TabIndex = 3;
            btncurrencyExchange.Text = "Currency Exchange";
            btncurrencyExchange.UseVisualStyleBackColor = true;
            btncurrencyExchange.Click += btncurrencyExchange_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(250, 221);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(59, 28);
            btnExit.TabIndex = 17;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(250, 191);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(59, 28);
            btnReturn.TabIndex = 16;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // FinanceTool
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 440);
            Controls.Add(btnExit);
            Controls.Add(btnReturn);
            Controls.Add(btncurrencyExchange);
            Controls.Add(btninvestmentReturns);
            Controls.Add(btnsimpleInterest);
            Name = "FinanceTool";
            Text = "Finance";
            Load += FinanceTool_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnsimpleInterest;
        private Button btninvestmentReturns;
        private Button btncurrencyExchange;
        private Button btnExit;
        private Button btnReturn;
    }
}