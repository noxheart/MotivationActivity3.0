using System;
using System.Threading;

namespace MotivationProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var accessMenu = new Menu();
            accessMenu.MainMenu();


            Console.WriteLine("Programmet avslutas...");
            Thread.Sleep(2000);
        }
        /// <summary>
        /// Checks if stringInput is correct
        /// </summary>
        /// <returns></returns>
        public static string TryString()
        {
            string input;
            while (true)
            {
                try
                {
                    input = Console.ReadLine();
                    break;
                }
                catch
                {
                    ErrorMessage();
                }
            }
            return input;
        }
        /// <summary>
        /// /// Checks if user entered a number correctly
        /// </summary>
        /// <returns></returns>
        public static int TryInt()
        {
            int input;
            while (true)
            {
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    ErrorMessage();
                }
            }
            return input;
        }
        /// <summary>
        /// Takes user input of time
        /// </summary>
        /// <returns></returns>
        public static DateTime TryTime()
        {
            DateTime date;
            while (true)
            {
                try
                {
                    date = Convert.ToDateTime(Console.ReadLine());
                }
                catch
                {
                    ErrorMessage();
                }
            }
        }
        /// <summary>
        /// Checks if user entered a double
        /// </summary>
        /// <returns></returns>
        public static double TryDouble()
        {
            double input;
            while (true)
            {
                try
                {
                    input = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch
                {
                    ErrorMessage();
                }
            }
            return input;
        }
        public static bool TryYesOrNo()
        {
            bool yes;
            while(true){
                try
                {
                    string input = Console.ReadLine().Substring(0,1).ToUpper();
                    if(input == "J"){
                        yes = true;
                        break;
                    }
                    else if(input == "N"){
                        yes = false;
                        break;
                    }
                    else{ErrorMessage();}
                }
                catch
                {
                    ErrorMessage();
                }
            }
            return yes;
        }
        /// <summary>
        /// Gives an error message
        /// </summary>
        public static void ErrorMessage()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Var god och ange ett korrekt värde.\n");
            Console.ResetColor();
        }
    }
}
