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
            saveButton = new Button();
            dataGridView1 = new DataGridView();
            saveAndExitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "nameLabel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 55);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "dobLabel";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(386, 55);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 2;
            label3.Text = "studyProgramLabel";
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
            // saveButton
            // 
            saveButton.Location = new Point(12, 122);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 7;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 165);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(495, 194);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // saveAndExitButton
            // 
            saveAndExitButton.Location = new Point(386, 122);
            saveAndExitButton.Name = "saveAndExitButton";
            saveAndExitButton.Size = new Size(121, 23);
            saveAndExitButton.TabIndex = 9;
            saveAndExitButton.Text = "Save and Exit";
            saveAndExitButton.UseVisualStyleBackColor = true;
            saveAndExitButton.Click += saveAndExitButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 423);
            Controls.Add(saveAndExitButton);
            Controls.Add(dataGridView1);
            Controls.Add(saveButton);
            Controls.Add(studyProgramComboBox);
            Controls.Add(dobDateTimePicker);
            Controls.Add(nameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "StudentFormApplication";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Button saveButton;
        private DataGridView dataGridView1;
        private Button saveAndExitButton;
    }
}
