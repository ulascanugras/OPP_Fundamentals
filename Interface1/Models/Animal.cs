using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1.Models
{
    public abstract class Animal
    {
        public abstract string Type { get; }

        public virtual void MoveOn()
        {
            Console.WriteLine($"{Type} it is moving");
        }

        public virtual void Feed()
        {
            Console.WriteLine($"{Type} is feeding.");
        }
        public override string ToString()
        {
            return Type;
        }
    }
}
