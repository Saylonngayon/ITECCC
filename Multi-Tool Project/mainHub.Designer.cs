namespace Multi_Tool_Project
{
    partial class mainHub
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
            label1 = new Label();
            btnCalculator = new Button();
            btnFinance = new Button();
            btnSecurity = new Button();
            btnTDL = new Button();
            btnConverter = new Button();
            btnEntertainment = new Button();
            btnReturn = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(94, 9);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 0;
            label1.Text = "Main Hub";
            // 
            // btnCalculator
            // 
            btnCalculator.Location = new Point(28, 68);
            btnCalculator.Name = "btnCalculator";
            btnCalculator.Size = new Size(75, 23);
            btnCalculator.TabIndex = 1;
            btnCalculator.Text = "Calculator";
            btnCalculator.UseVisualStyleBackColor = true;
            btnCalculator.Click += btnCalculator_Click;
            // 
            // btnFinance
            // 
            btnFinance.Location = new Point(190, 68);
            btnFinance.Name = "btnFinance";
            btnFinance.Size = new Size(75, 23);
            btnFinance.TabIndex = 2;
            btnFinance.Text = "Finance";
            btnFinance.UseVisualStyleBackColor = true;
            btnFinance.Click += btnFinance_Click;
            // 
            // btnSecurity
            // 
            btnSecurity.Location = new Point(28, 97);
            btnSecurity.Name = "btnSecurity";
            btnSecurity.Size = new Size(75, 23);
            btnSecurity.TabIndex = 3;
            btnSecurity.Text = "Security";
            btnSecurity.UseVisualStyleBackColor = true;
            btnSecurity.Click += btnSecurity_Click;
            // 
            // btnTDL
            // 
            btnTDL.Location = new Point(109, 68);
            btnTDL.Name = "btnTDL";
            btnTDL.Size = new Size(75, 23);
            btnTDL.TabIndex = 4;
            btnTDL.Text = "To-Do List";
            btnTDL.UseVisualStyleBackColor = true;
            btnTDL.Click += btnTDL_Click;
            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(109, 97);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(75, 23);
            btnConverter.TabIndex = 5;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // btnEntertainment
            // 
            btnEntertainment.Location = new Point(190, 97);
            btnEntertainment.Name = "btnEntertainment";
            btnEntertainment.Size = new Size(75, 23);
            btnEntertainment.TabIndex = 6;
            btnEntertainment.Text = "Entertainment";
            btnEntertainment.UseVisualStyleBackColor = true;
            btnEntertainment.Click += btnEntertainment_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(206, 126);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(59, 41);
            btnReturn.TabIndex = 10;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(141, 126);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(59, 41);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // mainHub
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 181);
            Controls.Add(btnExit);
            Controls.Add(btnReturn);
            Controls.Add(btnEntertainment);
            Controls.Add(btnConverter);
            Controls.Add(btnTDL);
            Controls.Add(btnSecurity);
            Controls.Add(btnFinance);
            Controls.Add(btnCalculator);
            Controls.Add(label1);
            Name = "mainHub";
            Text = "mainHub";
            Load += mainHub_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCalculator;
        private Button btnFinance;
        private Button btnSecurity;
        private Button btnTDL;
        private Button btnConverter;
        private Button btnEntertainment;
        private Button btnReturn;
        private Button btnExit;
    }
}