using System;

namespace MotivationLibrary
{
    public class Print
    {
        public void PrintStatistic(Workout workout)//TODO FIX RETURN TO STRING INSTEAD
        {
            if (workout.GetType() == typeof(Strength))
            {
                Console.WriteLine($"{TypeOfWorkout.Strength.ToString()}\n");
            }
            else if (workout.GetType() == typeof(WorkoutWithDistance))
            {
                WorkoutWithDistance workout1 = workout as WorkoutWithDistance;

                if (workout.GetType() == typeof(Walking))
                {
                    Console.WriteLine($"{TypeOfWorkout.Walking.ToString()}\n");
                }
                else if (workout.GetType() == typeof(Running))
                {
                    Console.WriteLine($"{TypeOfWorkout.Running.ToString()}\n");
                }
                else if (workout.GetType() == typeof(Swimming))
                {
                    Console.WriteLine($"{TypeOfWorkout.Swimming.ToString()}\n");
                }
                Console.WriteLine($"Distans: {workout1.DistanceKM}\n");
            }
            Console.WriteLine(
                $"Datum: {workout.WhenWorkOutOccured}\n" +
                $"Minuter: {workout.MinutesWorkedOut}\n" +
                $"Poäng: {workout.PointsForWorkout}\n");
        }
    }
}