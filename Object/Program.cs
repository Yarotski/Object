using System;

namespace Object
{
    class Program
    {


        static void Main(string[] args)
        {
            Employee employee1 = new PMEmployee ("em1", "em1", 1200f, "NoProject"); 
            PMEmployee employee2 = new PMEmployee("pm2", "pm2", 4200f, "Wex"); 
            DevEmployee employee3 = new DevEmployee("dv3", "dv3", 1800f, "C#");
            QAEmployee employee4 = new QAEmployee("qa1", "qa1", 2500f, "Web");
            QAEmployee employee5 = new QAEmployee("qa2", "qa2", 2500f, "Desktop");
            VacuumCleaner cleaner = new VacuumCleaner("Samsung");

            IWorkable[] employees = new IWorkable[] { employee1, employee2, employee3, employee4, employee5, cleaner};
            
            foreach (IWorkable employee in employees)
            {
                Console.WriteLine(employee.GetInfo());
            }
        }
    }
}
