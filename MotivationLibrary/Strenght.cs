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
    }
}
