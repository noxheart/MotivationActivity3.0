using System;

namespace MotivationLibrary
{
    public class Swimming : WorkoutWithDistance
    {
        public Swimming(TypeOfWorkout workout, DateTime whenWorkedOut, int minutesWorkOut, double points,double Distance) : base(workout, whenWorkedOut , Distance ,minutesWorkOut, points)
        {

        }
    }
}
