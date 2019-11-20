using System;

namespace MotivationLibrary
{
    public class Walking : Workout
    {
        public double DistanceKM { get; private set; }
        public Walking(DateTime whenWorkedOut, double Distance, int minutesWorkOut) : base(whenWorkedOut ,minutesWorkOut)
        {
            this.DistanceKM = Distance;
        }

        public override  double CalculatePoints(int time, double distance)
        {
            double points = 0;
            
            if (time / distance <= 6 && time / distance >= 5 && time >= 15)
            {
                points = time * 2;
            }
            else if (time / distance < 5 && time >= 15)
            {
                points = time * 2.25;
            }
            else 
            {
                points = time * 1.75;
            }
            return points;
        }
    }
}
