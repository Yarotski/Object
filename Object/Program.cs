using System;

namespace Object
{
    class Program
    {


        static void Main(string[] args)
        {
            Employee employee1 = new Employee("fn1", "ln1", 1200f); 
            Employee employee2 = new Employee("fn2", "ln2", 1500f); 
            Employee employee3 = new Employee("fn3", "ln3", 1800f);

            QAEmployee qaemployee1 = new QAEmployee("qa1", "qa2", 2500f, "Web");

            //employee1.FirstName = "Vasya";

            Employee[] employees = new Employee[] { employee1, employee2, employee3, qaemployee1 };

            
            foreach (var tt in employees)
            {
                Console.WriteLine("{0} {1} {2}", tt.FirstName, tt.LastName, tt.Salary);
            }

            
        }
    }
}
