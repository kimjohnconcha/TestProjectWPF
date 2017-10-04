using TestProjectWPF.Models;

namespace TestProjectWPF.Data
{
    public class AppTestData
    {
        /// <summary>
        /// Populate student sample Data
        /// </summary>
        public static void SetStudentData()
        {
            StudentDataItems.Instance.StudentList.Add(new Student()
            {
                ID = 56,
                Firstname = "Monkey",
                Lastname = "King",
                StudentCode = "STUD10",
                course = "Tactician",
                Room = "31B"
            });

            StudentDataItems.Instance.StudentList.Add(new Student()
            {
                ID = 72,
                Firstname = "Makoto",
                Lastname = "Shishio",
                StudentCode = "STUD90",
                course = "Slasher 101",
                Room = "01K"
            });
        }

        /// <summary>
        /// Populate intructor sample Data
        /// </summary>
        public static void SetInstructorData()
        {
            InstructorDataItems.Instance.InstructorList.Add(new Instructor()
            {
                ID = 12,
                Firstname = "Light",
                Lastname = "Yagami",
                FacultyID = "INS672",
                Deparment = "Nursing",
                Subject = "Basic Assasination"
            });

            InstructorDataItems.Instance.InstructorList.Add(new Instructor()
            {
                ID = 14,
                Firstname = "Ben",
                Lastname = "Hur",
                FacultyID = "INS001",
                Deparment = "Engineering",
                Subject = "Building Blocks"
            });
        }

        /// <summary>
        /// Populate student class card sample Data
        /// </summary>
        public static void SetStudentClassCardData()
        {
            StudentClassCardDataItems.Instance.StudentClassCardList.Add(new StudentClassCard()
            {
                ID = 12,
                student = new Student()
                {
                    ID = 72,
                    Firstname = "Makoto",
                    Lastname = "Shishio",
                    StudentCode = "STUD90",
                    course = "Slasher 101",
                    Room = "01K"
                },
                instructor = new Instructor()
                {
                    ID = 14,
                    Firstname = "Ben",
                    Lastname = "Hur",
                    FacultyID = "INS001",
                    Deparment = "Engineering",
                    Subject = "Building Blocks"
                },
                Status = "Failed!"
            });

            StudentClassCardDataItems.Instance.StudentClassCardList.Add(new StudentClassCard()
            {
                ID = 10,
                student = new Student()
                {
                    ID = 56,
                    Firstname = "Monkey",
                    Lastname = "King",
                    StudentCode = "STUD10",
                    course = "Tactician",
                    Room = "31B"
                },
                instructor = new Instructor()
                {
                    ID = 12,
                    Firstname = "Light",
                    Lastname = "Yagami",
                    FacultyID = "INS672",
                    Deparment = "Nursing",
                    Subject = "Basic Assasination"
                },
                Status = "Well Done!"
            });
        }
    }
}
