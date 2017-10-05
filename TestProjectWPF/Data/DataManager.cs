using TestProjectWPF.Data;

namespace TestProjectWPF.Models
{
    public class DataManager
    {
        IDataService dataService;

        public DataManager(IDataService service)
        {
            dataService = service;
        }

        public void SaveStudentData(Student student)
        {
            dataService.SaveStudent(student);
        }

        public void SaveStudentData(int id, string fname, string lname, string studCode, string course, string room)
        {
            dataService.SaveStudent(id, fname, lname, studCode, course, room);
        }

        public void SaveInstructor(Instructor instructor)
        {
            dataService.SaveInstructor(instructor);
        }

        public void SaveInstructor(int id, string fname, string lname, string facultyID, string department, string subject)
        {
            dataService.SaveInstructor(id, fname, lname, facultyID, department, subject);
        }

        public void SaveClassCard(StudentClassCard classCard)
        {
            dataService.SaveClassCard(classCard);
        }

        public void SaveClassCard(int id, Student stud, Instructor instructor, string status)
        {
            dataService.SaveClassCard(id, stud, instructor, status);
        }
    }
}
