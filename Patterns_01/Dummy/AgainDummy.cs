﻿namespace Patterns_01
{
    /// <summary>
    /// Класс выполнения действия Again Dummy
    /// </summary>
    class AgainDummy : DefaultDummy
    {
        /// <summary>
        /// Реализация действия типа Dummy
        /// </summary>
        /// <param name="human">объект, для кого требуется выполнить действие</param>
        /// <returns>null объект</returns>
        public override object DummyFunc(Human human)
        {
            WriteToConsole(human.Name, human.Description, human.Age);
            return null;
        }
    }
}
