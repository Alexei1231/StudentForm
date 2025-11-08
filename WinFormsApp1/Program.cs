namespace StudentForm
{

   public enum StudyProgram {IT, HISTORY, CHEMISTRY, PEDAGOGICS }

    class Student //the student model
    {
        private int id { get; set; }
        private string name { get; set; }
        private DateTime dob { get; set; }
        private StudyProgram studyProgram { get; set; }

    }

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}