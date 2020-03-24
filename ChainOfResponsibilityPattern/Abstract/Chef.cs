using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern.Abstract
{
    class Chef : IHandler
    {
        private IHandler nextHandler;

        public virtual void HandleRequest(object request)
        {
            if (nextHandler != null)
            {
                nextHandler.HandleRequest(request);
                return;
            }

            Console.WriteLine($"Could not find a chef for: {request.ToString()}");
        }

        public IHandler SetNextHandler(IHandler nextHandler)
        {
            this.nextHandler = nextHandler;

            return nextHandler;
        }
    }
}
