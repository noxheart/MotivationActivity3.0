using System;

namespace MotivationLibrary
{
    public abstract class Workout
    {
        public DateTime WhenWorkOutOccured { get; protected set; }
        public int MinutesWorkedOut { get; protected set; }
        public double pointsForWorkout { get; protected set; }
    
        public Workout(DateTime whenWorkedOut, int minutesWorkedOut, double points)
        {
            this.WhenWorkOutOccured = whenWorkedOut;
            this.MinutesWorkedOut = minutesWorkedOut;
            this.pointsForWorkout = points;
        }
    }
}
