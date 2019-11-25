using System;
using System.Threading;
using MotivationLibrary;

namespace MotivationProgram
{
    public enum TypeOfWorkout { Walking = 1, Running, Swimming, Strength }
    class Menu
    {
        private enum MenuMain {Quit, AddWorkout , Statistic, Group, User}
        Comments comment = new Comments();
        PointsCalculator pointsCalculator = new PointsCalculator();
        public void MainMenu()
        {
            MenuMain userChoice = 0;
            bool mainMenuLoop = true;
            while (mainMenuLoop)
            {
                Console.Clear();//RENSAR FÖREGÅENDE MENY FÖR LÄTTARE LÄSNING.
                //TODO Ge information om användaren, namn, poäng etc.

                Console.WriteLine($"{Convert.ToInt32(MenuMain.AddWorkout)}. Registrera träning");
                Console.WriteLine($"{Convert.ToInt32(MenuMain.Statistic)}. Statistik");
                Console.WriteLine($"{Convert.ToInt32(MenuMain.Group)}. Grupp");
                Console.WriteLine($"{Convert.ToInt32(MenuMain.User)}. Profil");
                Console.WriteLine($"{Convert.ToInt32(MenuMain.Quit)}. Avsluta");
                Console.Write("Ditt val: ");
                int input = Program.TryInt();
                userChoice = (MenuMain)input;
                


                switch (userChoice)
                {
                    case MenuMain.AddWorkout:
                        AddWorkout();
                        break;
                    case MenuMain.Statistic:
                        //TODO Statistik
                        break;
                    case MenuMain.Group:
                        //TODO Grupp
                        break;
                    case MenuMain.User:
                        break;
                    case MenuMain.Quit:
                        mainMenuLoop = false;
                        break;
                    default:
                        Console.Clear();
                        Program.ErrorMessage();
                        break;
                }
            }
        }
        void AddWorkout()
        {
            DateTime whenWorkedOut;
            double distance = 0;
            int minutesWorkedOut;
            bool happyWithChoice;
            double points = 0;

            Console.Clear();//RENSAR FÖREGÅENDE MENY FÖR LÄTTARE LÄSNING.

            Console.WriteLine("När tränade du? (åååå-mm-dd)");
            Console.Write("Datum: ");
            whenWorkedOut = Program.TryTime();
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
                distance = Program.TryDouble();
            }

            Console.Write("Träningstid i minuter: ");
            minutesWorkedOut = Program.TryInt();

            Console.Write("Är du nöjd med träningen (J/N)?");
            happyWithChoice = Program.TryYesOrNo();

            if (happyWithChoice == true)
            {
                if (workoutChoice == TypeOfWorkout.Walking)
                {
                    points = pointsCalculator.PointsForWalking(minutesWorkedOut, distance);
                    var workout = new Walking(whenWorkedOut, distance, minutesWorkedOut, points);
                    workout.AddWorkout(TypeOfWorkout.Walking);
                }
                else if (workoutChoice == TypeOfWorkout.Running)
                {
                    points = pointsCalculator.PointsForRunning(minutesWorkedOut, distance);
                    var workout = new Running(whenWorkedOut, distance, minutesWorkedOut, points);
                    workout.AddWorkout(workout);
                }
                else if (workoutChoice == TypeOfWorkout.Swimming)
                {
                    points = pointsCalculator.PointsForSwimming(minutesWorkedOut, distance);
                    var workout = new Swimming(whenWorkedOut, distance, minutesWorkedOut, points);
                    workout.AddWorkout(workout);
                }
                else if (workoutChoice == TypeOfWorkout.Strength)
                {
                    points = pointsCalculator.PointsForStength(minutesWorkedOut);
                    var workout = new Strength(whenWorkedOut, minutesWorkedOut, points);
                    workout.AddWorkout(workout);
                }
            }
            else
            {
                Console.WriteLine("Du kommer nu att returneras till huvudmenyn.");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"Ditt träningspass har nu registrerats. Du fick {points}");
            Console.WriteLine(comment.PositiveComment());
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
                    Program.ErrorMessage();
                }
            }
            return workoutChoice;
        }
    }
}
