namespace MotivationLibrary
{
    public class Print
    {
        public string PrintStatistic(Workout workout)//TODO FIX RETURN TO STRING INSTEAD
        {
            string textPrint = "";
            if (workout.GetType() == typeof(Strength))
            {
                 textPrint=$"\n{TypeOfWorkout.Strength.ToString()}\n";
            }
            else if (workout.GetType() == typeof(Walking) ||
            workout.GetType() == typeof(Running) ||
            workout.GetType() == typeof(Swimming))
            {
                WorkoutWithDistance workout1 = workout as WorkoutWithDistance;

                if (workout.GetType() == typeof(Walking))
                {
                    textPrint=$"\n{TypeOfWorkout.Walking.ToString()}\n";
                }
                else if (workout.GetType() == typeof(Running))
                {
                    textPrint=$"\n{TypeOfWorkout.Running.ToString()}\n";
                }
                else if (workout.GetType() == typeof(Swimming))
                {
                    textPrint=$"\n{TypeOfWorkout.Swimming.ToString()}\n";
                }
                textPrint+=$"Distans: {workout1.DistanceKM}\n";
            }
            
                textPrint+=$"Datum: {workout.WhenWorkOutOccured.ToString("yyyy/MM/dd")}\n" +
                $"Minuter: {workout.MinutesWorkedOut}\n" +
                $"Poäng: {workout.PointsForWorkout}\n";
                return textPrint;
        }
    }
}