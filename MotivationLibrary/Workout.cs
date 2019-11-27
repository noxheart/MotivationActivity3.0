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
        //Konstruktor för statistik
        public Workout(int workoutType, DateTime whenWorkedOut, int minutesWorkOut, double points)
        {
            this.WhenWorkOutOccured = whenWorkedOut;
            this.MinutesWorkedOut = minutesWorkOut;
            this.PointsForWorkout = points;
            this.WorkoutType = workoutType;
        }
        //Konstruktor för insert
        public Workout(TypeOfWorkout Workout, DateTime WhenWorkedOut, int MinutesWorkedOut, double Points)
        {
            this.WhenWorkOutOccured = WhenWorkedOut;
            this.MinutesWorkedOut = MinutesWorkedOut;
            this.PointsForWorkout = Points;
            this.WorkoutType = (int)Workout;
        }
        public void AddWorkout(User user)
        {
            var db = new Database("Server=40.85.84.155;Database=Student5;User=Student5;Password=YH-student@2019;");
            db.AddWorkouts(this, user);
        }
    }
}
