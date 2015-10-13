using System;

namespace TeaAndCoffeeTemplateMethod
{
    public class Tea : HotDrink
    {
        protected override void Brew()
        {
            Console.WriteLine("Steeping tea");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding lemon");
        }
    }
}
