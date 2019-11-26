using System;
using System.Threading;
using MotivationLibrary;
using ErrorCapture;

namespace MotivationProgram
{
    class Menu
    {
        private enum MenuMain { Quit, AddWorkout, Statistic, Group, User }
        private enum MenuGroup {CreatGroup = 1, JoinGroup, LeaveGroup, Compete}
        Comments comment = new Comments();
        PointsCalculator pointsCalculator = new PointsCalculator();
        Group Group = new Group();
        public void MainMenu(User user)
        {
            MenuMain userChoice = 0;
            bool mainMenuLoop = true;
            while (mainMenuLoop)
            {
                 Console.Clear();//RENSAR FÖREGÅENDE MENY FÖR LÄTTARE LÄSNING.
                Console.WriteLine($"Välkommen {user.UserName}");
                if (user.PointsGoal > 0)
                {
                    Console.WriteLine($"Den här veckan har du uppnåt {user.Points}/ {user.PointsGoal} poäng.\n");
                }
                //TODO Ge information om användaren, namn, poäng etc.
                Console.WriteLine($"{Convert.ToInt32(MenuMain.AddWorkout)}. Registrera träning");
                Console.WriteLine($"{Convert.ToInt32(MenuMain.Statistic)}. Statistik");
                Console.WriteLine($"{Convert.ToInt32(MenuMain.Group)}. Grupp");
                Console.WriteLine($"{Convert.ToInt32(MenuMain.User)}. Profil");
                Console.WriteLine($"{Convert.ToInt32(MenuMain.Quit)}. Avsluta");
                Console.Write("Ditt val: ");
                int input = TryErrors.TryInt();
                userChoice = (MenuMain)input;



                switch (userChoice)
                {
                    case MenuMain.AddWorkout:
                        AddWorkout(user);
                        break;
                    case MenuMain.Statistic:
                        //TODO Statistik
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
        void AddWorkout(User user)
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
            //TODO Ta tiden från användaren
            Console.WriteLine("Vilken typ av träning önskar du registrera?");
            Console.WriteLine("1. Gång");
            Console.WriteLine("2. Löpning");
            Console.WriteLine("3. Simning");
            Console.WriteLine("4. Styrketräning");
            TypeOfWorkout workoutChoice = GetChoiceFromUser();

            if (workoutChoice == TypeOfWorkout.Walking || workoutChoice == TypeOfWorkout.Running ||
            workoutChoice == TypeOfWorkout.Swimming)
            {
                Console.Write("Distans: ");
                distance = TryErrors.TryDouble();
            }

            Console.Write("Träningstid i minuter: ");
            minutesWorkedOut = TryErrors.TryInt();

            Console.Write("Är du nöjd med träningen (J/N)?");
            happyWithChoice = TryErrors.TryYesOrNo();

            if (happyWithChoice == true)
            {
                if (workoutChoice == TypeOfWorkout.Walking)
                {
                    points = pointsCalculator.PointsForWalking(minutesWorkedOut, distance);
                    var workout = new Walking(whenWorkedOut, distance, minutesWorkedOut, points, TypeOfWorkout.Walking);
                    workout.AddWorkout(user);
                }
                else if (workoutChoice == TypeOfWorkout.Running)
                {
                    points = pointsCalculator.PointsForRunning(minutesWorkedOut, distance);
                    var workout = new Running(whenWorkedOut, distance, minutesWorkedOut, points, TypeOfWorkout.Running);
                    workout.AddWorkout(user);
                }
                else if (workoutChoice == TypeOfWorkout.Swimming)
                {
                    points = pointsCalculator.PointsForSwimming(minutesWorkedOut, distance);
                    var workout = new Swimming(whenWorkedOut, distance, minutesWorkedOut, points, TypeOfWorkout.Swimming);
                    workout.AddWorkout(user);
                }
                else if (workoutChoice == TypeOfWorkout.Strength)
                {
                    points = pointsCalculator.PointsForStength(minutesWorkedOut);
                    var workout = new Strength(whenWorkedOut, minutesWorkedOut, points, TypeOfWorkout.Strength);
                    workout.AddWorkout(user);
                }
            }
            else
            {
                Console.WriteLine("Du kommer nu att returneras till huvudmenyn.");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"Ditt träningspass har nu registrerats. Du fick {points}");
            if (points >= 80)
            {
                Console.WriteLine(comment.PositiveComment());
            }
            else
            {
                Console.Write(comment.NegativeComment());
            }
            Thread.Sleep(5000);
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
                Group.CreatGroup();
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
    }
}
