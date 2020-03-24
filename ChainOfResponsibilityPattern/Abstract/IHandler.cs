using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern.Abstract
{
    interface IHandler
    {
        IHandler SetNextHandler(IHandler nextHandler);
        void HandleRequest(object request);
    }
}
