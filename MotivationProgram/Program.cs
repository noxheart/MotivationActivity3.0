using System;
using System.Threading;
using ErrorCapture;
using MotivationLibrary;
namespace MotivationProgram
{
    class Program
    {
        /// <summary>
        /// Start of program asks for login details and checks database for it. Enters Menu() if user is found.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            Console.Clear();

            string UserName = "";
            string Password = "";
            ErrorCheck error = new ErrorCheck();
            var db = new Database("Server=40.85.84.155;Database=Student5;User=Student5;Password=YH-student@2019;");

            while (true)
            {
                Console.Write("Ange användarnamn: ");
                UserName = error.TryString();
                Console.Clear();

                Console.Write("Ange lösenord: ");
                Password = error.TryString();

                User user = db.GetLogin(UserName, Password);

                if (user != null)
                {
                    var accessMenu = new Menu();
                    accessMenu.MainMenu(user);
                }
                else
                {
                    error.ErrorMessage();
                    Thread.Sleep(1000);
                }

                Console.Clear();
                Console.Write("Önskar du stänga av programmet: (J/N)");
                bool yes = error.TryYesOrNo();
                if (yes == true)
                {
                    break;
                }
            }
            Console.WriteLine("Programmet avslutas...");
            Thread.Sleep(2000);
        }
    }
}
