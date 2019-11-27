using System;
using System.Globalization;
using System.Threading;
using ErrorCapture;
using MotivationLibrary;
namespace MotivationProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string UserName = "";
            string Password = "";

            Console.Write("Ange användarnamn: ");
            UserName = TryErrors.TryString();
            Console.Clear();
            Console.Write("Ange lösenord: ");
            Password = TryErrors.TryString();

            var db = new Database("Server=40.85.84.155;Database=Student5;User=Student5;Password=YH-student@2019;");

            User user = db.GetLogin(UserName, Password);

            if (user != null)
            {
                var accessMenu = new Menu();
                accessMenu.MainMenu(user);
                Console.Clear();
            }
            else
            {
                Console.Clear();
                TryErrors.ErrorMessage();
            }

            Console.WriteLine("Programmet avslutas...");
            Thread.Sleep(2000);
        }
    }
}
