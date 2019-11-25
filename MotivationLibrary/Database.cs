using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using Dapper;

namespace MotivationLibrary
{
    class Database
    {
        private readonly string connectionString;
        public Database(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public IEnumerable<Workout> GetWorkouts()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                return connection.Query<Workout>("Select * from SeeAllWorkouts");
            }
        }
        public void AddWorkouts(Workout workout)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            if(workout.GetType() == typeof(Strength))
            {
                connection.Query($"insert into WorkoutSaved (TypeOfWorkout, Person, Date, timeMinutes, points) " +
                 $"values {workout.GetType()}, User, {workout.WhenWorkOutOccured}, {workout.MinutesWorkedOut}, {workout.PointsForWorkout}");
                workout.distanceKM
            }
            else
            {
                connection.Query($"insert into WorkoutSaved (TypeOfWorkout, Person, Date, timeMinutes, points, distanceKM)" +
                 $"values {workout.GetType()}, User, {workout.WhenWorkOutOccured}, {workout.MinutesWorkedOut}, {workout.PointsForWorkout}, {}");            }
        }
    }
}