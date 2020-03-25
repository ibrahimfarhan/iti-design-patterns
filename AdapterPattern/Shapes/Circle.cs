using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Shapes
{
    class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a circle...");
        }

        public string GetDescription()
        {
            return "This is a circle.";
        }

        public bool IsHidden()
        {
            return false;
        }

        public void Resize()
        {
            Console.WriteLine("resizing a circle...");
        }
    }
}
