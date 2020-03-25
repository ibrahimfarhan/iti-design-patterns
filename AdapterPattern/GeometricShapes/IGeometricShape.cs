using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.GeometricShapes
{
    interface IGeometricShape
    {
        void DrawGeometricShape();
        double Circumference();
        double Area();
    }
}
