using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectWPF.Data;
using TestProjectWPF.Models;

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
    }
}
