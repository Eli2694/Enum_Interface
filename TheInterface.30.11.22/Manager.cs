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
            Rectangle rectangle = new Rectangle(5,7);
            Moon moon = new Moon(10);
            IShape I = kodkodCompare(rectangle, moon);
        }

        // Out of bounds because the function has nothing to do with Shape Classes
        public static IShape kodkodCompare(IShape shape1, IShape shape2)
        {

            if (shape1.Kodkod > shape2.Kodkod)
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
