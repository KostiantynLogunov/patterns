using System;
using System.Threading;

namespace DependencyInjection
{
    /// <summary>
    /// Алгоритм вычисления хеш-функции Ethash.
    /// </summary>
    public class Ethash : IAlgorithm
    {
        /// <inheritdoc />
        public bool Hash()
        {
            var random = new Random();
            Thread.Sleep(1000);
            var hash = random.Next();
            if (hash <= 10000)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Приведение объекта к строке.
        /// </summary>
        /// <returns>Имя алгоритма.</returns>
        public override string ToString()
        {
            return nameof(Ethash);
        }
    }
}