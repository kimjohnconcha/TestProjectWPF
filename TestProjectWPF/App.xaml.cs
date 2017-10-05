using System.Collections.ObjectModel;
using System.Windows;
using TestProjectWPF.Data;
using TestProjectWPF.Helpers;
using TestProjectWPF.Models;

namespace TestProjectWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static DataManager Datamanager { get; private set; }

        public App()
        {
            StudentDataItems.Instance.StudentList = new ObservableCollection<Student>();
            InstructorDataItems.Instance.InstructorList = new ObservableCollection<Instructor>();
            StudentClassCardDataItems.Instance.StudentClassCardList = new ObservableCollection<StudentClassCard>();
            Datamanager = new DataManager(new DataHelper());
            SetInitialData();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            System.Diagnostics.Debug.WriteLine("Welcome!!");
        }

        private void SetInitialData()
        {
            AppTestData.SetStudentData();
            AppTestData.SetInstructorData();
            AppTestData.SetStudentClassCardData();
        }
    }
}
