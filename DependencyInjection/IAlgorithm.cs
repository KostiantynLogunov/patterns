using System;

namespace DependencyInjection
{
    public interface IAlgorithm
    {
        /// <summary>
        /// Вычисление нового хеша.
        /// </summary>
        /// <returns>Успешность нахождения хеша.</returns>
        bool Hash();
    }
}
