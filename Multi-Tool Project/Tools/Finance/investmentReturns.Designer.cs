namespace Multi_Tool_Project.Tools.Finance
{
    partial class investmentReturns
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            radioButtonFixedROI = new RadioButton();
            radioButtonCompoundInterest = new RadioButton();
            radioButtonDaily = new RadioButton();
            radioButtonMonthly = new RadioButton();
            radioButtonYearly = new RadioButton();
            textBoxRate = new TextBox();
            textBoxPrincipal = new TextBox();
            textBoxDays = new TextBox();
            textBoxMonths = new TextBox();
            textBoxYears = new TextBox();
            buttonCalculate = new Button();
            labelOutput = new Label();
            groupBoxInterestType = new GroupBox();
            groupBoxCompoundFrequency = new GroupBox();
            btnExit = new Button();
            btnReturn = new Button();
            groupBoxInterestType.SuspendLayout();
            groupBoxCompoundFrequency.SuspendLayout();
            SuspendLayout();
            // 
            // radioButtonFixedROI
            // 
            radioButtonFixedROI.AutoSize = true;
            radioButtonFixedROI.Location = new Point(6, 19);
            radioButtonFixedROI.Name = "radioButtonFixedROI";
            radioButtonFixedROI.Size = new Size(93, 24);
            radioButtonFixedROI.TabIndex = 0;
            radioButtonFixedROI.TabStop = true;
            radioButtonFixedROI.Text = "Fixed ROI";
            radioButtonFixedROI.UseVisualStyleBackColor = true;
            // 
            // radioButtonCompoundInterest
            // 
            radioButtonCompoundInterest.AutoSize = true;
            radioButtonCompoundInterest.Location = new Point(6, 42);
            radioButtonCompoundInterest.Name = "radioButtonCompoundInterest";
            radioButtonCompoundInterest.Size = new Size(157, 24);
            radioButtonCompoundInterest.TabIndex = 1;
            radioButtonCompoundInterest.TabStop = true;
            radioButtonCompoundInterest.Text = "Compound Interest";
            radioButtonCompoundInterest.UseVisualStyleBackColor = true;
            // 
            // radioButtonDaily
            // 
            radioButtonDaily.AutoSize = true;
            radioButtonDaily.Location = new Point(6, 19);
            radioButtonDaily.Name = "radioButtonDaily";
            radioButtonDaily.Size = new Size(64, 24);
            radioButtonDaily.TabIndex = 0;
            radioButtonDaily.TabStop = true;
            radioButtonDaily.Text = "Daily";
            radioButtonDaily.UseVisualStyleBackColor = true;
            // 
            // radioButtonMonthly
            // 
            radioButtonMonthly.AutoSize = true;
            radioButtonMonthly.Location = new Point(6, 42);
            radioButtonMonthly.Name = "radioButtonMonthly";
            radioButtonMonthly.Size = new Size(84, 24);
            radioButtonMonthly.TabIndex = 1;
            radioButtonMonthly.TabStop = true;
            radioButtonMonthly.Text = "Monthly";
            radioButtonMonthly.UseVisualStyleBackColor = true;
            // 
            // radioButtonYearly
            // 
            radioButtonYearly.AutoSize = true;
            radioButtonYearly.Location = new Point(6, 65);
            radioButtonYearly.Name = "radioButtonYearly";
            radioButtonYearly.Size = new Size(69, 24);
            radioButtonYearly.TabIndex = 2;
            radioButtonYearly.TabStop = true;
            radioButtonYearly.Text = "Yearly";
            radioButtonYearly.UseVisualStyleBackColor = true;
            // 
            // textBoxRate
            // 
            textBoxRate.Location = new Point(469, 144);
            textBoxRate.Name = "textBoxRate";
            textBoxRate.PlaceholderText = "Rate (%)";
            textBoxRate.Size = new Size(131, 27);
            textBoxRate.TabIndex = 2;
            // 
            // textBoxPrincipal
            // 
            textBoxPrincipal.Location = new Point(469, 170);
            textBoxPrincipal.Name = "textBoxPrincipal";
            textBoxPrincipal.PlaceholderText = "Principal Amount";
            textBoxPrincipal.Size = new Size(131, 27);
            textBoxPrincipal.TabIndex = 3;
            // 
            // textBoxDays
            // 
            textBoxDays.Location = new Point(469, 196);
            textBoxDays.Name = "textBoxDays";
            textBoxDays.PlaceholderText = "Days";
            textBoxDays.Size = new Size(131, 27);
            textBoxDays.TabIndex = 4;
            // 
            // textBoxMonths
            // 
            textBoxMonths.Location = new Point(469, 222);
            textBoxMonths.Name = "textBoxMonths";
            textBoxMonths.PlaceholderText = "Months";
            textBoxMonths.Size = new Size(131, 27);
            textBoxMonths.TabIndex = 5;
            // 
            // textBoxYears
            // 
            textBoxYears.Location = new Point(469, 248);
            textBoxYears.Name = "textBoxYears";
            textBoxYears.PlaceholderText = "Years";
            textBoxYears.Size = new Size(131, 27);
            textBoxYears.TabIndex = 6;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(478, 281);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(100, 33);
            buttonCalculate.TabIndex = 7;
            buttonCalculate.Text = "Calculate";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Location = new Point(478, 326);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(89, 20);
            labelOutput.TabIndex = 8;
            labelOutput.Text = "Total Value: ";
            labelOutput.Click += labelOutput_Click;
            // 
            // groupBoxInterestType
            // 
            groupBoxInterestType.Controls.Add(radioButtonFixedROI);
            groupBoxInterestType.Controls.Add(radioButtonCompoundInterest);
            groupBoxInterestType.Location = new Point(251, 126);
            groupBoxInterestType.Name = "groupBoxInterestType";
            groupBoxInterestType.Size = new Size(200, 75);
            groupBoxInterestType.TabIndex = 0;
            groupBoxInterestType.TabStop = false;
            groupBoxInterestType.Text = "Interest Type";
            // 
            // groupBoxCompoundFrequency
            // 
            groupBoxCompoundFrequency.Controls.Add(radioButtonDaily);
            groupBoxCompoundFrequency.Controls.Add(radioButtonMonthly);
            groupBoxCompoundFrequency.Controls.Add(radioButtonYearly);
            groupBoxCompoundFrequency.Location = new Point(251, 207);
            groupBoxCompoundFrequency.Name = "groupBoxCompoundFrequency";
            groupBoxCompoundFrequency.Size = new Size(200, 100);
            groupBoxCompoundFrequency.TabIndex = 1;
            groupBoxCompoundFrequency.TabStop = false;
            groupBoxCompoundFrequency.Text = "Compound Frequency";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(15, 587);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(67, 37);
            btnExit.TabIndex = 21;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(18, 542);
            btnReturn.Margin = new Padding(3, 4, 3, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(67, 37);
            btnReturn.TabIndex = 20;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // investmentReturns
            // 
            ClientSize = new Size(982, 653);
            Controls.Add(btnExit);
            Controls.Add(btnReturn);
            Controls.Add(labelOutput);
            Controls.Add(buttonCalculate);
            Controls.Add(textBoxYears);
            Controls.Add(textBoxMonths);
            Controls.Add(textBoxDays);
            Controls.Add(textBoxPrincipal);
            Controls.Add(textBoxRate);
            Controls.Add(groupBoxCompoundFrequency);
            Controls.Add(groupBoxInterestType);
            Name = "investmentReturns";
            Text = "Investment Returns Calculator";
            Load += investmentReturns_Load;
            groupBoxInterestType.ResumeLayout(false);
            groupBoxInterestType.PerformLayout();
            groupBoxCompoundFrequency.ResumeLayout(false);
            groupBoxCompoundFrequency.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonFixedROI;
        private System.Windows.Forms.RadioButton radioButtonCompoundInterest;
        private System.Windows.Forms.RadioButton radioButtonDaily;
        private System.Windows.Forms.RadioButton radioButtonMonthly;
        private System.Windows.Forms.RadioButton radioButtonYearly;
        private System.Windows.Forms.TextBox textBoxRate;
        private System.Windows.Forms.TextBox textBoxPrincipal;
        private System.Windows.Forms.TextBox textBoxDays;
        private System.Windows.Forms.TextBox textBoxMonths;
        private System.Windows.Forms.TextBox textBoxYears;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.GroupBox groupBoxInterestType;
        private System.Windows.Forms.GroupBox groupBoxCompoundFrequency;
        private Button btnExit;
        private Button btnReturn;
    }
}