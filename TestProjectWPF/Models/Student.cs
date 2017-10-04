using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectWPF.Models
{
    public class Student : User
    {
        public string StudentCode { get; set; }
        public string course { get; set; }
        public string Room { get; set; }

        public override string ToString()
        {
            return ID + " - " + Firstname + " " + Lastname;
        }
    }
}
