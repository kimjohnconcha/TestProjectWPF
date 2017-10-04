using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectWPF.Data;

namespace TestProjectWPF.Models
{
    public class StudentClassCard : Card
    {
        public int ID { get; set; }
        public Student student { get; set; }
        public Instructor instructor { get; set; }
        public string Status { get; set; }

        public override string ShowDetails()
        {
            //throw new NotImplementedException();

            return "";
        }
    }
}
