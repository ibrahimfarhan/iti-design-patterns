using AdapterPattern.Adapters;
using AdapterPattern.GeometricShapes;
using AdapterPattern.Shapes;
using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IGeometricShape triangle = new Triangle();
            IShape triangleAsShape = new GeometricShapeToShapeAdapter(triangle);

            triangle.DrawGeometricShape();
            triangleAsShape.Draw();
        }
    }
}
