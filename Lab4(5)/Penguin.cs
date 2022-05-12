using System;
using System.Collections.Generic;


namespace Lab4_5_
{
    public class Penguin:FlightlessBird
    {
        public int NumberOfEggs { get; set; }
        public Penguin(int age,double weight, int speed,int numberOfEggs) : base(age,weight, speed) { NumberOfEggs = numberOfEggs; }
        public void SitOnEggs()
        {
            Console.WriteLine($"I am a penguin and I am sitting on my {NumberOfEggs} eggs right now");
        }
    }
}
