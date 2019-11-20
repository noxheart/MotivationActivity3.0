using System;

namespace MotivationLibrary
{
    public class Swimming: Workout
    {
       public double DistanceKM {get; private set;}
       public Swimming(DateTime whenWorkedOut, double Distance, int minutesWorkOut) : base(whenWorkedOut ,minutesWorkOut)
        {
            this.DistanceKM = Distance;
        }
    }
}