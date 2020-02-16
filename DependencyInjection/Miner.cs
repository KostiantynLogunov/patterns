using System;
using System.Threading;
 
namespace DependencyInjection
{
    /// <summary>
    /// Основной класс выполняющих майнинг.
    /// </summary>
    public class Miner
    {
        /// <summary>
        /// Алгоритм поиска хеша.
        /// </summary>
        private IAlgorithm algoritm;
 
        /// <summary>
        /// Поток в котором выполняется поиск.
        /// </summary>
        private Thread thread;
 
        /// <summary>
        /// Событие нахождения хеша.
        /// </summary>
        public event EventHandler<bool> HashFound;
 
        /// <summary>
        /// Создать экземпляр майнера.
        /// </summary>
        /// <param name="algorithm">Алгоритм выполняющий вычисления.</param>
        public Miner(IAlgorithm algorithm)
        {
            this.algoritm = algorithm;
            thread = new Thread(Mine);
        }
 
        /// <summary>
        /// Начать майнинг.
        /// </summary>
        public void Start()
        {
            thread.Start();
        }
 
        /// <summary>
        /// Остановить майнинг.
        /// </summary>
        public void Stop()
        {
            thread.Abort();
        }
 
        /// <summary>
        /// Метод выполняющий майнинг.
        /// </summary>
        private void Mine()
        {
            while (true)
            {
                var hashResult = algoritm.Hash();
                HashFound?.Invoke(this, hashResult);
            }
        }
    }
}