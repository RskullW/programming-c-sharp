using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            try
            {
                Manager manager = new Manager();

                manager.OpenMenu();
            }

            catch (Exception ex)
            {
                Manager.Display(ex.Message);
            }
        }
    }
}