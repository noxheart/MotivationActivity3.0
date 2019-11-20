using System;

namespace MotivationLibrary
{
    public class Strength: Workout
    {
       public int StrengthLevel {get; private set;}
       public Strength(DateTime whenWorkedOut, int StrengthLevel, int minutesWorkOut) : base(whenWorkedOut ,minutesWorkOut)
        {
            this.StrengthLevel = StrengthLevel;
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
