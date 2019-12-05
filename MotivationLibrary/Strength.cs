using System;

namespace MotivationLibrary
{
    public class Strength : Workout
    {
        /// <summary>
        /// constructor for inserting a workout
        /// </summary>
        /// <param name="workout"></param>
        /// <param name="whenWorkedOut"></param>
        /// <param name="minutesWorkOut"></param>
        /// <param name="points"></param>
        /// <returns></returns>
        public Strength(TypeOfWorkout workout, DateTime whenWorkedOut, int minutesWorkOut,
        double points) : base(workout, whenWorkedOut, minutesWorkOut, points)
        {

        }
        /// <summary>
        /// constructor for statistics
        /// </summary>
        /// <param name="WorkoutType"></param>
        /// <param name="WhenWorkOutOccured"></param>
        /// <param name="MinutesWorkedOut"></param>
        /// <param name="PointsForWorkout"></param>
        /// <returns></returns>
        public Strength(int WorkoutType, DateTime WhenWorkOutOccured, int MinutesWorkedOut,
        double PointsForWorkout) : base(WorkoutType, WhenWorkOutOccured, MinutesWorkedOut,
        PointsForWorkout)
        {

        }
    }
}
