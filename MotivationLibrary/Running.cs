using System;

namespace MotivationLibrary
{
    public class Running: Workout
    {
       public double DistanceKM {get; private set;}
       public Running(DateTime whenWorkedOut, double Distance, int minutesWorkOut, double points) : base(whenWorkedOut ,minutesWorkOut, points)
        {
            this.WhenWorkOutOccured = whenWorkedOut;
            this.DistanceKM = Distance;
            this.MinutesWorkedOut = minutesWorkOut; 
        }       
    }
}
