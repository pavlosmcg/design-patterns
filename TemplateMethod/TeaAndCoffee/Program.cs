using System;

namespace TeaAndCoffee
{
    public static class Program
    {
        public static void Main()
        {
            Tea tea = new Tea();
            tea.PrepareRecipie();

            Coffee coffee = new Coffee();
            coffee.PrepareRecipie();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
