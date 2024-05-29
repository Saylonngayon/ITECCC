namespace Multi_Tool_Project.Tools
{
    partial class TDL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TDL));
            checkedListBoxLow = new CheckedListBox();
            checkedListBoxHigh = new CheckedListBox();
            checkedListBoxMedium = new CheckedListBox();
            txtTaskName = new TextBox();
            datePicker = new DateTimePicker();
            cmbPriority = new ComboBox();
            btnAddTask = new Button();
            btnDeleteTask = new Button();
            btnModifyTask = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnInstruction = new Button();
            label5 = new Label();
            btnExit = new Button();
            btnReturn = new Button();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // checkedListBoxLow
            // 
            checkedListBoxLow.FormattingEnabled = true;
            checkedListBoxLow.Location = new Point(504, 478);
            checkedListBoxLow.Margin = new Padding(3, 4, 3, 4);
            checkedListBoxLow.Name = "checkedListBoxLow";
            checkedListBoxLow.Size = new Size(443, 158);
            checkedListBoxLow.TabIndex = 1;
            // 
            // checkedListBoxHigh
            // 
            checkedListBoxHigh.FormattingEnabled = true;
            checkedListBoxHigh.Location = new Point(504, 65);
            checkedListBoxHigh.Margin = new Padding(3, 4, 3, 4);
            checkedListBoxHigh.Name = "checkedListBoxHigh";
            checkedListBoxHigh.Size = new Size(443, 158);
            checkedListBoxHigh.TabIndex = 2;
            // 
            // checkedListBoxMedium
            // 
            checkedListBoxMedium.FormattingEnabled = true;
            checkedListBoxMedium.Location = new Point(504, 269);
            checkedListBoxMedium.Margin = new Padding(3, 4, 3, 4);
            checkedListBoxMedium.Name = "checkedListBoxMedium";
            checkedListBoxMedium.Size = new Size(443, 158);
            checkedListBoxMedium.TabIndex = 3;
            // 
            // txtTaskName
            // 
            txtTaskName.BackColor = SystemColors.HighlightText;
            txtTaskName.BorderStyle = BorderStyle.None;
            txtTaskName.ForeColor = Color.Black;
            txtTaskName.Location = new Point(54, 84);
            txtTaskName.Margin = new Padding(3, 4, 3, 4);
            txtTaskName.Multiline = true;
            txtTaskName.Name = "txtTaskName";
            txtTaskName.ScrollBars = ScrollBars.Vertical;
            txtTaskName.Size = new Size(254, 65);
            txtTaskName.TabIndex = 4;
            // 
            // datePicker
            // 
            datePicker.Location = new Point(64, 362);
            datePicker.Margin = new Padding(3, 4, 3, 4);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(235, 27);
            datePicker.TabIndex = 5;
            // 
            // cmbPriority
            // 
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Location = new Point(64, 432);
            cmbPriority.Margin = new Padding(3, 4, 3, 4);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(235, 28);
            cmbPriority.TabIndex = 6;
            cmbPriority.SelectedIndexChanged += cmbPriority_SelectedIndexChanged;
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = Color.Transparent;
            btnAddTask.FlatAppearance.BorderSize = 0;
            btnAddTask.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnAddTask.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAddTask.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAddTask.FlatStyle = FlatStyle.Flat;
            btnAddTask.Font = new Font("Algerian", 10.2F, FontStyle.Bold);
            btnAddTask.ForeColor = Color.White;
            btnAddTask.Location = new Point(52, 185);
            btnAddTask.Margin = new Padding(3, 4, 3, 4);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(114, 32);
            btnAddTask.TabIndex = 7;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = false;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // btnDeleteTask
            // 
            btnDeleteTask.BackColor = Color.Transparent;
            btnDeleteTask.FlatAppearance.BorderSize = 0;
            btnDeleteTask.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnDeleteTask.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnDeleteTask.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnDeleteTask.FlatStyle = FlatStyle.Flat;
            btnDeleteTask.Font = new Font("Algerian", 10.2F, FontStyle.Bold);
            btnDeleteTask.ForeColor = Color.White;
            btnDeleteTask.Location = new Point(187, 242);
            btnDeleteTask.Margin = new Padding(3, 4, 3, 4);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(138, 40);
            btnDeleteTask.TabIndex = 8;
            btnDeleteTask.Text = "Delete Task";
            btnDeleteTask.UseVisualStyleBackColor = false;
            btnDeleteTask.Click += btnDeleteTask_Click;
            // 
            // btnModifyTask
            // 
            btnModifyTask.BackColor = Color.Transparent;
            btnModifyTask.FlatAppearance.BorderSize = 0;
            btnModifyTask.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnModifyTask.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnModifyTask.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnModifyTask.FlatStyle = FlatStyle.Flat;
            btnModifyTask.Font = new Font("Algerian", 10.2F, FontStyle.Bold);
            btnModifyTask.ForeColor = Color.White;
            btnModifyTask.Location = new Point(187, 185);
            btnModifyTask.Margin = new Padding(3, 4, 3, 4);
            btnModifyTask.Name = "btnModifyTask";
            btnModifyTask.Size = new Size(128, 32);
            btnModifyTask.TabIndex = 9;
            btnModifyTask.Text = "Modify";
            btnModifyTask.UseVisualStyleBackColor = false;
            btnModifyTask.Click += btnModifyTask_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Gill Sans Ultra Bold", 9F);
            label1.Location = new Point(504, 449);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 10;
            label1.Text = "Low";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Gill Sans Ultra Bold", 9F);
            label2.Location = new Point(504, 242);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 11;
            label2.Text = "Medium";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Gill Sans Ultra Bold", 9F);
            label3.Location = new Point(504, 35);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 12;
            label3.Text = "High";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(677, 9);
            label4.Name = "label4";
            label4.Size = new Size(96, 29);
            label4.TabIndex = 13;
            label4.Text = "TASKS";
            label4.Click += label4_Click;
            // 
            // btnInstruction
            // 
            btnInstruction.BackColor = Color.Transparent;
            btnInstruction.FlatAppearance.BorderSize = 0;
            btnInstruction.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnInstruction.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnInstruction.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnInstruction.FlatStyle = FlatStyle.Flat;
            btnInstruction.Font = new Font("Algerian", 10.2F, FontStyle.Bold);
            btnInstruction.ForeColor = Color.White;
            btnInstruction.Location = new Point(42, 242);
            btnInstruction.Margin = new Padding(3, 4, 3, 4);
            btnInstruction.Name = "btnInstruction";
            btnInstruction.Size = new Size(139, 40);
            btnInstruction.TabIndex = 14;
            btnInstruction.Text = "Instructions";
            btnInstruction.UseVisualStyleBackColor = false;
            btnInstruction.Click += btnInstruction_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 18);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 15;
            label5.Text = "To-Do-List";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnExit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnExit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Gill Sans Ultra Bold", 9F);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(55, 528);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(91, 62);
            btnExit.TabIndex = 17;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.Transparent;
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnReturn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnReturn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("Gill Sans Ultra Bold", 9F);
            btnReturn.ForeColor = Color.White;
            btnReturn.Location = new Point(178, 527);
            btnReturn.Margin = new Padding(3, 4, 3, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(100, 62);
            btnReturn.TabIndex = 16;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Gill Sans Ultra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(52, 334);
            label6.Name = "label6";
            label6.Size = new Size(131, 20);
            label6.TabIndex = 18;
            label6.Text = "Set Due Date:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Gill Sans Ultra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(52, 406);
            label7.Name = "label7";
            label7.Size = new Size(124, 20);
            label7.TabIndex = 19;
            label7.Text = "Set Priority:";
            // 
            // TDL
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(982, 653);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnExit);
            Controls.Add(btnReturn);
            Controls.Add(label5);
            Controls.Add(btnInstruction);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnModifyTask);
            Controls.Add(btnDeleteTask);
            Controls.Add(btnAddTask);
            Controls.Add(cmbPriority);
            Controls.Add(datePicker);
            Controls.Add(txtTaskName);
            Controls.Add(checkedListBoxMedium);
            Controls.Add(checkedListBoxHigh);
            Controls.Add(checkedListBoxLow);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TDL";
            Text = "TDL";
            Load += TDL_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBoxLow;
        private CheckedListBox checkedListBoxHigh;
        private CheckedListBox checkedListBoxMedium;
        private TextBox txtTaskName;
        private DateTimePicker datePicker;
        private ComboBox cmbPriority;
        private Button btnAddTask;
        private Button btnDeleteTask;
        private Button btnModifyTask;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnInstruction;
        private Label label5;
        private Button btnExit;
        private Button btnReturn;
        private Label label6;
        private Label label7;
    }
}