using System;

namespace MotivationLibrary
{
    public class Print
    {
        public void PrintStatistic(Workout workout)//TODO FIX RETURN TO STRING INSTEAD
        {
            if (workout.GetType() == typeof(Strength))
            {
                Console.Write($"\n{TypeOfWorkout.Strength.ToString()}\n");
            }
            else if (workout.GetType() == typeof(Walking) ||
            workout.GetType() == typeof(Running) ||
            workout.GetType() == typeof(Swimming))
            {
                WorkoutWithDistance workout1 = workout as WorkoutWithDistance;

                if (workout.GetType() == typeof(Walking))
                {
                    Console.Write($"\n{TypeOfWorkout.Walking.ToString()}\n");
                }
                else if (workout.GetType() == typeof(Running))
                {
                    Console.Write($"\n{TypeOfWorkout.Running.ToString()}\n");
                }
                else if (workout.GetType() == typeof(Swimming))
                {
                    Console.Write($"\n{TypeOfWorkout.Swimming.ToString()}\n");
                }
                Console.Write($"Distans: {workout1.DistanceKM}\n");
            }
            Console.Write(
                $"Datum: {workout.WhenWorkOutOccured.ToString("yyyy/MM/dd")}\n" +
                $"Minuter: {workout.MinutesWorkedOut}\n" +
                $"Poäng: {workout.PointsForWorkout}\n");

        }
    }
}