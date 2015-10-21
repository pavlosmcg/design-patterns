using System;

namespace TeaAndCoffeeTemplateMethod
{
    public static class Program
    {
        public static void Main()
        {
            var coffee = new Coffee();
            coffee.PrepareDrink();

            var tea = new Tea();
            tea.PrepareDrink();

            Console.ReadKey();
        }
    }
}
