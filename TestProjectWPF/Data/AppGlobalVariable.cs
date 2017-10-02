using System.Collections.Generic;
using System.Collections.ObjectModel;
using TestProjectWPF.Models;

namespace TestProjectWPF.Data
{
    /// <summary>
    /// Handles Student Data
    /// </summary>
    public class StudentDataItems
    {
        private static StudentDataItems instance;
        public static StudentDataItems Instance
        {
            get
            {
                if (instance == null)
                    instance = new StudentDataItems();

                return instance;
            }

        }

        public ObservableCollection<Student> StudentList { get; set; }
    }


    /// <summary>
    /// Handles Instructor Data
    /// </summary>
    public class InstructorDataItems
    {
        private static InstructorDataItems instance;
        public static InstructorDataItems Instance
        {
            get
            {
                if (instance == null)
                    instance = new InstructorDataItems();

                return instance;
            }

        }

        public ObservableCollection<Instructor> InstructorList { get; set; }
    }


    /// <summary>
    /// Handles StudentClassCard Data
    /// </summary>
    public class StudentClassCardDataItems
    {
        private static StudentClassCardDataItems instance;
        public static StudentClassCardDataItems Instance
        {
            get
            {
                if (instance == null)
                    instance = new StudentClassCardDataItems();

                return instance;
            }

        }

        public ObservableCollection<StudentClassCard> StudentClassCardList { get; set; }
    }

}
