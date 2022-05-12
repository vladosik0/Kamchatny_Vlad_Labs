using System;
using System.Collections.Generic;
namespace Lab4_5_
{
    class Program
    {
        static void Main(string[] args)
        {
            Penguin penguin1 = new Penguin(5,35.0,10,5);
            penguin1.Move();
            Ostrich ostrich1 = new Ostrich(15,80.0, 70);
            ostrich1.Move();
            Eagle eagle1 = new Eagle(8, 6.5, 150);
            eagle1.Move();
            Parrot parrot1 = new Parrot(3,0.5,100,"kesha");
            parrot1.Move();
            Zoo zoo = new Zoo();
            zoo.AddBird(penguin1);
            zoo.AddBird(ostrich1);
            zoo.AddBird(eagle1);
            zoo.AddBird(parrot1);
            Console.WriteLine($"Max speed among flying birds in zoo: {zoo.GetMaxFlyingSpeed()}");
            Console.WriteLine($"Max speed among flightless birds in zoo: {zoo.GetMaxRunningSpeed()}");

        }
    }
}
