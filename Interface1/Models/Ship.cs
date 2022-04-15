using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1.Models
{
    public class Ship : Vehicle
    {
        public override Environment TransportEnvironment => Environment.Water;
    }
}
