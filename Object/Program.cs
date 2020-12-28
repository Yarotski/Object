using System;

namespace Object
{
    class Program
    {


        static void Main(string[] args)
        {
            Employee employee1 = new Employee("em1", "em1", 1200f); 
            PMEmployee employee2 = new PMEmployee("pm2", "pm2", 4200f, "Wex"); 
            DevEmployee employee3 = new DevEmployee("dv3", "dv3", 1800f, "C#");
            QAEmployee employee4 = new QAEmployee("qa1", "qa1", 2500f, "Web");
            QAEmployee employee5 = new QAEmployee("qa2", "qa2", 2500f, "Desktop");



            Employee[] employees = new Employee[] { employee1, employee2, employee3, employee4, employee5 };

            
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.GetInfo());
            }
        }
    }
}
