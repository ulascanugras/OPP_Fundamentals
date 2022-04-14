using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public class Vehicle
        {
            public string Driver { get; set; }
            public string Type { get; set; }
        }

        public class Plane :Vehicle //Inheritance
        {
            public string Model { get; set; }
            public string Brand { get; set; }
        }
    }
}
