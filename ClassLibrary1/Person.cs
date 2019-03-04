using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Person
    {
        public string name { get; set; }
        public string fname { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Person()
        {
            this.name = name;
            this.fname = fname;
            this.DateOfBirth = DateOfBirth;
        }
    }
}
