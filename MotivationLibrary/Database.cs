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
        public List<Workout> GetWorkouts(User user)
        {
            List<Workout> workouts = new List<Workout>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<Walking> walking = connection.Query<Walking>($"dbo.SeeWorkout {user.ID}, {Convert.ToInt32(TypeOfWorkout.Walking)}").AsList();
                 workouts.AddRange(walking);
                
                List<Running> running = connection.Query<Running>($"dbo.SeeWorkout {user.ID}, {Convert.ToInt32(TypeOfWorkout.Running)}").AsList();
                 workouts.AddRange(running);
                
                List<Swimming> swimming = connection.Query<Swimming>($"dbo.SeeWorkout {user.ID}, {Convert.ToInt32(TypeOfWorkout.Swimming)}").AsList();
                workouts.AddRange(swimming);

                List<Strength> strength = connection.Query<Strength>($"dbo.SeeWorkoutStrengthOnly {user.ID}, {Convert.ToInt32(TypeOfWorkout.Strength)}").AsList();
                workouts.AddRange(strength);
            }
            return workouts;
        }
        public IEnumerable<Workout> GetWorkouts(Group group)//TODO MAYBE
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
                else if (workout.GetType() == typeof(WorkoutWithDistance))
                {
                    WorkoutWithDistance workout1 = workout as WorkoutWithDistance;

                    connection.Query($"insert into WorkoutSaved (TypeOfWorkout, Person, Date, timeMinutes, points, distanceKM)" +
                     $"values ({workout1.WorkoutType}, {user.ID}, '{workout1.WhenWorkOutOccured}', {workout1.MinutesWorkedOut}, '{workout1.PointsForWorkout.ToString()}', {workout1.DistanceKM.ToString()}");
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