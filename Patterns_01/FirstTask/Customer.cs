namespace Patterns_01
{
    /// <summary>
    /// Класс Customer
    /// </summary>
    class Customer : EntityBase
    {
        /// <summary>
        /// Описание объекта
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="idGenerator">объект генерации id</param>
        public Customer(IIdGenerator idGenerator) : base(idGenerator) { }
    }
}
