using System;

namespace MotivationLibrary
{
    public class Print
    {
        public void PrintStatistic(Workout workout)//ALLA ANVÄNDARE //TODO FIX where  username like "username"
        {
            if ()
                Console.WriteLine($"{workout.WorkoutType.ToString()}\n" +
                $"Datum: {workout.WhenWorkOutOccured}\n" +
                $"Minuter: {workout.MinutesWorkedOut}\n" +
                $"Poäng: {workout.PointsForWorkout}\n");

            else
            {

            }
        }
    }
}