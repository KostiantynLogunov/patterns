﻿using System;

namespace FectoryMethod.Bidlos
{
    class Exhibitionist : IBidlo
    {
        public void BatleRoar()
        {
            Console.WriteLine("Здрасте, а вот что у меня под плащом");
        }

        public override string ToString()
        {
            return "Эксгибиционист";
        }
    }
}
