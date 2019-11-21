using System;

namespace MotivationLibrary
{
    public class Walking : Workout
    {
        public double DistanceKM { get; private set; }
        public Walking(DateTime whenWorkedOut, double Distance, int minutesWorkOut, double points) : base(whenWorkedOut ,minutesWorkOut, points)
        {
            this.DistanceKM = Distance;
        }
    }
}
