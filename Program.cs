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
                ManagerFiles managerFiles = new ManagerFiles();
            }

            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}