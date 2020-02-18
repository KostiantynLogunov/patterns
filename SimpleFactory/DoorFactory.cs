using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class DoorFactory
    {
        public static Door MakeDoor(double width, double height)
        {
            return new WoodenDoor(width, height);
        }
    }
}
