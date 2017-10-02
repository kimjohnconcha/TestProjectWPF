using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectWPF.Models;

namespace TestProjectWPF.Data
{
    public interface IDataService
    {
        void SaveStudent(Student student);
        void SaveStudent(int id, string fname, string lname, string studCode, string course, string room);

        void SaveInstructor(Instructor instructor);
        void SaveInstructor(int id, string fname, string lname, string facultyID, string department, string subject);

        void SaveClassCard(StudentClassCard classCard);
        void SaveClassCard(int id, Student stud, Instructor instructor, string status);
    }
}
