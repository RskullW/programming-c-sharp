using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        private static List<IMammal> _mammals;
        private static Manager _manager;

        public static void Main(string[] args)
        {
            try
            {
                _mammals = new List<IMammal>();
                _manager = new Manager(_mammals);
                _manager.OpenStartMenu();
                _manager.OpenMenu();
                _manager.CloseMenu();
            }

            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}

/*
TODO: Разработать общий интерфейс для доступа к объектам классов разработанной иерархии. 
Интерфейс должен предоставлять 
доступ к общим для всех классов иерархии методам. Необходимо добавить новый класс, не входящий в иерархию,
 однако также реализующий разработанный интерфейс. 
Создать список объектов классов, реализующих разработанный 
интерфейс. Создать функцию, принимающую в качестве параметра 
объект любого класса, реализующего интерфейс.
Написать программу с меню, позволяющую протестировать работу списка. Обязательные пункты меню:
‒ добавление нового объекта выбранного пользователем класса в 
список;
‒ вывод свойств объекта из списка;
‒ выполнение методов объекта из списка;
‒ вывод всех объектов в списке с указанием их классов;
‒ выполнение созданной функции с указанным объектом из списка
*/