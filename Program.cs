using System;
using System.Collections.Generic;
using ConsoleApplication1.Properties;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                ManagerFiles managerFiles = new ManagerFiles();
            }

            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}