using System;

namespace PizzaStore
{
    public static class Program
    {
        // look at the two pizza classes and spot the similarities. Try to encapsulate them 
        // in a way that preserves the steps of the pizza making algorithm

        public static void Main()
        {
            Console.WriteLine("Making pepperoni pizza\n");

            PepperoniPizza pepperoniPizza = new PepperoniPizza();
            pepperoniPizza.Prepare();

            Console.WriteLine("\nMaking vegetarian pizza\n");

            VegetarianPizza vegetarianPizza = new VegetarianPizza();
            vegetarianPizza.Prepare();

            Console.WriteLine("\nPress any key to end...");
            Console.ReadKey();
        }
    }
}
