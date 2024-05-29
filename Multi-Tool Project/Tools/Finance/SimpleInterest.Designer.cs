namespace Multi_Tool_Project.Tools.Finance
{
    partial class SimpleInterest
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleInterest));
            buttonCalculate = new Button();
            radioButtonMonthly = new RadioButton();
            radioButtonYearly = new RadioButton();
            radioButtonDaily = new RadioButton();
            textBoxRate = new TextBox();
            textBoxDeposit = new TextBox();
            label1 = new Label();
            label2 = new Label();
            labelOutput = new Label();
            label4 = new Label();
            textBoxDays = new TextBox();
            textBoxMonths = new TextBox();
            textBoxYears = new TextBox();
            btnExit = new Button();
            btnReturn = new Button();
            SuspendLayout();
            // 
            // buttonCalculate
            // 
            buttonCalculate.BackColor = Color.Transparent;
            buttonCalculate.FlatAppearance.BorderSize = 0;
            buttonCalculate.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonCalculate.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonCalculate.FlatStyle = FlatStyle.Flat;
            buttonCalculate.Font = new Font("Algerian", 13.8F, FontStyle.Bold);
            buttonCalculate.ForeColor = Color.White;
            buttonCalculate.Location = new Point(116, 583);
            buttonCalculate.Margin = new Padding(3, 4, 3, 4);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(195, 43);
            buttonCalculate.TabIndex = 14;
            buttonCalculate.Text = "Calculate";
            buttonCalculate.UseVisualStyleBackColor = false;
            buttonCalculate.Click += btnConvert_Click;
            // 
            // radioButtonMonthly
            // 
            radioButtonMonthly.AutoSize = true;
            radioButtonMonthly.BackColor = Color.Transparent;
            radioButtonMonthly.FlatStyle = FlatStyle.Popup;
            radioButtonMonthly.Font = new Font("Algerian", 13.8F, FontStyle.Bold);
            radioButtonMonthly.ForeColor = Color.White;
            radioButtonMonthly.Location = new Point(304, 76);
            radioButtonMonthly.Margin = new Padding(3, 4, 3, 4);
            radioButtonMonthly.Name = "radioButtonMonthly";
            radioButtonMonthly.Size = new Size(153, 29);
            radioButtonMonthly.TabIndex = 15;
            radioButtonMonthly.TabStop = true;
            radioButtonMonthly.Text = "  Monthly\r\n";
            radioButtonMonthly.UseVisualStyleBackColor = false;
            // 
            // radioButtonYearly
            // 
            radioButtonYearly.AutoSize = true;
            radioButtonYearly.BackColor = Color.Transparent;
            radioButtonYearly.FlatStyle = FlatStyle.Popup;
            radioButtonYearly.Font = new Font("Algerian", 13.8F, FontStyle.Bold);
            radioButtonYearly.ForeColor = Color.White;
            radioButtonYearly.Location = new Point(517, 76);
            radioButtonYearly.Margin = new Padding(3, 4, 3, 4);
            radioButtonYearly.Name = "radioButtonYearly";
            radioButtonYearly.Size = new Size(141, 29);
            radioButtonYearly.TabIndex = 16;
            radioButtonYearly.TabStop = true;
            radioButtonYearly.Text = "  Yearly";
            radioButtonYearly.UseVisualStyleBackColor = false;
            // 
            // radioButtonDaily
            // 
            radioButtonDaily.AutoSize = true;
            radioButtonDaily.BackColor = Color.Transparent;
            radioButtonDaily.FlatStyle = FlatStyle.Popup;
            radioButtonDaily.Font = new Font("Algerian", 13.8F, FontStyle.Bold);
            radioButtonDaily.ForeColor = Color.White;
            radioButtonDaily.Location = new Point(91, 76);
            radioButtonDaily.Margin = new Padding(3, 4, 3, 4);
            radioButtonDaily.Name = "radioButtonDaily";
            radioButtonDaily.Size = new Size(117, 29);
            radioButtonDaily.TabIndex = 17;
            radioButtonDaily.TabStop = true;
            radioButtonDaily.Text = "  Daily";
            radioButtonDaily.UseVisualStyleBackColor = false;
            // 
            // textBoxRate
            // 
            textBoxRate.BorderStyle = BorderStyle.None;
            textBoxRate.Font = new Font("Segoe UI", 16F);
            textBoxRate.Location = new Point(361, 153);
            textBoxRate.Margin = new Padding(3, 4, 3, 4);
            textBoxRate.Name = "textBoxRate";
            textBoxRate.Size = new Size(377, 36);
            textBoxRate.TabIndex = 18;
            // 
            // textBoxDeposit
            // 
            textBoxDeposit.BorderStyle = BorderStyle.None;
            textBoxDeposit.Font = new Font("Segoe UI", 16F);
            textBoxDeposit.Location = new Point(361, 237);
            textBoxDeposit.Margin = new Padding(3, 4, 3, 4);
            textBoxDeposit.Name = "textBoxDeposit";
            textBoxDeposit.Size = new Size(377, 36);
            textBoxDeposit.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Algerian", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(146, 160);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 20;
            label1.Text = "Rate(%):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Algerian", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(100, 244);
            label2.Name = "label2";
            label2.Size = new Size(217, 25);
            label2.TabIndex = 21;
            label2.Text = "Deposit Amount:";
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.BackColor = Color.Transparent;
            labelOutput.FlatStyle = FlatStyle.Flat;
            labelOutput.Font = new Font("Algerian", 13.8F, FontStyle.Bold);
            labelOutput.Location = new Point(361, 592);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(94, 25);
            labelOutput.TabIndex = 22;
            labelOutput.Text = "Total:";
            labelOutput.Click += labelOutput_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Gill Sans Ultra Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(66, 9);
            label4.Name = "label4";
            label4.Size = new Size(551, 48);
            label4.TabIndex = 26;
            label4.Text = "Interest Calculation Type";
            // 
            // textBoxDays
            // 
            textBoxDays.BorderStyle = BorderStyle.None;
            textBoxDays.Font = new Font("Segoe UI", 16F);
            textBoxDays.Location = new Point(361, 323);
            textBoxDays.Margin = new Padding(3, 4, 3, 4);
            textBoxDays.Name = "textBoxDays";
            textBoxDays.PlaceholderText = "Days";
            textBoxDays.Size = new Size(377, 36);
            textBoxDays.TabIndex = 31;
            textBoxDays.TextChanged += textBoxDays_TextChanged;
            // 
            // textBoxMonths
            // 
            textBoxMonths.BorderStyle = BorderStyle.None;
            textBoxMonths.Font = new Font("Segoe UI", 16F);
            textBoxMonths.Location = new Point(361, 411);
            textBoxMonths.Margin = new Padding(3, 4, 3, 4);
            textBoxMonths.Name = "textBoxMonths";
            textBoxMonths.PlaceholderText = "Months";
            textBoxMonths.Size = new Size(377, 36);
            textBoxMonths.TabIndex = 32;
            // 
            // textBoxYears
            // 
            textBoxYears.BorderStyle = BorderStyle.None;
            textBoxYears.Font = new Font("Segoe UI", 16F);
            textBoxYears.Location = new Point(361, 493);
            textBoxYears.Margin = new Padding(3, 4, 3, 4);
            textBoxYears.Name = "textBoxYears";
            textBoxYears.PlaceholderText = "Years";
            textBoxYears.Size = new Size(377, 36);
            textBoxYears.TabIndex = 33;
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
            btnExit.Location = new Point(854, 542);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(97, 54);
            btnExit.TabIndex = 35;
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
            btnReturn.Location = new Point(842, 452);
            btnReturn.Margin = new Padding(3, 4, 3, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(115, 62);
            btnReturn.TabIndex = 34;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click_1;
            // 
            // SimpleInterest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(982, 653);
            Controls.Add(btnExit);
            Controls.Add(btnReturn);
            Controls.Add(textBoxYears);
            Controls.Add(textBoxMonths);
            Controls.Add(textBoxDays);
            Controls.Add(label4);
            Controls.Add(labelOutput);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxDeposit);
            Controls.Add(textBoxRate);
            Controls.Add(radioButtonDaily);
            Controls.Add(radioButtonYearly);
            Controls.Add(radioButtonMonthly);
            Controls.Add(buttonCalculate);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "SimpleInterest";
            Text = "SimpleInterest";
            Load += SimpleInterest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonCalculate;
        private RadioButton radioButtonMonthly;
        private RadioButton radioButtonYearly;
        private RadioButton radioButtonDaily;
        private TextBox textBoxRate;
        private TextBox textBoxDeposit;
        private Label label1;
        private Label label2;
        private Label labelOutput;
        private Label label4;
        private TextBox textBoxDays;
        private TextBox textBoxMonths;
        private TextBox textBoxYears;
        private Button btnExit;
        private Button btnReturn;
    }
}