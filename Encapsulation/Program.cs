using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name= "Ali";
            p1.Age = 33;


            Console.WriteLine(p1.Tag());
            Console.ReadKey();

        }
        public class Person
        {
            //Prop
            public string Name { get; set; }

            private int age; //field 


            public int Age //property.
            {
                get
                {
                    return age;
                }
                set
                {
                    if (value < 0)
                        throw new Exception("Age Cannot be Negative");
                    age = value;
                }
            }



            public string Tag()
            {
                return $"{Name} ({age} yasında)";
            }

        }
    }
}
