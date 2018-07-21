namespace Patterns_01
{
    /// <summary>
    /// Класс Store
    /// </summary>
    class Store : EntityBase
    {
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="idGenerator">объект генерации id</param>
        public Store(IIdGenerator idGenerator) : base(idGenerator) {}
    }
}
