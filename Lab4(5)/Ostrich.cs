using System;
using System.Collections.Generic;


namespace Lab4_5_
{
   public class Ostrich:FlightlessBird
    {
        public Ostrich(int age,double weight, int speed) : base(age,weight, speed) { }
        public void HideHeadInSand()
        {
            Console.WriteLine("I am an ostrich and I hide my head in sand");
        }
    }
}
