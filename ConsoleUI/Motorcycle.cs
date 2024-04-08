using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle: Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("Motorcycle drives");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcycle virtual");
        }
        public bool HasSideCar { get; set; }

        
    }
}
