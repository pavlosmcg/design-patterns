using System;
using System.Collections.Generic;

namespace CompositeExample
{
    class Branch : IPlantMatter
    {
        public string Name { get; set; }
        public List<IPlantMatter> Growth { get; set; }

        public void Prune()
        {
            Console.WriteLine("Pruning {0}", Name);

            foreach (var growth in Growth)
            {
                growth.Prune();
            }
        }


    }
}
