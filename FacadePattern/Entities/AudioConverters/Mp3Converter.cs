using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Entities.AudioConverters
{
    class Mp3Converter
    {
        public void Convert(string fileName, string fileFormat)
        {
            Console.WriteLine($"Converting {fileName} from {fileFormat} to Mp3.");
            DoSomeProcessingOperation(fileName);
        }

        private void DoSomeProcessingOperation(string fileName)
        {
        }
    }
}
