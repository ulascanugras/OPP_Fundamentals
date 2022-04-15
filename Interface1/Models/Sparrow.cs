using Interface1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1.Models
{
    public class Sparrow : Animal, IAbleToFly
    {
        public override string Type => "Sparrow";

        public void Fly()
        {
            Console.WriteLine($"{Type} flapping its wings fly.");
        }
    }
}
