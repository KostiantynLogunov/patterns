using System;

namespace ISP
{
    class CarTransformer : ICarTransformer
    {
        public void ToCar()
        {
            Console.WriteLine("Trsnform to car");
        }
    }
}
