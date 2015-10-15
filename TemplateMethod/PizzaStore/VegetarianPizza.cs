using System;

namespace PizzaStore
{
    public class VegetarianPizza
    {
        public void Prepare()
        {
            PrepareDough();
            AddSauce();
            AddToppings();
            Bake();
            PutInBox();
        }

        private void PrepareDough()
        {
            Console.WriteLine("Kneading dough..");
        }

        private void AddSauce()
        {
            Console.WriteLine("Adding tomato sauce..");
        }

        private void AddToppings()
        {
            Console.WriteLine("Adding peppers..");
            Console.WriteLine("Adding mushrooms..");
            Console.WriteLine("Adding onions..");
            Console.WriteLine("Adding cheese..");
        }

        private void Bake()
        {
            Console.WriteLine("Baking in the oven..");
        }

        private void PutInBox()
        {
            Console.WriteLine("Putting pizza in pizza box..");
        }
    }
}