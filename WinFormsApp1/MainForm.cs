using System.Collections.Generic;
using System.Text.Json;
using System.Windows.Forms.VisualStyles;

namespace StudentForm
{
    public partial class MainForm : Form
    {
        StudentCollection StudentCollection;
     
        public MainForm()
        {
            InitializeComponent();
            StudentCollection = new StudentCollection();
            try
            {
                StudentCollection.Students = JsonSerializer.Deserialize<List<Student>>(File.ReadAllText("Students.json"));
            }
            catch (Exception)
            {
                MessageBox.Show("The .json file has not been deserialised successfully.", "Error", MessageBoxButtons.OK);
            }

        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            studyProgramComboBox.Items.Add(StudyProgram.IT);
            studyProgramComboBox.Items.Add(StudyProgram.HISTORY);
            studyProgramComboBox.Items.Add(StudyProgram.CHEMISTRY);
            studyProgramComboBox.Items.Add(StudyProgram.PEDAGOGICS);
            studyProgramComboBox.SelectedIndex = 0;
            dataGridView.DataSource = StudentCollection.Students;




        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = new Student(nameTextBox.Text, Convert.ToDateTime(dobDateTimePicker.Value.Date), (StudyProgram)studyProgramComboBox.SelectedItem);
                StudentCollection.AddStudent(student);
                dataGridView.DataSource = null;
                dataGridView.DataSource = StudentCollection.Students;
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong. Check your input.", "Error", MessageBoxButtons.OK);
            }

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView.Select();
        }




        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            string fileName = "Students.json";
            string jsonString = JsonSerializer.Serialize(StudentCollection.Students);
            File.WriteAllText(fileName, jsonString);

        }

        private void saveAndExitButton_Click(object sender, EventArgs e)
        {
            string fileName = "Students.json";
            string jsonString = JsonSerializer.Serialize(StudentCollection.Students);
            File.WriteAllText(fileName, jsonString);
            Application.Exit();
        }

        private void deleteStudentButton_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                for (int i = 0; i < selectedRowCount; i++)
                {
                    StudentCollection.Students.RemoveAt(dataGridView.SelectedRows[0].Index);
                   
                }
            }
            dataGridView.DataSource = null;
            dataGridView.DataSource = StudentCollection.Students;
        }
    }
}
