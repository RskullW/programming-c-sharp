using System;
using System.Collections.Generic;
using ConsoleApplication1.Properties;

namespace ConsoleApplication1
{
    class Program
    {
        private static List<Capybara> _capybaras;
        private static ManagerCapybaras _managerCapybaras;

        public static void Main(string[] args)
        {
            try
            {
                _capybaras = new List<Capybara>(1);
                _managerCapybaras = new ManagerCapybaras(_capybaras);
                _managerCapybaras.OpenMenu();
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