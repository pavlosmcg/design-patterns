using System;

namespace TeaAndCoffee
{
    public class Coffee
    {
        public void PrepareRecipie()
        {
            BoilWater();
            BrewCoffeeGrinds();
            PourInCup();
            AddSugarAndMilk();
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling Water");
        }

        private void BrewCoffeeGrinds()
        {
            Console.WriteLine("Dripping coffee through filter");
        }

        private void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        private void AddSugarAndMilk()
        {
            Console.WriteLine("Adding sugar and milk");
        }
    }
}
