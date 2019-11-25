using System;

namespace MotivationLibrary
{
    public abstract class Workout
    {
        public DateTime WhenWorkOutOccured { get; protected set; }
        public int MinutesWorkedOut { get; protected set; }
        public double PointsForWorkout { get; protected set; }

        public Workout(DateTime whenWorkedOut, int minutesWorkedOut, double points)
        {
            this.WhenWorkOutOccured = whenWorkedOut;
            this.MinutesWorkedOut = minutesWorkedOut;
            this.PointsForWorkout = points;
        }
        public void AddWorkout()
        {
            var db = new Database("Server=40.85.84.155;Database=Student5;User=Student5;Password=YH-student@2019;");
            db.AddWorkouts(this);

        }
    }
}
