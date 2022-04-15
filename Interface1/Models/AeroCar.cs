using Interface1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1.Models
{
    public class AeroCar : Vehicle, IAbleToFly
    {
        public override Environment TransportEnvironment => Environment.Land | Environment.Air;

        public void Fly()
        {
            Console.WriteLine("Aerocar FLYING");
        }
    }
}
