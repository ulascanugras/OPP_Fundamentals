using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1.Models
{
    public class Car : Vehicle
    {
        public override Environment TransportEnvironment { get { return Environment.Land; } }
    }
}
