using System;

namespace MotivationLibrary
{
    public class Strength: Workout
    {
       public Strength(DateTime whenWorkedOut, int minutesWorkOut) : base(whenWorkedOut ,minutesWorkOut)
        {
        }

        public override double CalculatePoints(int time, double level)
        {
            double points;
            level = 1.5;
            points = time * level;
            return points;
        }
    }
}
