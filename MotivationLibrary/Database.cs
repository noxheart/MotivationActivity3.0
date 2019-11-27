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
        public IEnumerable<Workout> GetWorkouts(User user)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                return connection.Query<Workout>($"Select * from SeeAllWorkouts where user = {user.ID}");
            }
        }
        public IEnumerable<Workout> GetWorkouts(Group group)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                return connection.Query<Workout>("Select * from SeeAllWorkouts ");//TODO FIX
            }
        }
        public void AddWorkouts(Workout workout, User user)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
                if (workout.GetType() == typeof(Strength))
                {
                    connection.Query($"dbo.InsertWorkout {workout.WorkoutType}, {user.ID}, '{workout.WhenWorkOutOccured}', {workout.MinutesWorkedOut}, '{workout.PointsForWorkout.ToString()}', '{null}'");
                }
                else
                {
                    //TODO FIX ME
                    connection.Query($"insert into WorkoutSaved (TypeOfWorkout, Person, Date, timeMinutes, points, distanceKM)" +
                     $"values ({workout.WorkoutType}, {user.ID}, '{workout.WhenWorkOutOccured}', {workout.MinutesWorkedOut}, {Convert.ToDouble(workout.PointsForWorkout.ToString().Replace(",", "."))}");
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
        }
  
    }
}