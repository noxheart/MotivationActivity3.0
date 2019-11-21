using System;
using System.Threading;
using MotivationLibrary;

namespace MotivationProgram
{
    class Menu
    {
        private enum TypeOfWorkout { Walking = 1, Running, Swimming, Strength }
        private enum MenuMain {Quit, AddWorkout , Statistic, Group, User}
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

            Console.Clear();//RENSAR FÖREGÅENDE MENY FÖR LÄTTARE LÄSNING.

            Console.WriteLine("När tränade du? (åååå-mm-dd)");
            Console.Write("Datum: ");
            whenWorkedOut = Program.TryTime();
            //TODO Ta tiden från användaren
            Console.WriteLine("Vilken typ av träning önskar du registrera?");
            Console.WriteLine($"{Convert.ToInt32(TypeOfWorkout.Walking)}. Gång");
            Console.WriteLine($"{Convert.ToInt32(TypeOfWorkout.Running)}. Löpning");
            Console.WriteLine($"{Convert.ToInt32(TypeOfWorkout.Swimming)}. Simning");
            Console.WriteLine($"{Convert.ToInt32(TypeOfWorkout.Strength)}. Styrketräning");
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
                    var workout = new Walking(whenWorkedOut, distance, minutesWorkedOut);
                    //TODO ADD TO DATABASE
                }
                else if (workoutChoice == TypeOfWorkout.Running)
                {
                    var workout = new Running(whenWorkedOut, distance, minutesWorkedOut);
                    //TODO ADD TO DATABASE
                }
                else if (workoutChoice == TypeOfWorkout.Swimming)
                {
                    var workout = new Swimming(whenWorkedOut, distance, minutesWorkedOut);
                    //TODO ADD TO DATABASE
                }
                else if (workoutChoice == TypeOfWorkout.Strength)
                {
                    var workout = new Strength(whenWorkedOut, minutesWorkedOut);
                    //TODO ADD TO DATABASE
                }
            }
            else
            {
                Console.WriteLine("Du kommer nu att returneras till huvudmenyn.");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Ditt träningspass har nu registrerats.");
            Thread.Sleep(1000);
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
