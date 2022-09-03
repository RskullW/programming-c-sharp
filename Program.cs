using System;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Capybara capybara = new Capybara();
                capybara.Display();
            }

            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}

/*
TODO: Рекомендуемые поля и методы указаны в варианте. Также необходимо написать программу с меню, позволяющую протестировать 
разработанный класс. Обязательные пункты меню:
‒ задание параметров конструируемого объекта;
‒ вывод свойств объекта;
‒ выполнение статического метода;
‒ выполнение методов объекта.
*/