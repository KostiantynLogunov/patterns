using System;

namespace ISP
{
    class SuperTransformer : ICarTransformer, IShipTransformer, IPlaneTransformer
    {
        public void ToCar()
        {
            Console.WriteLine("Trsnform to car");
        }

        public void ToPlane()
        {
            Console.WriteLine("Trsnform to Plane");
        }

        public void ToShip()
        {
            Console.WriteLine("Trsnform to ship");
        }
    }
}
