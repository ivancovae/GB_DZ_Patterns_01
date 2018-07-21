namespace Patterns_01
{
    /// <summary>
    /// Абстрактный класс EntityBase
    /// </summary>
    public abstract class EntityBase
    {
        private readonly IIdGenerator _idGenerator;
        /// <summary>
        /// Свойство id
        /// </summary>
        public long Id { get; private set; }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="idGenerator">объект генерации id</param>
        public EntityBase(IIdGenerator idGenerator)
        {
            _idGenerator = idGenerator;
            Id = _idGenerator.CalculateId();
        }
    }
}
