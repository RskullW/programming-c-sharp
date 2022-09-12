using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Manager manager = new Manager();
                manager.OpenMenu();
                manager.CloseMenu();
            }

            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}