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
    }
}
