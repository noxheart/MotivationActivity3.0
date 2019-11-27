using System;

namespace MotivationLibrary
{
    public class Print
    {
        public void PrintStatistic(Workout workout)//TODO FIX RETURN TO STRING INSTEAD
        {
            if (workout.GetType() == typeof(Strength))
            {
                Console.WriteLine($"{workout.WorkoutType.ToString()}\n" +
                $"Datum: {workout.WhenWorkOutOccured}\n" +
                $"Minuter: {workout.MinutesWorkedOut}\n" +
                $"Poäng: {workout.PointsForWorkout}\n");
            }
            else if (workout.GetType() == typeof(WorkoutWithDistance))
            {
                WorkoutWithDistance workout1 = workout as WorkoutWithDistance;

                Console.WriteLine($"{workout.WorkoutType.ToString()}\n" +
                $"Datum: {workout1.WhenWorkOutOccured}\n" +
                $"Minuter: {workout1.MinutesWorkedOut}\n" +
                $"Distans: {workout1.DistanceKM}\n" +
                $"Poäng: {workout1.PointsForWorkout}\n");
            }
        }
    }
}