using System;
using System.Collections.Generic;
using System.Text;

namespace Object
{
    abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Salary { get; set; }

        public abstract string GetInfo();
        //{
        //    return FirstName + " " + LastName + " " + Salary;
        //}

    public Employee(string fn, string ln, float sal)
        {
            FirstName = fn;
            LastName = ln;
            Salary = sal;
        }

    }
}
