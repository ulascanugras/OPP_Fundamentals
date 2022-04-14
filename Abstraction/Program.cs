using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Guitar guitar = new Guitar
            {
                Id = 11,
                Material= "Oak-Tree",
                Type="Stringed",
                GuitarType="Acoustic"
            };
            Flute flute = new Flute();
            flute.Id = new Guid();
            flute.Material = "Gold";
            flute.Type = "Blown";
            flute.FluteType = "Side Flute";
            Console.ReadLine();

        }
        public abstract class MusicInstrument<T>
        {

            public abstract T Id { get; set; }
            public string  Material { get; set; }
            public string Type { get; set; }
            
           
            

        }
        public class Guitar : MusicInstrument<int>
        {

            public override int Id { get; set; }
            public string GuitarType { get; set; }
            public Guitar()
            {
                Console.WriteLine("Guitar created!");
            }
        }
        public class Flute : MusicInstrument<Guid>
        {
            public override Guid Id { get; set; }
            public string FluteType { get; set; }
            public Flute()
            {
                Console.WriteLine("Flute Created!!");
            }

        }
    }
}
