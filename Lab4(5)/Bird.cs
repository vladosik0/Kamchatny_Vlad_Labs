using System;
using System.Collections.Generic;

namespace Lab4_5_
{
  public abstract class Bird
    {
        public int Age { get; set; }
        public double Weight { get; set; }
        public int Speed { get; set; }
        public Bird(int age, double weight,int speed)
            {
              Age = age;
              Weight = weight;
              Speed = speed;
            }
        public abstract void Move();
    }

}
