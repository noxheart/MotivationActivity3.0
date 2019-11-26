using System;

namespace MotivationLibrary
{
    public class Statistics
    {
        public void SeeWorkoutStatistics()//ALLA ANVÄNDARE //TODO FIX where  username like "username"
        {
            var db = new Database("Server=40.85.84.155;Database=Student5;User=Student5;Password=YH-student@2019;");
            var print = new Print();

            foreach (var workout in db.GetWorkouts())
            {
                print.PrintStatistic(workout);
            }
        }
    }
}