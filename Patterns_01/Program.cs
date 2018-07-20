using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_01
{
    class Program
    {
        public static readonly string Address = Constants.Address;
        public static readonly string Format = Constants.Format;      

        // метод отображение записи в консоле
        private static void WriteToConsole(string name, string description, int age)
        {
            Console.WriteLine(Format, name, description, Address, age);
        }

        // метод выполнения какого-то действия
        private static object DummyFunc(Human human)
        {
            WriteToConsole(human.Name, human.Description, human.Age);
            return null;
        }
        // метод выполнения другого какого-то действия
        private static object DummyFuncAgain(Human human)
        {
            WriteToConsole(human.Name, human.Description, human.Age);
            return null;
        }
        // метод выполнения другого какого-то действия
        private static object DummyFuncMore(Human human)
        {
            WriteToConsole(human.Name, human.Description, human.Age);
            return null;
        }

        // метод запуск выполнения действия для человека
        private static void MakeAction(Func<Human, object> action, Human human) 
        {
            string methodName = action.Method.Name;
            Console.WriteLine("Начало работы метода {0}", methodName);
            action(human);
            Console.WriteLine("Окончание работы метода {0}", methodName);
        }

        // метод получения списка конкретных действий для разных людей
        private static List<(Func<Human, object> action, Human human)> GetActionSteps() => new List<(Func<Human, object>, Human)>()
        {
            (DummyFunc, new Human("Петя" , "школьный друг" , 30)),
            (DummyFunc, new Human("Вася", "сосед", 54)),
            (DummyFunc, new Human("Николай", "сын", 4))
        };

        static void Main(string[] args)
        {
            Store store = new Store(new DefaultIdGenerator());

            List<(Func<Human, object> action, Human human)> steps = GetActionSteps();
            foreach (var step in steps)
            {
                MakeAction(step.action, step.human);
            }

            Console.ReadLine();
        }
    }
}
