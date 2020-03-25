using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.GeometricShapes
{
    class Triangle : IGeometricShape
    {
        public double Area()
        {
            return 0;
        }

        public double Circumference()
        {
            return 0;
        }

        public void DrawGeometricShape()
        {
            Console.WriteLine("Drawing a triangle...");
        }
    }
}
