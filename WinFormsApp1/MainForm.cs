using System.Collections.Generic;
using System.Text.Json;
using System.Windows.Forms.VisualStyles;

namespace StudentForm
{
    public partial class MainForm : Form
    {
        StudentCollection StudentCollection;
        StudyProgram StudyProgram;
        public MainForm()
        {
            InitializeComponent();
            StudentCollection = new StudentCollection();
            StudentCollection.Students = JsonSerializer.Deserialize<List<Student>>(File.ReadAllText("Students.json"));

        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            studyProgramComboBox.Items.Add(StudyProgram.IT);
            studyProgramComboBox.Items.Add(StudyProgram.HISTORY);
            studyProgramComboBox.Items.Add(StudyProgram.CHEMISTRY);
            studyProgramComboBox.Items.Add(StudyProgram.PEDAGOGICS);
            studyProgramComboBox.SelectedIndex = 0;
            dataGridView1.DataSource = StudentCollection.Students;




        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = new Student(nameTextBox.Text, Convert.ToDateTime(dobDateTimePicker.Value.Date), (StudyProgram)studyProgramComboBox.SelectedItem);
                StudentCollection.AddStudent(student);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = StudentCollection.Students;
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong. Check your input.", "Error", MessageBoxButtons.OK);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saveAndExitButton_Click(object sender, EventArgs e)
        {
            string fileName = "Students.json";
            string jsonString = JsonSerializer.Serialize(StudentCollection);
            File.WriteAllText(fileName, jsonString);
            
        }
    }
}
