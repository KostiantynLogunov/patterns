using System;

namespace FectoryMethod.Bidlos
{
    class Alkash : IBidlo
    {
        public void BatleRoar()
        {
            Console.WriteLine("Дай пятюню, мне на проезд");
        }

        public override string ToString()
        {
            return "Алкаш";
        }
    }
}
