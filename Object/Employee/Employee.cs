using System;
using System.Collections.Generic;
using System.Text;

namespace Object
{
    abstract class Employee:IWorkable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Salary { get; set; }

        public abstract string GetInfo();

        public abstract void Work();

    public Employee(string fn, string ln, float sal)
        {
            FirstName = fn;
            LastName = ln;
            Salary = sal;
        }

    }
}
