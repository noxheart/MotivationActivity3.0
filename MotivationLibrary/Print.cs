using System;

namespace MotivationLibrary
{
    public class Print
    {
        public void PrintStatistic(Workout workout)
        {
            if (workout.GetType() == typeof(Strength))
            {
                Console.WriteLine($"{workout.WorkoutType.ToString()}\n" +
                $"Datum: {workout.WhenWorkOutOccured}\n" +
                $"Minuter: {workout.MinutesWorkedOut}\n" +
                $"Poäng: {workout.PointsForWorkout}\n");
            }
            else //if it's walking,runnig, swimming
            {
                Console.WriteLine($"{workout.WorkoutType.ToString()}\n" +
                $"Datum: {workout.WhenWorkOutOccured}\n" +
                $"Minuter: {workout.MinutesWorkedOut}\n" +
                $"Poäng: {workout.PointsForWorkout}\n");
                //TODO DISTANCE
            }
        }
    }
}