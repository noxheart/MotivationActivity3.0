using System;

namespace MotivationLibrary
{
    public class User
    {
        public int ID { get; private set; }
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public double WeightKG { get; private set; }
        public double LengthCM { get; private set; }
        public int PointsGoal { get; private set; }

        public User()
        {
            
        }
    }
}
