using System;

namespace MotivationLibrary
{
    public class Running: Workout
    {
       public double DistanceKM {get; private set;}
       public Running(DateTime whenWorkedOut, double Distance, int minutesWorkOut) : base(whenWorkedOut ,minutesWorkOut)
        {
            this.DistanceKM = Distance;
        }
    }
}
