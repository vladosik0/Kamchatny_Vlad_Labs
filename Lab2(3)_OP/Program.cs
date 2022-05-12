using System;

namespace Lab2_3__OP
{
    class Program
    {
           
        static void Main(string[] args)
        {
            Bird woodpecker = new Bird("Woodpecker", 300.5f);
            Bird pigeon = new Bird("Pigeon", 500.8f);
            Bird woodpecker2 = new Bird("Woodpecker",300.5f);
            woodpecker.Land();
            woodpecker.Fly();
            woodpecker.Eat();
            woodpecker.Attack();
            Console.WriteLine(woodpecker);
            Console.WriteLine(woodpecker.Equals(woodpecker2));
            Console.WriteLine(woodpecker.Equals(pigeon));
            Console.WriteLine(woodpecker.GetHashCode());
            Console.WriteLine(woodpecker2.GetHashCode());
            Console.WriteLine(pigeon.GetHashCode());


        }
    }
}
