using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    /// <summary>
    /// Пиратский космический корабль.
    /// </summary>
    public class PiratSpaceShipFactory : SpaceShipFactoryBase
    {
        /// <summary>
        /// Создать экземпляр пиратского космического корабля.
        /// </summary>
        public PiratSpaceShipFactory()
        {
            Health = 200;
            Type = "Пиратский корабль";
        }

        /// <summary>
        /// Создаем источник энергии пиратского комического корабля.
        /// </summary>
        /// <returns>Плазменный источник энергии.</returns>
        public override EnergyBase CreateEnergy()
        {
            return new PlasmEnergy();
        }

        /// <summary>
        /// Создаем оружие пиратского комического корабля.
        /// </summary>
        /// <returns>Фононная пушка.</returns>
        public override GunBase CreateGun()
        {
            return new PhotonGun();
        }

        /// <summary>
        /// Создаем двигатель пиратского космического корабля.
        /// </summary>
        /// <returns>Фотонный двигатель.</returns>
        public override EngineBase CreateEngine()
        {
            return new PhotonEngine();
        }
    }
}
