using TestProjectWPF.Models;

namespace TestProjectWPF.Data
{
    public interface IDataService
    {
        /// <summary>
        /// Student
        /// </summary>
        void SaveStudent(Student student);
        void SaveStudent(int id, string fname, string lname, string studCode, string course, string room);

        /// <summary>
        /// Instructor
        /// </summary>
        void SaveInstructor(Instructor instructor);
        void SaveInstructor(int id, string fname, string lname, string facultyID, string department, string subject);

        /// <summary>
        /// Class Card
        /// </summary>
        void SaveClassCard(StudentClassCard classCard);
        void SaveClassCard(int id, Student stud, Instructor instructor, string status);
    }
}
