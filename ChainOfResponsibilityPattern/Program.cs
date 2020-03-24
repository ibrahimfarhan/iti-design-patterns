using ChainOfResponsibilityPattern.Entities;
using System;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaChef pizzaChef = new PizzaChef();
            PastaChef pastaChef = new PastaChef();
            SeaFoodChef seaFoodChef = new SeaFoodChef();

            pizzaChef.SetNextHandler(pastaChef).SetNextHandler(seaFoodChef);

            foreach (string request in new string[] { "Pizza", "Pasta", "Sea Food", "Salad" })
            {
                pizzaChef.HandleRequest(request);
            }

            Console.ReadLine();
        }
    }
}
