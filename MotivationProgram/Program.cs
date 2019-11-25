using System;
using System.Threading;
using ErrorCapture;
using MotivationLibrary;
namespace MotivationProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserName = "";
            string Password = "";

            UserName = TryErrors.TryString();
            Password = TryErrors.TryString();

            var db = new Database("Server=40.85.84.155;Database=Student5;User=Student5;Password=YH-student@2019;");

            User user = db.GetLogin(UserName, Password);

            if (user != null)
            {
                var accessMenu = new Menu();
                accessMenu.MainMenu(user);
            }

            Console.WriteLine("Programmet avslutas...");
            Thread.Sleep(2000);
        }
    }
}
