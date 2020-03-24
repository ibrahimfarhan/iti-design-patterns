using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Entities.ImageConverters
{
    class JpgConverter
    {
        public void Convert(string fileName, string fileFormat)
        {
            Console.WriteLine($"Converting {fileName} from {fileFormat} to Jpg.");
        }
    }
}
