using System;
using System.Collections.Generic;
using System.Text;

namespace Object
{
    class QAEmployee: Employee
    {
        public string Specialization { get; set; }

        public QAEmployee(string fn, string ln, float sal, string spec):base(fn,ln,sal)
        {
            Specialization = spec;
        }

        public override string GetInfo()
        {
            return FirstName + " " + LastName + " " + Salary + " " + Specialization;
        }

        public override void Work()
        {
            Console.WriteLine("QAv work");
        }
    }
}
