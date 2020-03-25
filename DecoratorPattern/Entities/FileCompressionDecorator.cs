using DecoratorPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Entities
{
    class FileCompressionDecorator : BaseDataStoreDecorator
    {
        public FileCompressionDecorator(IDataStore dataStore)
        {
            this.dataStore = dataStore;
        }

        public override void WriteData(object data)
        {
            Console.WriteLine("Performing compression...");

            base.WriteData(data);
        }

        public override object ReadData()
        {
            Console.WriteLine("Performing decompression...");

            return base.ReadData();
        }

    }
}
