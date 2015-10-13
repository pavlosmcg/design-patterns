using System;

namespace TeaAndCoffee
{
    public class Tea
    {
        public void PrepareRecipie()
        {
            BoilWater();
            SteepTeaBag();
            PourInCup();
            AddLemon();

            Console.WriteLine("\n");
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        private void SteepTeaBag()
        {
            Console.WriteLine("Steeping the tea");
        }

        private void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        private void AddLemon()
        {
            Console.WriteLine("Adding lemon");
        }
    }
}
