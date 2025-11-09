using System.Text.Json;

namespace StudentForm
{

    public enum StudyProgram { IT, HISTORY, CHEMISTRY, PEDAGOGICS }

    class Student // student model
    {
        public string Name { get; set; }
        public DateTime DoB { get; set; }
        public StudyProgram StudyProgram { get; set; }

        public Student(string name, DateTime dob, StudyProgram studyProgram)
        {
            this.Name = name;
            this.DoB = dob;
            this.StudyProgram = studyProgram;
        }

        public Student() { }
    }

    class StudentCollection // student set - a structure that saves information about all the students and
                            // also saves the information to a JSON file
    {
        public List<Student>? Students { get; set; }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void DeleteStudent(Student student)
        {
            Students.Remove(student);
        }

        public StudentCollection()
        {
            Students = new List<Student>();
        }

        public void SaveChanges()
        {
            string fileName = "Students.json";
            string jsonString = JsonSerializer.Serialize(Students);
            File.WriteAllText(fileName, jsonString);
            Console.WriteLine(jsonString);

        }
    }

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());

        }
    }
}