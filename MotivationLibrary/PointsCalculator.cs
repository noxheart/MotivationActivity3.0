using System;

namespace MotivationLibrary
{
    public class PointsCalculator
    {
        double pointsForWorkout;
        double level1;
        double level2;
        double level3;
        double timeLow;
        double timeHigh;
        int minWorkoutTime = 15;
        public double PointsForRunning(int time, double distance)
        {
            level1 = 1.75;
            level2 = 2;
            level3 = 2.25;
            timeLow = 5;
            timeHigh = 6;

            if (time / distance <= timeHigh && time / distance >= timeLow && time >= minWorkoutTime)
            {
                pointsForWorkout = time * level2;
            }
            else if (time / distance < timeLow && time >= minWorkoutTime)
            {
                pointsForWorkout = time * level3;
            }
            else 
            {
                pointsForWorkout = time * level1;
            }
            return pointsForWorkout;
        }
        public double PointsForWalking(int time, double distance)
        {
            level1 = 0.75;
            level2 = 1;
            level3 = 1.25;
            timeLow = 10;
            timeHigh = 12;

            if (time / distance <= timeHigh && time / distance >= timeLow && time >= minWorkoutTime)
            {
                pointsForWorkout = time * level2;
            }
            else if (time / distance < timeLow && time >= minWorkoutTime)
            {
                pointsForWorkout = time * level3;
            }
            else 
            {
                pointsForWorkout = time * level1;
            }
            return pointsForWorkout;
        }
        public double PointsForSwimming(int time, double distance)
        {
            level1 = 1.5;
            level2 = 1.75;
            level3 = 2;
            timeLow = 17.5;
            timeHigh = 24;

            if (time / distance <= timeHigh && time / distance >= timeLow && time >= minWorkoutTime)
            {
                pointsForWorkout = time * level2;
            }
            else if (time / distance < timeLow && time >= minWorkoutTime)
            {
                pointsForWorkout = time * level3;
            }
            else 
            {
                pointsForWorkout = time * level1;
            }
            return pointsForWorkout;
        }
        public double PointsForStength(int time)
        {
            level1 = 1.5;
            pointsForWorkout = time * level1;
            return pointsForWorkout;
        }
    }
}