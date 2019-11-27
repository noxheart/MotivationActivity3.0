using System;

namespace MotivationLibrary
{
    public class Statistics
    {
        double Points { get; set; }
        public void SeeWorkoutStatistics(User user)
        {
            var db = new Database("Server=40.85.84.155;Database=Student5;User=Student5;Password=YH-student@2019;");
            var print = new Print();

            foreach (var workout in db.GetWorkouts(user))
            {
                print.PrintStatistic(workout);
            }
        }
        public void SeeWorkoutStatistics(Group group)
        {
            var db = new Database("Server=40.85.84.155;Database=Student5;User=Student5;Password=YH-student@2019;");
            var print = new Print();

            foreach (var workout in db.GetWorkouts(group))
            {
                print.PrintStatistic(workout);
            }
        }
        public double WorkOutPointsFor(int days, User user)
        {
            var db = new Database("Server=40.85.84.155;Database=Student5;User=Student5;Password=YH-student@2019;");
            double i = 0;
            foreach (var workout in db.GetWorkouts(user))
            {
            }
            //TODO skicka rätt double
            return i;
        }
    }
}