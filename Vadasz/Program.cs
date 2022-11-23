using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vadasz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Squirrel squirrel = new Squirrel();
            PolarBear polarBear = new PolarBear();
            Rabbit rabbit = new Rabbit();
            Animal[] animals = { squirrel, polarBear, rabbit };

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.GetPrice());
            }
        }
    }
}
