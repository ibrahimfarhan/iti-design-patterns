using ChainOfResponsibilityPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern.Entities
{
    class PizzaChef : Chef
    {
        public override void HandleRequest(object request)
        {
            if (request.ToString() == "Pizza")
            {
                Console.WriteLine("Pizza chef is cooking pizza.");
                return;
            }

            base.HandleRequest(request);
        }
    }
}
