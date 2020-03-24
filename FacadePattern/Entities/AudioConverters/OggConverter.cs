using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Entities.AudioConverters
{
    class OggConverter
    {
        public void Convert(string fileName, string fileFormat)
        {
            Console.WriteLine($"Converting {fileName} from {fileFormat} to Ogg.");
        }
    }
}
