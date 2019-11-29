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
        /// <summary>
        /// constructor for statistics
        /// </summary>
        /// <param name="workoutType"></param>
        /// <param name="whenWorkedOut"></param>
        /// <param name="minutesWorkOut"></param>
        /// <param name="points"></param>
        public Workout(int workoutType, DateTime whenWorkedOut, int minutesWorkOut, double points)
        {
            this.WhenWorkOutOccured = whenWorkedOut;
            this.MinutesWorkedOut = minutesWorkOut;
            this.PointsForWorkout = points;
            this.WorkoutType = workoutType;
        }
        /// <summary>
        /// constructor for creating workout
        /// </summary>
        /// <param name="Workout"></param>
        /// <param name="WhenWorkedOut"></param>
        /// <param name="MinutesWorkedOut"></param>
        /// <param name="Points"></param>
        public Workout(TypeOfWorkout Workout, DateTime WhenWorkedOut, int MinutesWorkedOut, double Points)
        {
            this.WhenWorkOutOccured = WhenWorkedOut;
            this.MinutesWorkedOut = MinutesWorkedOut;
            this.PointsForWorkout = Points;
            this.WorkoutType = (int)Workout;
        }
        /// <summary>
        /// add workout for specific user. Takes us to database
        /// </summary>
        /// <param name="user"></param>
        public void AddWorkout(User user)
        {
            var db = new Database("Server=40.85.84.155;Database=Student5;User=Student5;Password=YH-student@2019;");
            db.AddWorkouts(this, user);
        }
    }
}
