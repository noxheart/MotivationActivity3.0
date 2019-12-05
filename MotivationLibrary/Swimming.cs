using System;

namespace MotivationLibrary
{
    public class Swimming : WorkoutWithDistance
    {
        /// <summary>
        /// constructor for inserting a workout
        /// </summary>
        /// <param name="workout"></param>
        /// <param name="WhenWorkedOut"></param>
        /// <param name="MinutesWorkOut"></param>
        /// <param name="Points"></param>
        /// <param name="DistanceKM"></param>
        /// <returns></returns>
        public Swimming(TypeOfWorkout workout, DateTime WhenWorkedOut, int MinutesWorkOut, 
        double Points,double DistanceKM) : base(workout, WhenWorkedOut , DistanceKM ,
        MinutesWorkOut, Points)
        {

        }
        /// <summary>
        /// constructor for statistic
        /// </summary>
        /// <param name="WorkoutType"></param>
        /// <param name="WhenWorkOutOccured"></param>
        /// <param name="MinutesWorkedOut"></param>
        /// <param name="PointsForWorkout"></param>
        /// <param name="DistanceKM"></param>
        /// <returns></returns>
        public Swimming(int WorkoutType, DateTime WhenWorkOutOccured, int MinutesWorkedOut, 
        double PointsForWorkout,double DistanceKM) : base(WorkoutType, WhenWorkOutOccured, 
        DistanceKM ,MinutesWorkedOut, PointsForWorkout)
        {

        }
    }
}
