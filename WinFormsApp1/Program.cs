namespace StudentForm
{

   public enum StudyProgram {IT, HISTORY, CHEMISTRY, PEDAGOGICS }

    class Student //the student model
    {
        private string name { get; set; }
        private DateTime dob { get; set; }
        private StudyProgram studyProgram { get; set; }

    }

    class StudentList
    {
        private HashSet<Student> students { get; }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void DeleteStudent(Student student)
        {
            students.Remove(student);
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