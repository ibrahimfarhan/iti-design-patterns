using DecoratorPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Entities
{
    class FileDataStore : IDataStore
    {
        private readonly string fileName;

        public FileDataStore(string fileName)
        {
            this.fileName = fileName;
        }

        public object ReadData()
        {
            Console.WriteLine($"Reading from {fileName}");
            return "Raw file data";
        }

        public void WriteData(object data)
        {
            Console.WriteLine($"Writing data to {fileName}...");
        }
    }
}
