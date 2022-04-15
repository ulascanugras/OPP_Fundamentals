using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1.Models
{
    public class Human: Animal
    {
        public override string Type { get { return "Human"; } }
        public override void MoveOn()
        {
            Console.WriteLine($"{Type} walking.");
        }
    }
}
