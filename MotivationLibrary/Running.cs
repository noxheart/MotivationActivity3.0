using System;

namespace MotivationLibrary
{
    public class Running : WorkoutWithDistance
    {
        public Running(TypeOfWorkout workout, DateTime whenWorkedOut, int minutesWorkOut, double points,double Distance) : base(workout, whenWorkedOut , Distance ,minutesWorkOut, points)
        {

        }
        public Running(int WorkoutType, DateTime WhenWorkOutOccured, int MinutesWorkedOut, double PointsForWorkout,double DistanceKM) : base(WorkoutType, WhenWorkOutOccured , DistanceKM ,MinutesWorkedOut, PointsForWorkout)
        {

        }
    }
}
