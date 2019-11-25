using System;

namespace MotivationLibrary
{
    public class Strength: Workout
    {
       public Strength(DateTime whenWorkedOut, int minutesWorkOut, double points, TypeOfWorkout workout) : base(whenWorkedOut ,minutesWorkOut, points, workout)
        {
            this.WhenWorkOutOccured = whenWorkedOut;
        }
    }
}
