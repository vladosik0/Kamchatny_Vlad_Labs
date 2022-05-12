using System;
using System.Collections.Generic;


namespace Lab4_5_
{
   public abstract class FlightlessBird:Bird
    {
        public FlightlessBird(int age,double weight,int speed):base(age,weight,speed){}
        public override void Move()
        {
            Console.WriteLine($"I am a {GetType().Name} and I am a flightless bird, so I can't fly, but I can run\nMy speed is {Speed} km per hour");
        }
    }
}
