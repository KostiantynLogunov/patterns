using System;

namespace FectoryMethod
{
    /// <summary>
    /// Абстракция для фабрики
    /// </summary>
    interface IBidloFactory
    {
        /// <summary>
        /// Каждая конкретная фабрика должна реализовывать свой способ создания объекта
        /// </summary>
        /// <returns></returns>
        IBidlo Create();
    }
}
