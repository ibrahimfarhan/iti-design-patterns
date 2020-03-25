using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Shapes
{
    interface IShape
    {
        void Draw();
        void Resize();
        string GetDescription();
        bool IsHidden();
    }
}
