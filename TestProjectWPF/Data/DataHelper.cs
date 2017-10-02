using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectWPF.Data;
using TestProjectWPF.Models;

namespace TestProjectWPF.Helpers
{
    public class DataHelper : IDataService
    {
        public void SaveClassCard(StudentClassCard classCard)
        {
            throw new NotImplementedException();
        }

        public void SaveClassCard(int id, Student stud, Instructor instructor, string status)
        {
            throw new NotImplementedException();
        }

        public void SaveInstructor(Instructor instructor)
        {
            throw new NotImplementedException();
        }

        public void SaveInstructor(int id, string fname, string lname, string facultyID, string department, string subject)
        {
            throw new NotImplementedException();
        }

        public void SaveStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public void SaveStudent(int id, string fname, string lname, string studCode, string course, string room)
        {
            throw new NotImplementedException();
        }
    }
}
