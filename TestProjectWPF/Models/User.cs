﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectWPF.Data;

namespace TestProjectWPF.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public override string ToString()
        {
            return ID + " - " + Firstname + " " + Lastname;
        }
    }
}
