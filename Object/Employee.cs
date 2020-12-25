using System;
using System.Collections.Generic;
using System.Text;

namespace Object
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Salary { get; set; }

        public Employee(string fn, string ln, float sal)
        {
            FirstName = fn;
            LastName = ln;
            Salary = sal;
        }

    }
}
