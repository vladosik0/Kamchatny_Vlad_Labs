using System;
using System.Collections.Generic;

namespace Lab4_5_
{
    public class Eagle:FlyingBird
    {
        public bool IsHungry { get; set; }
        public Eagle(int age, double weight, int speed): base(age,weight,speed){}
        public void Hunt()
        {
            if (IsHungry)
            {
                Console.WriteLine("I am an eagle and I am looking for food right now");
            }
            else
            {
                Console.WriteLine("I am an eagle and I'm not hungry right now");
            }
        }
    }
}
