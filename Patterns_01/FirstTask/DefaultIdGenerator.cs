using System;

namespace Patterns_01
{
    /// <summary>
    /// Объект генерации id по умолчанию
    /// </summary>
    public class DefaultIdGenerator : IIdGenerator
    {
        /// <summary>
        /// метод генерации id
        /// </summary>
        /// <returns>значение ids</returns>
        public long CalculateId()
        {
            long id = DateTime.Now.Ticks;
            return id;
        }
    }
}
