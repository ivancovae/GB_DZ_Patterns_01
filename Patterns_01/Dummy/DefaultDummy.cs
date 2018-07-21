using System;

namespace Patterns_01
{
    /// <summary>
    /// Класс выполнения действия Dummy
    /// </summary>
    class DefaultDummy : IDummy
    {
        /// <summary>
        /// Адрес
        /// </summary>
        public static readonly string Address = Constants.Address;
        /// <summary>
        /// Формат
        /// </summary>
        public static readonly string Format = Constants.Format;

        protected void WriteToConsole(string name, string description, int age) =>
            Console.WriteLine(Format, name, description, Address, age);

        /// <summary>
        /// Реализация действия типа Dummy
        /// </summary>
        /// <param name="human">объект, для кого требуется выполнить действие</param>
        /// <returns>null объект</returns>
        public virtual object DummyFunc(Human human)
        {
            WriteToConsole(human.Name, human.Description, human.Age);
            return null;
        }
    }
}
