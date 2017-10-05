using System;
using TestProjectWPF.Data;
using TestProjectWPF.Models;

namespace TestProjectWPF.Helpers
{
    public class DataHelper : IDataService
    {
        /// <summary>
        /// Save class card via object
        /// </summary>
        /// <param name="classCard"></param>
        public void SaveClassCard(StudentClassCard classCard)
        {
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Save class card via params
        /// </summary>
        /// <param name="id"></param>
        /// <param name="stud"></param>
        /// <param name="instructor"></param>
        /// <param name="status"></param>
        public void SaveClassCard(int id, Student stud, Instructor instructor, string status)
        {
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Save instructor via object
        /// </summary>
        /// <param name="instructor"></param>
        public void SaveInstructor(Instructor instructor)
        {
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Save instructor via params
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <param name="facultyID"></param>
        /// <param name="department"></param>
        /// <param name="subject"></param>
        public void SaveInstructor(int id, string fname, string lname, string facultyID, string department, string subject)
        {
            //throw new NotImplementedException();
        }


        /// <summary>
        /// Add student via object
        /// </summary>
        /// <param name="student"></param>
        public void SaveStudent(Student student)
        {
            StudentDataItems.Instance.StudentList.Add(student);
        }

        /// <summary>
        /// Add student via params
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <param name="studCode"></param>
        /// <param name="course"></param>
        /// <param name="room"></param>
        public void SaveStudent(int id, string fname, string lname, string studCode, string course, string room)
        {
            StudentDataItems.Instance.StudentList.Add(new Student()
            {
                ID = id,
                Firstname = fname,
                Lastname = lname,
                StudentCode = studCode,
                course = course,
                Room = room
            });
        }
    }
}
