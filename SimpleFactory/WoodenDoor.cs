using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class WoodenDoor : Door
    {
        protected double Width;
        protected double Height;

        public WoodenDoor(double weidth, double height)
        {
            Width = weidth;
            Height = height;
        }

        public double GetHeight()
        {
            return Height;
        }

        public double GetWidth()
        {
            return Width;
        }
    }
}
