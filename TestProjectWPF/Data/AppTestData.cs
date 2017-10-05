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
            App.Datamanager.SaveStudentData(43, "Monkey", "King", "STUD10", "Tactician 101", "31B");
            App.Datamanager.SaveStudentData(19, "Makoto", "Shishio", "STUD90", "Slasher 102", "21B");
        }

        /// <summary>
        /// Populate intructor sample Data
        /// </summary>
        public static void SetInstructorData()
        {
            App.Datamanager.SaveInstructor(12, "Light", "Yagame", "INS654", "Nursing", "Basic Assasination");
            App.Datamanager.SaveInstructor(27, "Ben", "Hur", "INS001", "Engineering", "Building Blocks");
        }

        /// <summary>
        /// Populate student class card sample Data
        /// </summary>
        public static void SetStudentClassCardData()
        {


            App.Datamanager.SaveClassCard(
                15, 
                new Student()
                {
                    ID = 72,
                    Firstname = "Makoto",
                    Lastname = "Shishio",
                    StudentCode = "STUD90",
                    course = "Slasher 101",
                    Room = "01K"
                },
                new Instructor()
                {
                    ID = 14,
                    Firstname = "Ben",
                    Lastname = "Hur",
                    FacultyID = "INS001",
                    Deparment = "Engineering",
                    Subject = "Building Blocks"
                }, 
                "Falied"
                );

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
