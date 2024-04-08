using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    abstract class Vehicle
    {
        public string Make { get; set; } = "Default";
        public string Model { get; set; } = "Default";
        public string Year { get; set; } = "Default";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("Default Virtual Drive");
        }
    }
}
