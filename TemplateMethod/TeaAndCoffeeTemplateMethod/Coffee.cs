using System;

namespace TeaAndCoffeeTemplateMethod
{
    public class Coffee : HotDrink
    {
        protected override void Brew()
        {
            Console.WriteLine("Dripping coffee through filter");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding milk and sugar");
        }
    }
}
