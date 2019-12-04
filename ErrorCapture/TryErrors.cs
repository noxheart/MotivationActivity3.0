using System;

namespace ErrorCapture
{
    public class ErrorCheck
    {
        /// <summary>
        /// Checks if stringInput is correct
        /// </summary>
        /// <returns></returns>
        public string TryString()
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
        public DateTime TryTime()
        {
            DateTime date;
            while (true)
            {
                try
                {
                    date = Convert.ToDateTime(Console.ReadLine());
                    bool trueDate = ValidDate(date);
                    if (trueDate)
                    {
                        break;
                    }
                }
                catch
                {
                    ErrorMessage();
                }
            }

            return date;
        }
        public bool ValidDate(DateTime date)
        {
            if (date <= DateTime.Now)
            {
                return true;
            }
            else
            {
                ErrorMessage();
                return false;
            }
        }

        /// <summary>
        /// Checks if user entered a double
        /// </summary>
        /// <returns></returns>
        public double TryDouble()
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

        public bool TryYesOrNo()
        {
            bool yes;
            while (true)
            {
                try
                {
                    string input = Console.ReadLine().Substring(0, 1).ToUpper();
                    if (input == "J")
                    {
                        yes = true;
                        break;
                    }
                    else if (input == "N")
                    {
                        yes = false;
                        break;
                    }
                    else { ErrorMessage(); }
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
        public int TryInt()
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
        public void ErrorMessage()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Var god och ange ett korrekt värde.\n");
            Console.ResetColor();
        }
    }
}
