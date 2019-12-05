namespace MotivationLibrary
{
    public class PointsCalculator
    {
        private double pointsForWorkout;
        private double level1;
        private double level2;
        private double level3;
        private double minimumTime;
        private double maximumTime; 
        private int minimumWorkoutTime = 15;
        public double PointsForRunning(int time, double distance)
        {
            level1 = 1.75;
            level2 = 2;
            level3 = 2.25;
            minimumTime = 5;
            maximumTime = 6;

            if (time / distance <= maximumTime && time / distance >= minimumTime && time >= minimumWorkoutTime)
            {
                pointsForWorkout = time * level2;
            }
            else if (time / distance < minimumTime && time >= minimumWorkoutTime)
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
            minimumTime = 10;
            maximumTime = 12;

            if (time / distance <= maximumTime && time / distance >= minimumTime && time >= minimumWorkoutTime)
            {
                pointsForWorkout = time * level2;
            }
            else if (time / distance < minimumTime && time >= minimumWorkoutTime)
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
            minimumTime = 17.5;
            maximumTime = 24;

            if (time / distance <= maximumTime && time / distance >= minimumTime && time >= minimumWorkoutTime)
            {
                pointsForWorkout = time * level2;
            }
            else if (time / distance < minimumTime && time >= minimumWorkoutTime)
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