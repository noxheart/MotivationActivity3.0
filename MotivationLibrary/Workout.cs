using System;

namespace MotivationLibrary
{
    public enum TypeOfWorkout { Walking = 1, Running, Swimming, Strength }
    public abstract class Workout
    {
        public DateTime WhenWorkOutOccured { get; protected set; }
        public int MinutesWorkedOut { get; protected set; }
        public double PointsForWorkout { get; protected set; }
        public int WorkoutType { get; protected set; }

        public Workout(DateTime whenWorkedOut, int minutesWorkedOut, double points, TypeOfWorkout workout)
        {
            this.WhenWorkOutOccured = whenWorkedOut;
            this.MinutesWorkedOut = minutesWorkedOut;
            this.PointsForWorkout = points;
            this.WorkoutType = (int)workout;
        }
        public void AddWorkout(User user)
        {
            var db = new Database("Server=40.85.84.155;Database=Student5;User=Student5;Password=YH-student@2019;");
            db.AddWorkouts(this, user);

        }
    }
}
