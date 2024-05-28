namespace Multi_Tool_Project.Tools
{
    partial class Converter
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
            convertButton = new Button();
            comboBoxUnitTo = new ComboBox();
            comboBoxUnitFrom = new ComboBox();
            textBoxInput = new TextBox();
            comboBoxUnitType = new ComboBox();
            textBoxOutput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnExit = new Button();
            btnReturn = new Button();
            SuspendLayout();
            // 
            // convertButton
            // 
            convertButton.Location = new Point(187, 48);
            convertButton.Margin = new Padding(3, 4, 3, 4);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(138, 31);
            convertButton.TabIndex = 0;
            convertButton.Text = "Convert";
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += convertButton_Click;
            // 
            // comboBoxUnitTo
            // 
            comboBoxUnitTo.FormattingEnabled = true;
            comboBoxUnitTo.Location = new Point(187, 117);
            comboBoxUnitTo.Margin = new Padding(3, 4, 3, 4);
            comboBoxUnitTo.Name = "comboBoxUnitTo";
            comboBoxUnitTo.Size = new Size(138, 28);
            comboBoxUnitTo.TabIndex = 1;
            // 
            // comboBoxUnitFrom
            // 
            comboBoxUnitFrom.FormattingEnabled = true;
            comboBoxUnitFrom.Location = new Point(14, 117);
            comboBoxUnitFrom.Margin = new Padding(3, 4, 3, 4);
            comboBoxUnitFrom.Name = "comboBoxUnitFrom";
            comboBoxUnitFrom.Size = new Size(138, 28);
            comboBoxUnitFrom.TabIndex = 2;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(14, 187);
            textBoxInput.Margin = new Padding(3, 4, 3, 4);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(138, 27);
            textBoxInput.TabIndex = 3;
            textBoxInput.TextChanged += textBoxInput_TextChanged;
            // 
            // comboBoxUnitType
            // 
            comboBoxUnitType.FormattingEnabled = true;
            comboBoxUnitType.Location = new Point(14, 48);
            comboBoxUnitType.Margin = new Padding(3, 4, 3, 4);
            comboBoxUnitType.Name = "comboBoxUnitType";
            comboBoxUnitType.Size = new Size(138, 28);
            comboBoxUnitType.TabIndex = 5;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(187, 187);
            textBoxOutput.Margin = new Padding(3, 4, 3, 4);
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.Size = new Size(138, 27);
            textBoxOutput.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 7;
            label1.Text = "Select Unit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 93);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 8;
            label2.Text = "From:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(187, 93);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 9;
            label3.Text = "To:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(187, 163);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 10;
            label4.Text = "Output:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 163);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 11;
            label5.Text = "Input:";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(47, 337);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(67, 37);
            btnExit.TabIndex = 19;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += this.btnExit_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(47, 297);
            btnReturn.Margin = new Padding(3, 4, 3, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(67, 37);
            btnReturn.TabIndex = 18;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // Converter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnExit);
            Controls.Add(btnReturn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxOutput);
            Controls.Add(comboBoxUnitType);
            Controls.Add(textBoxInput);
            Controls.Add(comboBoxUnitFrom);
            Controls.Add(comboBoxUnitTo);
            Controls.Add(convertButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Converter";
            Text = "Converter";
            Load += Converter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button convertButton;
        private ComboBox comboBoxUnitTo;
        private ComboBox comboBoxUnitFrom;
        private TextBox textBoxInput;
        private ComboBox comboBoxUnitType;
        private TextBox textBoxOutput;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnExit;
        private Button btnReturn;
    }
}