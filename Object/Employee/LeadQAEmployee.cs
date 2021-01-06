using System;
using System.Collections.Generic;
using System.Text;

namespace Object
{
    class LeadQAEmployee:QAEmployee, IJiraTaskCreatable
    {

        public LeadQAEmployee(string fn, string ln, float sal, string spec) : base(fn, ln, sal, spec)
        {

        }

        public void CreateTask(string taskName)
        {
            Console.WriteLine("QA Lead has created task named {0} is created", taskName);
        }
    }
}
