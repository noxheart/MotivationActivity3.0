using System;

namespace MotivationLibrary
{
    public class Running : WorkoutWithDistance
    {
        /// <summary>
        /// constructor for inserting a workout
        /// </summary>
        /// <param name="workout"></param>
        /// <param name="whenWorkedOut"></param>
        /// <param name="minutesWorkOut"></param>
        /// <param name="points"></param>
        /// <param name="Distance"></param>
        /// <returns></returns>
        public Running(TypeOfWorkout workout, DateTime whenWorkedOut, int minutesWorkOut, double points,double Distance) : base(workout, whenWorkedOut , Distance ,minutesWorkOut, points)
        {

        }
        /// <summary>
        /// constructor for statistics
        /// </summary>
        /// <param name="WorkoutType"></param>
        /// <param name="WhenWorkOutOccured"></param>
        /// <param name="MinutesWorkedOut"></param>
        /// <param name="PointsForWorkout"></param>
        /// <param name="DistanceKM"></param>
        /// <returns></returns>
        public Running(int WorkoutType, DateTime WhenWorkOutOccured, int MinutesWorkedOut, double PointsForWorkout,double DistanceKM) : base(WorkoutType, WhenWorkOutOccured , DistanceKM ,MinutesWorkedOut, PointsForWorkout)
        {

        }
    }
}
