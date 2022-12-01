using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheInterface._30._11._22
{
    internal class Manager
    {
        public static void Runner()
        {
            Rectangle rectangle = new Rectangle();
            Moon moon = new Moon();
            Ikodkod I = kodkodCompare(rectangle, moon);
            Console.ReadLine();
        }

        // Out of bounds because the function has nothing to do with Shape Classes
        public static Ikodkod kodkodCompare(Ikodkod shape1, Ikodkod shape2)
        {
            if (shape1.kodkod > shape2.kodkod)
            {
                return shape1;
            }
            else
            {
                return shape2;
            }

        }

    }
}
