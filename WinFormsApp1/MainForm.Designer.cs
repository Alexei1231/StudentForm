namespace StudentForm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            nameTextBox = new TextBox();
            dobDateTimePicker = new DateTimePicker();
            studyProgramComboBox = new ComboBox();
            addStudentButton = new Button();
            dataGridView = new DataGridView();
            saveChangesButton = new Button();
            saveAndExitButton = new Button();
            deleteStudentButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 55);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 1;
            label2.Text = "Date of Birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(386, 55);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 2;
            label3.Text = "Studying Program";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(12, 83);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(130, 23);
            nameTextBox.TabIndex = 3;
            // 
            // dobDateTimePicker
            // 
            dobDateTimePicker.Location = new Point(164, 83);
            dobDateTimePicker.Name = "dobDateTimePicker";
            dobDateTimePicker.Size = new Size(200, 23);
            dobDateTimePicker.TabIndex = 4;
            // 
            // studyProgramComboBox
            // 
            studyProgramComboBox.FormattingEnabled = true;
            studyProgramComboBox.Location = new Point(386, 83);
            studyProgramComboBox.Name = "studyProgramComboBox";
            studyProgramComboBox.Size = new Size(121, 23);
            studyProgramComboBox.TabIndex = 5;
            // 
            // addStudentButton
            // 
            addStudentButton.Location = new Point(12, 122);
            addStudentButton.Name = "addStudentButton";
            addStudentButton.Size = new Size(130, 23);
            addStudentButton.TabIndex = 7;
            addStudentButton.Text = "Add Student";
            addStudentButton.UseVisualStyleBackColor = true;
            addStudentButton.Click += addStudent_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 183);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(495, 194);
            dataGridView.TabIndex = 8;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // saveChangesButton
            // 
            saveChangesButton.Location = new Point(164, 122);
            saveChangesButton.Name = "saveChangesButton";
            saveChangesButton.Size = new Size(200, 23);
            saveChangesButton.TabIndex = 9;
            saveChangesButton.Text = "Save Changes";
            saveChangesButton.UseVisualStyleBackColor = true;
            saveChangesButton.Click += saveChangesButton_Click;
            // 
            // saveAndExitButton
            // 
            saveAndExitButton.Location = new Point(386, 122);
            saveAndExitButton.Name = "saveAndExitButton";
            saveAndExitButton.Size = new Size(121, 23);
            saveAndExitButton.TabIndex = 10;
            saveAndExitButton.Text = "Save All and Exit";
            saveAndExitButton.UseVisualStyleBackColor = true;
            saveAndExitButton.Click += saveAndExitButton_Click;
            // 
            // deleteStudentButton
            // 
            deleteStudentButton.Location = new Point(164, 151);
            deleteStudentButton.Name = "deleteStudentButton";
            deleteStudentButton.Size = new Size(200, 23);
            deleteStudentButton.TabIndex = 11;
            deleteStudentButton.Text = "Delete Student";
            deleteStudentButton.UseVisualStyleBackColor = true;
            deleteStudentButton.Click += deleteStudentButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 423);
            Controls.Add(deleteStudentButton);
            Controls.Add(saveAndExitButton);
            Controls.Add(saveChangesButton);
            Controls.Add(dataGridView);
            Controls.Add(addStudentButton);
            Controls.Add(studyProgramComboBox);
            Controls.Add(dobDateTimePicker);
            Controls.Add(nameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "StudentFormApplication";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox nameTextBox;
        private DateTimePicker dobDateTimePicker;
        private ComboBox studyProgramComboBox;
        private Button addStudentButton;
        private DataGridView dataGridView;
        private Button saveChangesButton;
        private Button saveAndExitButton;
        private Button deleteStudentButton;
    }
}
