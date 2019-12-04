using System;
using MotivationLibrary;
using ErrorCapture;
using System.Collections.Generic;

namespace MotivationProgram
{
    class Menu
    {
        private enum MenuMain { Quit, AddWorkout, Statistic, Group, User }
        private enum MenuGroup { Quit = 0, CreatGroup, JoinGroup, LeaveGroup, Compete }
        private enum MenuUser { Quit = 0, ChangeUserInfo, ChangeGoals }
        private enum MenuStatistic { Quit = 0, Personal, Group }
        PointsCalculator pointsCalculator = new PointsCalculator();
        Group Group = new Group();
        public void MainMenu(User user)
        {
            MenuMain userChoice = 0;
            bool mainMenuLoop = true;
            while (mainMenuLoop)
            {
                Console.Clear();//RENSAR FÖREGÅENDE MENY FÖR LÄTTARE LÄSNING.

                PointsInformationForUser(user);

                //TODO Ge information om användaren, namn, poäng etc.
                Console.WriteLine($"{Convert.ToInt32(MenuMain.AddWorkout)}. Registrera träning");
                Console.WriteLine($"{Convert.ToInt32(MenuMain.Statistic)}. Statistik");
                Console.WriteLine($"{Convert.ToInt32(MenuMain.Group)}. Grupp");
                Console.WriteLine($"{Convert.ToInt32(MenuMain.User)}. Profil");
                Console.WriteLine($"{Convert.ToInt32(MenuMain.Quit)}. Logga ut");
                Console.Write("Ditt val: ");
                int input = TryErrors.TryInt();
                userChoice = (MenuMain)input;



                switch (userChoice)
                {
                    case MenuMain.AddWorkout:
                        AddWorkoutInputMenu(user);
                        break;
                    case MenuMain.Statistic:
                        StatisticMenu(user);
                        Console.Write("\nTryck valfri tangent för att fortsätta.");
                        Console.ReadKey();
                        break;
                    case MenuMain.Group:
                        GroupMenu();
                        break;
                    case MenuMain.User:
                        break;
                    case MenuMain.Quit:
                        mainMenuLoop = false;
                        break;
                    default:
                        Console.Clear();
                        TryErrors.ErrorMessage();
                        break;
                }
            }
        }
        void AddWorkoutInputMenu(User user)
        {
            DateTime whenWorkedOut;
            double distance = 0;
            int minutesWorkedOut;
            bool happyWithChoice;
            double points = 0;

            Console.Clear();//RENSAR FÖREGÅENDE MENY FÖR LÄTTARE LÄSNING.

            Console.WriteLine("När tränade du? (åååå-mm-dd)");
            Console.Write("Datum: ");
            whenWorkedOut = TryErrors.TryTime();

            Console.Clear();

            Console.WriteLine("Vilken typ av träning önskar du registrera?");
            Console.WriteLine($"{Convert.ToInt32(TypeOfWorkout.Walking)}. Gång");
            Console.WriteLine($"{Convert.ToInt32(TypeOfWorkout.Running)}. Löpning");
            Console.WriteLine($"{Convert.ToInt32(TypeOfWorkout.Swimming)}. Simning");
            Console.WriteLine($"{Convert.ToInt32(TypeOfWorkout.Strength)}. Styrketräning");
            TypeOfWorkout workoutChoice = GetChoiceFromUser();
            Console.Clear();

            if (workoutChoice == TypeOfWorkout.Walking || workoutChoice == TypeOfWorkout.Running ||
            workoutChoice == TypeOfWorkout.Swimming)
            {
                Console.Write("Distans i KM: ");
                distance = TryErrors.TryDouble();
                Console.Clear();
            }

            Console.Write("Träningstid i minuter: ");
            minutesWorkedOut = TryErrors.TryInt();
            Console.Clear();

            Console.Write("Är du nöjd med träningen (J/N)?");
            happyWithChoice = TryErrors.TryYesOrNo();
            Console.Clear();

            if (happyWithChoice == true)
            {
                var db = new Database("Server=40.85.84.155;Database=Student5;User=Student5;Password=YH-student@2019;");
                if (workoutChoice == TypeOfWorkout.Walking)
                {
                    points = pointsCalculator.PointsForWalking(minutesWorkedOut, distance);
                    var workout = new Walking(TypeOfWorkout.Walking, whenWorkedOut, minutesWorkedOut, points, distance);
                    db.AddWorkouts(workout,user);
                }
                else if (workoutChoice == TypeOfWorkout.Running)
                {
                    points = pointsCalculator.PointsForRunning(minutesWorkedOut, distance);
                    var workout = new Running(TypeOfWorkout.Running, whenWorkedOut, minutesWorkedOut, points, distance);
                    db.AddWorkouts(workout,user);
                }
                else if (workoutChoice == TypeOfWorkout.Swimming)
                {
                    points = pointsCalculator.PointsForSwimming(minutesWorkedOut, distance);
                    var workout = new Swimming(TypeOfWorkout.Swimming, whenWorkedOut, minutesWorkedOut, points, distance);
                    db.AddWorkouts(workout,user);
                }
                else if (workoutChoice == TypeOfWorkout.Strength)
                {
                    points = pointsCalculator.PointsForStength(minutesWorkedOut);
                    var workout = new Strength(TypeOfWorkout.Strength, whenWorkedOut, minutesWorkedOut, points);
                    db.AddWorkouts(workout,user);
                }
            }
            else
            {
                Console.WriteLine("Du kommer nu att returneras till huvudmenyn.");
            }
            if (happyWithChoice == true)
            {
                Comments comment = new Comments();
                Console.WriteLine($"Ditt träningspass har nu registrerats. Du fick {points} poäng!");
                if (points >= 80)
                {
                    Console.WriteLine(comment.PositiveComment());
                }
                else
                {
                    Console.Write(comment.NegativeComment());
                }
            }
            Console.Write("\nKlicka på valfri tangent för att fortsätta.");
            Console.ReadKey();
        }
        TypeOfWorkout GetChoiceFromUser()
        {
            int input;
            TypeOfWorkout workoutChoice;

            while (true)
            {
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                    workoutChoice = (TypeOfWorkout)input;
                    break;
                }
                catch
                {
                    TryErrors.ErrorMessage();
                }
            }
            return workoutChoice;
        }
        void GroupMenu()
        {
            MenuGroup userChoice = 0;

            Console.Clear();
            Console.WriteLine("Vad vill du göra?");
            Console.WriteLine($"{Convert.ToInt32(MenuGroup.CreatGroup)}. Skapa grupp");
            Console.WriteLine($"{Convert.ToInt32(MenuGroup.JoinGroup)}. Gå med i grupp");
            Console.WriteLine($"{Convert.ToInt32(MenuGroup.LeaveGroup)}. Lämna grupp");
            Console.WriteLine($"{Convert.ToInt32(MenuGroup.Compete)}. Tävla");
            Console.Write("Ditt val: ");
            int input = TryErrors.TryInt();
            userChoice = (MenuGroup)input;

            switch (userChoice)
            {
                case MenuGroup.CreatGroup:
                    Group.CreateGroup();
                    break;

                case MenuGroup.JoinGroup:
                    Group.AddMemberToGroup();
                    break;

                case MenuGroup.LeaveGroup:
                    Group.LeaveGroup();
                    break;

                case MenuGroup.Compete:
                    //TODO fixa tävling
                    break;

                default:
                    Console.Clear();
                    TryErrors.ErrorMessage();
                    break;
            }
        }
        void UserMenu(User user)
        {
            MenuUser userChoice = 0;

            Console.Clear();
            Console.WriteLine($"{Convert.ToInt32(MenuUser.ChangeGoals)}. Ändra dina mål");
            Console.WriteLine($"{Convert.ToInt32(MenuUser.ChangeUserInfo)}. Ändra din information");
            Console.WriteLine($"{Convert.ToInt32(MenuUser.Quit)}. Avsluta");
            Console.Write("Ditt val: ");
            int input = TryErrors.TryInt();
            userChoice = (MenuUser)input;

            switch (userChoice)
            {
                case MenuUser.ChangeGoals:
                    //User.ChangeGoals();
                    break;

                case MenuUser.ChangeUserInfo:
                    //TODO sub menu/metodanrop?
                    Console.Write("Önskar du ändra:" + user.Age.ToString());

                    break;

                case MenuUser.Quit:
                    break;

                default:
                    Console.Clear();
                    TryErrors.ErrorMessage();
                    break;

            }


        }
        void StatisticMenu(User user)
        {
            MenuStatistic UserChoice = 0;

            Console.Clear();
            Console.WriteLine($"{Convert.ToInt32(MenuStatistic.Personal)}. Personlig statistik");
            Console.WriteLine($"{Convert.ToInt32(MenuStatistic.Group)}. Grupp statistik");
            Console.WriteLine($"{Convert.ToInt32(MenuStatistic.Quit)}. Avsluta");
            Console.Write("Ditt val: ");
            int input = TryErrors.TryInt();
            UserChoice = (MenuStatistic)input;

            switch (UserChoice)
            {
                case MenuStatistic.Personal:
                    Console.Clear();
                    Statistics stats = new Statistics();
                    foreach (var workout in stats.SeeWorkoutStatistics(user))
                    {
                        Console.WriteLine(workout);
                    }
                    break;

                case MenuStatistic.Group:
                    //Statistics.GroupStatistics();
                    break;

                case MenuStatistic.Quit:
                    break;

                default:
                    Console.Clear();
                    TryErrors.ErrorMessage();
                    break;
            }
        }
        public void PointsInformationForUser(User user)
        {
            var stats = new Statistics();
            double weeklyPoints = stats.WorkOutPointsFor(user);

            Console.WriteLine($"Välkommen {user.UserName}");
            if (user.PointsGoal > 0)
            {
                Console.WriteLine($"Den här veckan har du uppnåt {weeklyPoints}/ {user.PointsGoal} poäng.");
                if (weeklyPoints >= user.PointsGoal)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Veckans poängmål uppnått\n");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
