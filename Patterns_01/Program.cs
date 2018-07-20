﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_01
{
    class Program
    {        
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
            ((new DefaultDummy()).DummyFunc, new Human("Петя" , "школьный друг" , 30)),
            ((new AgainDummy()).DummyFunc, new Human("Вася", "сосед", 54)),
            ((new MoreDummy()).DummyFunc, new Human("Николай", "сын", 4))
        };

        static void Main(string[] args)
        {
            Store store = new Store(new DefaultIdGenerator());
            Customer customer = new Customer(new DefaultIdGenerator());

            List<(Func<Human, object> action, Human human)> steps = GetActionSteps();
            foreach (var step in steps)
            {
                MakeAction(step.action, step.human);
            }

            Console.ReadLine();
        }
    }
}
