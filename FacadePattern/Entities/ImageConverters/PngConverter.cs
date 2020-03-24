using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Entities.ImageConverters
{
    class PngConverter
    {
        public void Convert(string fileName, string fileFormat)
        {
            Console.WriteLine($"Converting {fileName} from {fileFormat} to Png.");
        }
    }
}
