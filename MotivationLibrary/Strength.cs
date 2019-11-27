using System;

namespace MotivationLibrary
{
    public class Strength: Workout
    {
       public Strength(TypeOfWorkout workout, DateTime whenWorkedOut, int minutesWorkOut, double points) : base(workout, whenWorkedOut ,minutesWorkOut, points)
        {
            this.WhenWorkOutOccured = whenWorkedOut;
        }
    }
}
