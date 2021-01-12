using System;
using System.Collections.Generic;

namespace Object
{
    class Program
    {


        static void Main(string[] args)
        {
            Employee employee1 = new PMEmployee ("em1", "em1", 1200f, "NoProject");

            
            
            //for (int i = 0; i <employee1.Marks.Length; i++)
            //{
            //    Console.WriteLine(employee1.Marks[i]);
            //}

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(employee1[i]);
            }





            PMEmployee employee2 = new PMEmployee("pm2", "pm2", 4200f, "Wex"); 
            DevEmployee employee3 = new DevEmployee("dv3", "dv3", 1800f, "C#");
            QAEmployee employee4 = new QAEmployee("qa1", "qa1", 2500f, "Web");
            QAEmployee employee5 = new QAEmployee("qa2", "qa2", 2500f, "Desktop");
            LeadQAEmployee leadQAEmployee = new LeadQAEmployee("qalead3", "qalead", 2600f, "Team");
            VacuumCleaner cleaner = new VacuumCleaner("Samsung");



            /*IWorkable[] employees = new IWorkable[] { 
                employee1, 
                employee2, 
                employee3, 
                employee4, 
                employee5, 
                cleaner, 
                leadQAEmployee };*/


            List<IWorkable> employees = new List<IWorkable>();
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            employees.Add(employee5);
            employees.Add(cleaner);
            employees.Add(leadQAEmployee);


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
