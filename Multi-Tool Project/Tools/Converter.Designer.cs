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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Converter));
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
            label6 = new Label();
            SuspendLayout();
            // 
            // convertButton
            // 
            convertButton.BackColor = Color.Transparent;
            convertButton.FlatAppearance.BorderSize = 0;
            convertButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            convertButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            convertButton.FlatStyle = FlatStyle.Flat;
            convertButton.Font = new Font("Algerian", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            convertButton.ForeColor = Color.White;
            convertButton.Location = new Point(156, 341);
            convertButton.Margin = new Padding(3, 4, 3, 4);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(338, 51);
            convertButton.TabIndex = 0;
            convertButton.Text = "Convert";
            convertButton.UseVisualStyleBackColor = false;
            convertButton.Click += convertButton_Click;
            // 
            // comboBoxUnitTo
            // 
            comboBoxUnitTo.FormattingEnabled = true;
            comboBoxUnitTo.Location = new Point(349, 263);
            comboBoxUnitTo.Margin = new Padding(3, 4, 3, 4);
            comboBoxUnitTo.Name = "comboBoxUnitTo";
            comboBoxUnitTo.Size = new Size(138, 28);
            comboBoxUnitTo.TabIndex = 1;
            // 
            // comboBoxUnitFrom
            // 
            comboBoxUnitFrom.FormattingEnabled = true;
            comboBoxUnitFrom.Location = new Point(349, 178);
            comboBoxUnitFrom.Margin = new Padding(3, 4, 3, 4);
            comboBoxUnitFrom.Name = "comboBoxUnitFrom";
            comboBoxUnitFrom.Size = new Size(138, 28);
            comboBoxUnitFrom.TabIndex = 2;
            // 
            // textBoxInput
            // 
            textBoxInput.BorderStyle = BorderStyle.None;
            textBoxInput.Font = new Font("Segoe UI", 13.8F);
            textBoxInput.Location = new Point(186, 89);
            textBoxInput.Margin = new Padding(3, 4, 3, 4);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(281, 31);
            textBoxInput.TabIndex = 3;
            textBoxInput.TextChanged += textBoxInput_TextChanged;
            // 
            // comboBoxUnitType
            // 
            comboBoxUnitType.FormattingEnabled = true;
            comboBoxUnitType.Location = new Point(164, 177);
            comboBoxUnitType.Margin = new Padding(3, 4, 3, 4);
            comboBoxUnitType.Name = "comboBoxUnitType";
            comboBoxUnitType.Size = new Size(138, 28);
            comboBoxUnitType.TabIndex = 5;
            comboBoxUnitType.SelectedIndexChanged += comboBoxUnitType_SelectedIndexChanged_1;
            // 
            // textBoxOutput
            // 
            textBoxOutput.BorderStyle = BorderStyle.None;
            textBoxOutput.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxOutput.Location = new Point(186, 432);
            textBoxOutput.Margin = new Padding(3, 4, 3, 4);
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.Size = new Size(281, 31);
            textBoxOutput.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Algerian", 10.2F, FontStyle.Bold);
            label1.Location = new Point(163, 149);
            label1.Name = "label1";
            label1.Size = new Size(119, 19);
            label1.TabIndex = 7;
            label1.Text = "Select Unit";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Algerian", 10.2F, FontStyle.Bold);
            label2.Location = new Point(347, 148);
            label2.Name = "label2";
            label2.Size = new Size(62, 19);
            label2.TabIndex = 8;
            label2.Text = "From:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Algerian", 10.2F, FontStyle.Bold);
            label3.Location = new Point(347, 235);
            label3.Name = "label3";
            label3.Size = new Size(38, 19);
            label3.TabIndex = 9;
            label3.Text = "To:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Algerian", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(184, 417);
            label4.Name = "label4";
            label4.Size = new Size(82, 19);
            label4.TabIndex = 10;
            label4.Text = "Output:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Algerian", 10.2F, FontStyle.Bold);
            label5.Location = new Point(186, 74);
            label5.Name = "label5";
            label5.Size = new Size(65, 19);
            label5.TabIndex = 11;
            label5.Text = "Input:";
            label5.Click += label5_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnExit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(195, 538);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(96, 73);
            btnExit.TabIndex = 19;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.Transparent;
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnReturn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturn.ForeColor = Color.White;
            btnReturn.Location = new Point(71, 538);
            btnReturn.Margin = new Padding(3, 4, 3, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(103, 73);
            btnReturn.TabIndex = 18;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Gill Sans Ultra Bold", 40.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(513, 22);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(465, 94);
            label6.TabIndex = 20;
            label6.Text = "Converter";
            // 
            // Converter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(982, 653);
            Controls.Add(label6);
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
            MaximizeBox = false;
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
        private Label label6;
    }
}