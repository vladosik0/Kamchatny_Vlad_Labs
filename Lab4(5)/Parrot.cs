using System;
using System.Collections.Generic;


namespace Lab4_5_
{
    public class Parrot:FlyingBird
    {
        private string name; 
        public Parrot(int age, double weight, int speed,string name) : base(age, weight,speed)
        {
            this.name = name;
        }
        public void SayName()
        {
            Console.WriteLine($"I am a parrot and my name is {name}");
        }
    }
}
