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
            LeadQAEmployee leadQAEmployee = new LeadQAEmployee("qalead3", "qalead", 2600f, "Team");
            VacuumCleaner cleaner = new VacuumCleaner("Samsung");

 

            IWorkable[] employees = new IWorkable[] { employee1, employee2, employee3, employee4, employee5, cleaner, leadQAEmployee };
            
            //foreach (IWorkable worker in employees)
            //{
            //    Console.WriteLine(worker.GetInfo());
            //}

            foreach (IWorkable worker in employees)
            {

                if (worker is IJiraTaskCreatable)
                {
                    IJiraTaskCreatable taskCreator = (IJiraTaskCreatable)worker;
                    taskCreator.CreateTask("Task 1");
                }

                if (worker is PMEmployee)
                {
                    PMEmployee pm = (PMEmployee)worker;
                    Console.WriteLine(pm.ManagingProject);
                }
            }


        }

        static void CreateTask(IJiraTaskCreatable creator, string info)
        {
            creator.CreateTask("info");
        }

    }
}
