using System;

namespace MotivationLibrary
{
    public class Strength: Workout
    {
       public Strength(DateTime whenWorkedOut, int minutesWorkOut, double points) : base(whenWorkedOut ,minutesWorkOut, points)
        {
            this.WhenWorkOutOccured = whenWorkedOut;
        }
    }
}
