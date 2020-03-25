using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Abstract
{
    abstract class BaseDataStoreDecorator : IDataStore
    {
        protected IDataStore dataStore;

        public virtual object ReadData()
        {
            return dataStore.ReadData();
        }

        public virtual void WriteData(object data)
        {
            dataStore.WriteData(data);
        }
    }
}
