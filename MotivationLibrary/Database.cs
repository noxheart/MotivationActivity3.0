using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using Dapper;

namespace MotivationLibrary
{
    class DataBase
    {
        private readonly string connectionString;
        public DataBase(string connectionString)
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
        public void AddWorkout(User user, Workout workout)
        {
            
        }
    }
}