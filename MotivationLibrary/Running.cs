using System;

namespace MotivationLibrary
{
    public class Running: Workout
    {
       public double DistanceKM {get; private set;}
       public Running(DateTime whenWorkedOut, double Distance, int minutesWorkOut, double points,TypeOfWorkout workout) : base(whenWorkedOut ,minutesWorkOut, points, workout)
        {
            this.WhenWorkOutOccured = whenWorkedOut;
            this.DistanceKM = Distance;
            this.MinutesWorkedOut = minutesWorkOut; 
        }       
    }
}
