using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_5_
{
    public class Zoo
    {
        List<Bird> birds=new List<Bird>();

        public void AddBird(Bird bird)
        {
            birds.Add(bird);
        }
        public int GetMaxFlyingSpeed()
        {
            if(birds.Count==0)
            {
                Console.WriteLine("No birds in a zoo!!!");
                return 0;
            }
           List<int> speeds = new List<int>();
            foreach(var bird in birds)
            {
                if(bird is FlyingBird)
                {
                    speeds.Add(bird.Speed);
                }
            }
            return speeds.Max();
        }
        public int GetMaxRunningSpeed()
        {
            if (birds.Count == 0)
            {
                Console.WriteLine("No birds in a zoo!!!");
                return 0;
            }
            List<int> speeds = new List<int>();
            foreach (var bird in birds)
            {
                if (bird is FlightlessBird)
                {
                    speeds.Add(bird.Speed);
                }
            }
            return speeds.Max();
        }

    }
}
