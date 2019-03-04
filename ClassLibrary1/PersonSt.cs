using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class PersonSt
    {
        public static string PersonInfo(Person p)
        {
            return String.Format("name - {0}, fname - {1}, DateOfBirth - {2}", p.name, p.fname, p.DateOfBirth);
        }
    }
}
