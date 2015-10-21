using System;

namespace TeaAndCoffeeTemplateMethod
{
    public abstract class HotDrink
    {
        public void PrepareDrink()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        private void PourInCup()
        {
            Console.WriteLine("Pouring in cup");
        }

        protected abstract void Brew();

        protected abstract void AddCondiments();
    }
}
