using System;
using System.Globalization;

namespace MotivationLibrary
{
    public class Statistics
    {
        double Points { get; set; }
        public string SeeWorkoutStatistics(User user)
        {
            var db = new Database("Server=40.85.84.155;Database=Student5;User=Student5;Password=YH-student@2019;");
            var print = new Print();
            string textToPrint = "";

            foreach (var workout in db.GetWorkouts(user))
            {
                textToPrint += print.PrintStatistic(workout);
            }
            return textToPrint;
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
        public double WorkOutPointsFor(User user)
        {
            var db = new Database("Server=40.85.84.155;Database=Student5;User=Student5;Password=YH-student@2019;");
            double i = 0;
            foreach (var workout in db.GetWorkouts(user))
            {
                bool sameWeek = CheckWeeks(workout.WhenWorkOutOccured);
                if (sameWeek == true)
                {
                    i = i + workout.PointsForWorkout;
                }
            }
            //TODO skicka rätt double
            return i;
        }
        public bool CheckWeeks(DateTime workOutDate)
        {
            DateTimeFormatInfo dateTimeFormat = CultureInfo.GetCultureInfo("sv-SE").DateTimeFormat;
            Calendar calendar = dateTimeFormat.Calendar;
            int workOutWeek = calendar.GetWeekOfYear(workOutDate, dateTimeFormat.CalendarWeekRule, dateTimeFormat.FirstDayOfWeek);
            int currentWeek = calendar.GetWeekOfYear(DateTime.Now, dateTimeFormat.CalendarWeekRule, dateTimeFormat.FirstDayOfWeek);
            return workOutWeek == currentWeek;
        }
    }
}