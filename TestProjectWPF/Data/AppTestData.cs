using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            });

            StudentDataItems.Instance.StudentList.Add(new Student()
            {

            });
        }

        /// <summary>
        /// Populate intructor sample Data
        /// </summary>
        public static void SetInstructorData()
        {
            InstructorDataItems.Instance.InstructorList.Add(new Instructor()
            {

            });

            InstructorDataItems.Instance.InstructorList.Add(new Instructor()
            {

            });
        }

        /// <summary>
        /// Populate student class card sample Data
        /// </summary>
        public static void SetStudentClassCardData()
        {
            StudentClassCardDataItems.Instance.StudentClassCardList.Add(new StudentClassCard()
            {

            });

            StudentClassCardDataItems.Instance.StudentClassCardList.Add(new StudentClassCard()
            {

            });
        }
    }
}
