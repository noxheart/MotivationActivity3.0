using System;
using System.Threading;
using MotivationLibrary;

namespace MotivationProgram
{
    class Menu
    {
        private enum TypeOfWorkout { Walking = 1, Running, Swimming, Strength }
        public void MainMenu()
        {
            bool mainMenuLoop = true;
            while (mainMenuLoop)
            {
                Console.Clear();//RENSAR FÖREGÅENDE MENY FÖR LÄTTARE LÄSNING.
                //TODO Ge information om användaren, namn, poäng etc.

                Console.WriteLine("1. Registrera träning");
                Console.WriteLine("2. Avregistrera träning");
                Console.WriteLine("3. Statistik");
                Console.WriteLine("4. Grupp");
                Console.WriteLine("5. Profil");
                Console.WriteLine("6. Avsluta");
                Console.Write("Ditt val: ");
                int input = Program.TryInt();


                switch (input)
                {
                    case 1:
                        AddWorkout();
                        break;
                    case 2:
                        //TODO Avregistrera träning
                        break;
                    case 3:
                        //TODO Statistik
                        break;
                    case 4:
                        //TODO Grupp
                        break;
                    case 5:
                        //TODO Profil
                        break;
                    case 6:
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
            int strengthLevel = 0;
            int minutesWorkedOut;
            bool happyWithChoice;

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
            else if (workoutChoice == TypeOfWorkout.Strength)
            {
                Console.WriteLine("Vilken nivå utav träning har du tränat?");
                Console.WriteLine("1. Lätt");
                Console.WriteLine("2. Medium");
                Console.WriteLine("3. Hård");
                Console.Write("Nivå: ");
                strengthLevel = Program.TryInt();
                //TODO Nivå/typ av styrketräning
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
                    var workout = new Strength(whenWorkedOut, strengthLevel, minutesWorkedOut);
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
