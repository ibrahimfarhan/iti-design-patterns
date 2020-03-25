using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Abstract
{
    interface IDataStore
    {
        void WriteData(object data);
        object ReadData();
    }
}
