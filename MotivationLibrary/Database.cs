using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using Dapper;
using System.Linq;

namespace MotivationLibrary
{
    public class Database
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
                if (workout.GetType() == typeof(Strength))
                {
                    connection.Query($"insert into WorkoutSaved (TypeOfWorkout, Person, Date, timeMinutes, points) " +
                     $"values {workout.GetType()}, User, {workout.WhenWorkOutOccured}, {workout.MinutesWorkedOut}, {workout.PointsForWorkout}");
                }
                else
                {
                    connection.Query($"insert into WorkoutSaved (TypeOfWorkout, Person, Date, timeMinutes, points, distanceKM)" +
                     $"values {workout.GetType()}, User, {workout.WhenWorkOutOccured}, {workout.MinutesWorkedOut}, {workout.PointsForWorkout}");
                }
        }
        public User GetLogin(string UserName, string Password)
        {
            //int numberOfTrueLogin;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                return connection.Query<User>($"EXEC GETUSER @UserName = '{UserName}', @Password = '{Password}';").First();  
                }
                catch
                {
                    return null;
                }
                    
            }
            /*if (numberOfTrueLogin > 0)
            {
                return true;
            }
            else
            {
                return false;
            }*/
        }
        public IEnumerable<User> GetUser(string UserName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                return connection.Query<User>($"Select * from Person where UserName = '{UserName}';");
            }
        } 
    }
}