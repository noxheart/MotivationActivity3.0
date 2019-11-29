using System;

namespace MotivationLibrary
{
    public class WorkoutWithDistance : Workout
    {
        public double DistanceKM { get; private set; }
        /// <summary>
        /// constructor for inserting a workout
        /// </summary>
        /// <param name="workout"></param>
        /// <param name="whenWorkedOut"></param>
        /// <param name="distanceKM"></param>
        /// <param name="minutesWorkOut"></param>
        /// <param name="points"></param>
        /// <returns></returns>
        public WorkoutWithDistance(TypeOfWorkout workout, DateTime whenWorkedOut, double distanceKM, int minutesWorkOut, double points) : base(workout, whenWorkedOut ,minutesWorkOut, points)
        {
            this.DistanceKM = distanceKM;
        }
        /// <summary>
        /// constructor for statistics
        /// </summary>
        /// <param name="workoutType"></param>
        /// <param name="whenWorkedOut"></param>
        /// <param name="distanceKM"></param>
        /// <param name="minutesWorkOut"></param>
        /// <param name="points"></param>
        /// <returns></returns>
        public WorkoutWithDistance(int workoutType, DateTime whenWorkedOut, double distanceKM, int minutesWorkOut, double points) : base(workoutType, whenWorkedOut ,minutesWorkOut, points)
        {
            this.DistanceKM = distanceKM;
        }
    }
}
