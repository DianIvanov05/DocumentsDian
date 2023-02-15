using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTsardom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Dog("Balkan", 5);
            Console.WriteLine(animal1.MakeNoise());
            Console.WriteLine(animal1.MakeTrick());
            Animal animal2 = new Cat("Artyom", 3);
            Console.WriteLine(animal2.MakeNoise());
            Console.WriteLine(animal2.MakeTrick());

            

        }
    }
}
