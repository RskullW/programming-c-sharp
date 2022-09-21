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
            }

            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}

/*
TODO: need to create a menu.
‒ задание параметров конструируемого объекта;
‒ вывод свойств объекта;
‒ выполнение статического метода;
‒ выполнение методов объекта.
*/