using Interface1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1.Models
{
    public class Bee : Animal, IAbleToFly
    {
        public override string Type { get; }
        public Bee()
        {
            Type = "Bee";
        }
        public override void Feed()
        {
            Console.WriteLine($"{Type} Feeding with flower essences.");
        }

        public void Fly()
        {
            Console.WriteLine($"{Type} flying by whizzing .");
        }
    }
}
