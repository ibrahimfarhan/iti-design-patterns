using FacadePattern.Entities.AudioConverters;
using FacadePattern.Entities.ImageConverters;
using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AudioConverter audioConverter = new AudioConverter();
            VideoConverter imageConverter = new VideoConverter();

            audioConverter.Convert("file1", "wav", "Mp3");
            audioConverter.Convert("file2", "wav", "Ogg");

            imageConverter.Convert("file3", "gif", "Jpg");
            imageConverter.Convert("file4", "gif", "Png");
        }
    }
}
