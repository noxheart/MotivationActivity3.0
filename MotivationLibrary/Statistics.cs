using System;

namespace MotivationLibrary
{
    public class Statistics
    {
        public void SeeAllStatistics()//ALLA ANVÄNDARE //TODO FIX where  username like "username"
        {
            var db = new Database("Server=40.85.84.155;Database=Student5;User=Student5;Password=YH-student@2019;");

            foreach (var workout in db.GetWorkouts())
            {
                Console.WriteLine(workout);
            }
        }
    }
}