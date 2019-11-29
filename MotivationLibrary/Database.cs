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
        /// <summary>
        /// returns all workouts in a list. Search where user = user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
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
        /// <summary>
        /// returns workouts in ienumerable where group is found
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        public IEnumerable<Workout> GetWorkouts(Group group)//TODO
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                return connection.Query<Workout>("Select * from SeeAllWorkouts ");//TODO FIX
            }
        }
        /// <summary>
        /// adds created workout from specific user
        /// </summary>
        /// <param name="workout"></param>
        /// <param name="user"></param>
        public void AddWorkouts(Workout workout, User user)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
                if (workout.GetType() == typeof(Strength))
                {
                    connection.Query($"dbo.InsertWorkout {workout.WorkoutType}, {user.ID}, '{workout.WhenWorkOutOccured}', {workout.MinutesWorkedOut}, '{workout.PointsForWorkout.ToString()}', '{null}'");
                }
                else if (workout.GetType() == typeof(Walking) ||
                workout.GetType() == typeof(Running) ||
                workout.GetType() == typeof(Swimming))
                {
                    WorkoutWithDistance workout1 = workout as WorkoutWithDistance;
                    connection.Query($"dbo.InsertWorkout {workout1.WorkoutType}, {user.ID}, '{workout1.WhenWorkOutOccured}', {workout1.MinutesWorkedOut}, '{workout1.PointsForWorkout.ToString()}', '{workout1.DistanceKM.ToString()}'");
                }
        }
        /// <summary>
        /// takes username and password and tries to login. if it works it returns user or else returns void
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
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