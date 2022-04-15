using Interface1.Interfaces;
using Interface1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<object> objects = new List<object>() 
          {
             new AeroCar(),
             new Car(),
             new Bee(),
             new Ship(),
             new Helicopter(),
             new Human(),
             new Sparrow(),
          };
            foreach (Object obj in objects)
            {
                if (obj is Animal)
                {
                    Animal h = (Animal)obj;
                    h.MoveOn();

                }
            }
            Console.WriteLine("*****************************************");
            foreach (object obj  in objects)
            {
                if (obj is IAbleToFly)
                {
                    ((IAbleToFly)obj).Fly();
                   
                }
            }
            Console.WriteLine("******************************************");

            int piece = 0;
            foreach (var item in objects)
                if (item is Vehicle)
                {
                    piece++;
                }
            Console.WriteLine("Number of vehicle " + piece);
         
            Console.WriteLine("*****************************************");
            foreach (var item in objects)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadLine();
        }
    }
}
