using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectWPF.Models
{
    public class Instructor : User
    {
        public string FacultyID { get; set; }
        public string Deparment { get; set; }
        public string Subject { get; set; }

        public override string ToString()
        {
            return ID + " - " + Firstname + " " + Lastname;
        }
    }
}
