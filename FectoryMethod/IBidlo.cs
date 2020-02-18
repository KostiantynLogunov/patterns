using System;
using System.Collections.Generic;
using System.Text;

namespace FectoryMethod
{
    /// <summary>
    /// Абстракция для быдло
    /// </summary>
    interface IBidlo
    {
        /// <summary>
        /// Каждое быдло может издавать боевой клич
        /// </summary>
        void BatleRoar();
    }
}
