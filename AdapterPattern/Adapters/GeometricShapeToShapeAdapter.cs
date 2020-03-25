using AdapterPattern.GeometricShapes;
using AdapterPattern.Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Adapters
{
    class GeometricShapeToShapeAdapter : IShape
    {
        private readonly IGeometricShape geometricShape;

        public GeometricShapeToShapeAdapter(IGeometricShape geometricShape)
        {
            this.geometricShape = geometricShape;
        }

        public void Draw()
        {
            geometricShape.DrawGeometricShape();
        }

        public string GetDescription()
        {
            return $"This is a {geometricShape.GetType().ToString()}";
        }

        public bool IsHidden()
        {
            return false;
        }

        public void Resize()
        {
            Console.WriteLine("Resizing is not supported for this shape.");
        }
    }
}
