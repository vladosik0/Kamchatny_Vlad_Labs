using System;
using System.Collections.Generic;
namespace Lab4_5_
{
    public abstract class FlyingBird:Bird
    {
        public FlyingBird(int age, double weight, int speed) : base(age, weight,speed){}
        public override void Move()
        {
            Console.WriteLine($"I am a {GetType().Name} and I am a flying bird, so I can fly\nMy speed is {Speed} km per hour");
        }
    }
}
