using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Shapes
{
    class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a rectangle...");
        }

        public string GetDescription()
        {
            return "This is a rectangle.";
        }

        public bool IsHidden()
        {
            return false;
        }

        public void Resize()
        {
            Console.WriteLine("Resizing rectangle...");
        }
    }
}
