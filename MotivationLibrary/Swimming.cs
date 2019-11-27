using System;

namespace MotivationLibrary
{
    public class Swimming : WorkoutWithDistance
    {
        public Swimming(TypeOfWorkout workout, DateTime WhenWorkedOut, int MinutesWorkOut, double Points,double DistanceKM) : base(workout, WhenWorkedOut , DistanceKM ,MinutesWorkOut, Points)
        {

        }
        public Swimming(int WorkoutType, DateTime WhenWorkOutOccured, int MinutesWorkedOut, double PointsForWorkout,double DistanceKM) : base(WorkoutType, WhenWorkOutOccured , DistanceKM ,MinutesWorkedOut, PointsForWorkout)
        {

        }
    }
}
