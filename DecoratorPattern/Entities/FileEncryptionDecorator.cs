using DecoratorPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Entities
{
    class FileEncryptionDecorator : BaseDataStoreDecorator
    {
        public FileEncryptionDecorator(IDataStore dataStore)
        {
            this.dataStore = dataStore;
        }

        public override object ReadData()
        {
            Console.WriteLine("Performing decryption...");

            return base.ReadData();
        }

        public override void WriteData(object data)
        {
            Console.WriteLine("Performing encryption...");

            base.WriteData(data);
        }
    }
}
