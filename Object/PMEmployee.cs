using System;
using System.Collections.Generic;
using System.Text;

namespace Object
{
    class PMEmployee:Employee
    {
        public string ManagingProject { get; set; }

        public PMEmployee(string fn, string ln, float sal, string projectName) : base(fn, ln, sal)
        {
            ManagingProject = projectName;
        }

        public override string GetInfo()
        {
            return FirstName + " " + LastName + " " + Salary + " " + ManagingProject;
        }
        public override void Work()
        {
            Console.WriteLine("PM work");
        }
    }
}
