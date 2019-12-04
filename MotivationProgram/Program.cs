﻿using System;
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
        static void Main(string[] args)
        {
            Console.Clear();

            string UserName = "";
            string Password = "";


            while (true)
            {
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
                }
                else
                {
                    TryErrors.ErrorMessage();
                    Thread.Sleep(1000);
                }

                Console.Clear();
                Console.Write("Önskar du stänga av programmet: (J/N)");
                bool yes = TryErrors.TryYesOrNo();
                if (yes == true)
                {
                    break;
                }
                else
                {

                }
            }
            Console.WriteLine("Programmet avslutas...");
            Thread.Sleep(2000);
        }
    }
}
