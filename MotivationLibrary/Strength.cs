using System;

namespace MotivationLibrary
{
    public class Strength: Workout
    {
       public Strength(TypeOfWorkout workout, DateTime whenWorkedOut, int minutesWorkOut, double points) : base(workout, whenWorkedOut ,minutesWorkOut, points)
        {

        }
       public Strength(int WorkoutType, DateTime WhenWorkOutOccured, int MinutesWorkedOut, double PointsForWorkout) : base(WorkoutType, WhenWorkOutOccured ,MinutesWorkedOut, PointsForWorkout)
        {

        }
    }
}
