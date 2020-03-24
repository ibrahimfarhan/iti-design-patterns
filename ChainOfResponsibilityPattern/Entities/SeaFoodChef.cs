using ChainOfResponsibilityPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern.Entities
{
    class SeaFoodChef : Chef
    {
        public override void HandleRequest(object request)
        {
            if (request.ToString() == "Sea Food")
            {
                Console.WriteLine("Sea food chef is cooking sea food.");
                return;
            }

            base.HandleRequest(request);
        }
    }
}
