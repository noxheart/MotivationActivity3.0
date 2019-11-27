using System;

namespace MotivationLibrary
{
    public class WorkoutWithDistance : Workout
    {
        public double DistanceKM { get; private set; }
        public WorkoutWithDistance(TypeOfWorkout workout, DateTime whenWorkedOut, double Distance, int minutesWorkOut, double points) : base(workout, whenWorkedOut ,minutesWorkOut, points)
        {
            this.DistanceKM = Distance;
        }
    }
}
