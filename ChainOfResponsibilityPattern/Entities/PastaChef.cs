using ChainOfResponsibilityPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern.Entities
{
    class PastaChef : Chef
    {
        public override void HandleRequest(object request)
        {
            if (request.ToString() == "Pasta")
            {
                Console.WriteLine("Pasta chef is cooking pasta.");
                return;
            }

            base.HandleRequest(request);
        }
    }
}
