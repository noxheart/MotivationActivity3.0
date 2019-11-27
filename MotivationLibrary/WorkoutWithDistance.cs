using System;

namespace MotivationLibrary
{
    public class WorkoutWithDistance : Workout
    {
        public double DistanceKM { get; private set; }
        public WorkoutWithDistance(TypeOfWorkout workout, DateTime whenWorkedOut, double distanceKM, int minutesWorkOut, double points) : base(workout, whenWorkedOut ,minutesWorkOut, points)
        {
            this.DistanceKM = distanceKM;
        }
        
        public WorkoutWithDistance(int workoutType, DateTime whenWorkedOut, double distanceKM, int minutesWorkOut, double points) : base(workoutType, whenWorkedOut ,minutesWorkOut, points)
        {
            this.DistanceKM = distanceKM;
        }
    }
}
