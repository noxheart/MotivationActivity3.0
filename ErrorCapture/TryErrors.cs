using System;

namespace ErrorCapture
{
    public class TryErrors
    {   
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
                    break;
                }
                catch
                {
                    ErrorMessage();
                }
            }
            return date;
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
        /// Gives an error message
        /// </summary>
        public static void ErrorMessage()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Var god och ange ett korrekt värde.\n");
            Console.ResetColor();
        }
    }
}
