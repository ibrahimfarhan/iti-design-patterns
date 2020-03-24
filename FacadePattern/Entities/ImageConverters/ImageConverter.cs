using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Entities.ImageConverters
{
    class VideoConverter
    {
        public JpgConverter JpgConverter { get; set; }
        public PngConverter PngConverter { get; set; }

        public VideoConverter()
        {
            JpgConverter = new JpgConverter();
            PngConverter = new PngConverter();
        }

        public void Convert(string fileName, string fileFormat, string targetFormat)
        {
            switch (targetFormat)
            {
                case "Jpg":
                    JpgConverter.Convert(fileName, fileFormat);
                    break;

                case "Png":
                    PngConverter.Convert(fileName, fileFormat);
                    break;

                default:
                    Console.WriteLine("Target format is not supported.");
                    break;
            }
        }
    }
}
