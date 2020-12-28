using System;
using System.Collections.Generic;
using System.Text;

namespace Object
{
    class DevEmployee:Employee
    {
        public string ProgrammingLanguage { get; set; }

        public DevEmployee(string fn, string ln, float sal, string language) : base(fn, ln, sal)
        {
            ProgrammingLanguage = language;
        }

        public override string GetInfo()
        {
            return FirstName + " " + LastName + " " + Salary + " " + ProgrammingLanguage;
        }

    }
}
