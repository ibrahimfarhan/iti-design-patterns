using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Entities.AudioConverters
{
    class AudioConverter
    {
        public Mp3Converter Mp3Converter { get; set; }
        public OggConverter OggConverter { get; set; }

        public AudioConverter()
        {
            Mp3Converter = new Mp3Converter();
            OggConverter = new OggConverter();
        }

        public void Convert(string fileName, string fileFormat, string targetFormat)
        {
            switch (targetFormat)
            {
                case "Mp3":
                    Mp3Converter.Convert(fileName, fileFormat);
                    break;

                case "Ogg":
                    OggConverter.Convert(fileName, fileFormat);
                    break;

                default:
                    Console.WriteLine("Target format is not supported.");
                    break;
            }
        }
    }
}
