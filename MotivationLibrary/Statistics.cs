using System;
using System.Globalization;
using System.Collections.Generic;

namespace MotivationLibrary
{
    public class Statistics
    {
        private double Points { get; set; }
        /// <summary>
        /// 
        /// //returns list of strings for every workout that is found in our database for specific user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public List<string> SeeWorkoutStatistics(User user)
        {
            var db = new Database("Server=40.85.84.155;Database=Student5;User=Student5;Password=YH-student@2019;");
            var print = new Print();
            List<String> listToSend = new List<String>();

            foreach (var workout in db.GetWorkouts(user))
            {
                listToSend.Add(print.PrintStatistic(workout));
            }
            return listToSend;
        }
        /// <summary>
        /// 
        /// in progress
        /// </summary>
        /// <param name="group"></param>
        public void SeeWorkoutStatistics(Group group)
        {
            var db = new Database("Server=40.85.84.155;Database=Student5;User=Student5;Password=YH-student@2019;");
            var print = new Print();

            foreach (var workout in db.GetWorkouts(group))
            {
                print.PrintStatistic(workout);
            }
        }
        /// <summary>
        /// returns a double where workout is for this week
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
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
        /// <summary>
        /// checks if workout date is in the same week and year as todays date
        /// </summary>
        /// <param name="workOutDate"></param>
        /// <returns></returns>
        private bool CheckWeeks(DateTime workOutDate)
        {
            DateTimeFormatInfo dateTimeFormat = CultureInfo.GetCultureInfo("sv-SE").DateTimeFormat;
            Calendar calendar = dateTimeFormat.Calendar;
            int workOutWeek = calendar.GetWeekOfYear(workOutDate, dateTimeFormat.CalendarWeekRule, dateTimeFormat.FirstDayOfWeek);
            int currentWeek = calendar.GetWeekOfYear(DateTime.Now, dateTimeFormat.CalendarWeekRule, dateTimeFormat.FirstDayOfWeek);
            int workoutYear = calendar.GetYear(workOutDate);
            int currentYear = calendar.GetYear(DateTime.Now);
            return workOutWeek == currentWeek && workoutYear == currentYear;
        }
    }
}