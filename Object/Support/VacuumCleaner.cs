using System;
using System.Collections.Generic;
using System.Text;

namespace Object
{
    class VacuumCleaner : IWorkable
    {
        public string Producer { get; set; }

        public VacuumCleaner(string prod)
        {
            prod = Producer;
        }

        public string GetInfo()
        {
            return "I am a robot" + Producer;
        }

        public void Work()
        {
            Console.WriteLine("Sorry, coffee break");
        }
    }
 
}
