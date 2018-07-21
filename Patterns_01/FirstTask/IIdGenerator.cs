namespace Patterns_01
{
    /// <summary>
    /// Интерфейс Генератора id
    /// </summary>
    public interface IIdGenerator
    {
        /// <summary>
        /// Метод генерации id
        /// </summary>
        /// <returns>значение id</returns>
        long CalculateId();
    }
}
